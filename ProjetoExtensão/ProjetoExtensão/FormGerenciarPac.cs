using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoExtensão
{
    public partial class FormGerenciarPac : Form
    {
        MySqlCommandBuilder commanderB;
        MySqlCommand comando;
        MySqlConnection conexão;
        DataTable dt;
        BD banco = new BD();

        public FormGerenciarPac()
        {
            InitializeComponent();
            
            banco.adapter = new MySqlDataAdapter("SELECT  CPF, Nome, DataNasc, RG, TituloEleitor, NomeMae, EstadoCivil, Familiares, Celular, TelefoneFixo, ContatoAmigo, Mail, " +
                                           "ReCadBiometrico, QntConsultas, CEP, Rua, Número, Bairro, Complemento, Cidade, Estado FROM  pacientes", banco.conexão);

            dt = new DataTable();
            banco.adapter.Fill(dt);
            dataGridView.DataSource = dt;
        }

        public void Mensagem(string Titulo)
        {
            MessageBox.Show(Titulo, "Aviso", MessageBoxButtons.OK);
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            banco.adapter = new MySqlDataAdapter("SELECT  CPF, Nome, DataNasc, RG, TituloEleitor, NomeMae, EstadoCivil, Familiares, Celular, TelefoneFixo, ContatoAmigo, Mail, " +
                                           "ReCadBiometrico, QntConsultas, CEP, Rua, Número, Bairro, Complemento, Cidade, Estado FROM  pacientes", banco.conexão);

            dt = new DataTable();
            banco.adapter.Fill(dt);
            dataGridView.DataSource = dt;
        }

        private void toolStripButtonPesquisa_Click(object sender, EventArgs e)
        {
            string CPF = toolStripTextBoxPesquisa.Text;
            string Nome = toolStripTextBoxPesquisa.Text;
            toolStripTextBoxPesquisa.Text = "";

            dataGridView.ClearSelection();
            try
            {
                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    if (dataGridView.Rows[i].Cells[0].Value.ToString() == CPF)
                    {
                        dataGridView.CurrentCell = dataGridView.Rows[i].Cells[0];
                        break;
                    }
                    else if (dataGridView.Rows[i].Cells[1].Value.ToString() == Nome)
                    {
                        dataGridView.CurrentCell = dataGridView.Rows[i].Cells[1];
                        break;
                    }
                }
            }
            catch
            {
                Mensagem("Não foi possível pesquisar esse cadastro!");
            }

        }

       

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("Você deseja realmente deletar esse cadastro?", "Atenção", MessageBoxButtons.YesNo);
            if (Resultado == DialogResult.Yes)
            {
                try
                {
                      string config = @"server=localhost;user id=root;persistsecurityinfo=True;database=acmc;PWD=123456;SslMode=required";
                      conexão = new MySqlConnection(config);

                      conexão.Open();

                      comando = new MySqlCommand("delete from pacientes where cpf = ?", conexão);
                      comando.Parameters.Clear();
                      comando.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = dataGridView.CurrentRow.Cells[0].Value.ToString();
                      comando.CommandType = CommandType.Text;
                      comando.ExecuteNonQuery();
                      conexão.Close();
                      toolStripTextBoxPesquisa.Text = "";

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Não foi possível deletar" + erro);

                }
                Mensagem("Cadastro Deletado com Sucesso!");
            }
            else
            {
                toolStripTextBoxPesquisa.Text = "";
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            dataGridView.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

        }



        private void toolStripButtonSalva_Click(object sender, EventArgs e)
        {
            toolStripTextBoxPesquisa.Focus();
            toolStripTextBoxPesquisa.DeselectAll();

            try
            {
              commanderB = new MySqlCommandBuilder(banco.adapter);
              banco.adapter.Update(dt);

            }
            catch (Exception)
            {
                Mensagem("Não foi possível salvar o cadastro, tente novamente!");
            }

            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;

            Mensagem("Cadastro Atualizado com Sucesso!");
        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            FormMenu form = new FormMenu();
            form.Show();
            this.Hide();
        }

        private void toolStripTextBoxPesquisa_Click_1(object sender, EventArgs e)
        {
            toolStripTextBoxPesquisa.Text = "";

        }
    }
}
