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
    public partial class FormGerenciarCon : Form
    {
        MySqlDataAdapter adapter;
        MySqlCommandBuilder commanderB;
        MySqlCommand comando;
        MySqlConnection conexão;
        DataTable dt;
        public FormGerenciarCon()
        {
            InitializeComponent();

            conexão = new MySqlConnection(@"server=localhost;user id=root;persistsecurityinfo=True;database=acmc;PWD=123456;SslMode=none");
            adapter = new MySqlDataAdapter("SELECT  paciente_cpf, medico_cpf, id_consulta, data_consulta, diag_med FROM consultas", conexão);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView.DataSource = dt;
        }

        public void Mensagem(string Titulo)
        {
            MessageBox.Show(Titulo, "Aviso", MessageBoxButtons.OK);
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            conexão = new MySqlConnection(@"server=localhost;user id=root;persistsecurityinfo=True;database=acmc;PWD=123456;SslMode=required");
            adapter = new MySqlDataAdapter("SELECT  paciente_cpf, medico_cpf, id_consulta, data_consulta, diag_med FROM consultas", conexão);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView.DataSource = dt;
        }

        private void toolStripButtonPesquisa_Click(object sender, EventArgs e)
        {
            string CPF = toolStripTextBoxPesquisa.Text;
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
                }
            }
            catch
            {
                Mensagem("Não foi possível pesquisar essa consulta!");
            }

        }



        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("Você deseja realmente deletar essa consulta?", "Atenção", MessageBoxButtons.YesNo);
            if (Resultado == DialogResult.Yes)
            {
                try
                {
                    string config = @"server=localhost;user id=root;persistsecurityinfo=True;database=acmc;PWD=123456;SslMode=required";
                    conexão = new MySqlConnection(config);

                    conexão.Open();

                    comando = new MySqlCommand("delete from consultas where id_consulta = ?", conexão);
                    comando.Parameters.Clear();
                    comando.Parameters.Add("@id_consulta", MySqlDbType.VarChar).Value = dataGridView.CurrentRow.Cells[2].Value.ToString();
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                    conexão.Close();
                    toolStripTextBoxPesquisa.Text = "";

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Não foi possível deletar" + erro);

                }
                Mensagem("Consulta Deletado com Sucesso!");
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
                commanderB = new MySqlCommandBuilder(adapter);
                adapter.Update(dt);
                Mensagem("Consulta Atualizada com Sucesso!");
            }
            catch (MySqlException)
            {
                Mensagem("Não é possível editar um CPF!");
            }
            catch (Exception)
            {
                Mensagem("Não foi possível salvar a consulta, tente novamente!");
            }

            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;

            
        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            FormMenu form = new FormMenu();
            form.Show();
            this.Hide();
        }

       
        private void toolStripTextBoxPesquisa_Click(object sender, EventArgs e)
        {
            toolStripTextBoxPesquisa.Text = "";
        }
    }
}
