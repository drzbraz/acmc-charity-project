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
    public partial class FormCadastroMed : Form
    {
        public FormCadastroMed()
        {
            InitializeComponent();
        }

        public void HabilitaBotao()
        {
            Operacoes Op = new Operacoes();

            if (maskedTxtCPF.Text != "" && txtNome.Text != "" && maskedTxtRG.Text != "" && comboBoxEstadoCivil.Text != "" && Op.ValidaCPF(maskedTxtCPF.Text) == "O cpf é válido!")
            {
                buttonCadastrar.Enabled = true;
            }
            if(maskedTxtCPF.Text == "" || txtNome.Text == "" || maskedTxtRG.Text == "" || comboBoxEstadoCivil.Text == "" || Op.ValidaCPF(maskedTxtCPF.Text) == "CPF incorreto!")
            {
                buttonCadastrar.Enabled = false;
            }
        }
        public void Mensagem(string Titulo)
        {
            MessageBox.Show(Titulo, "Aviso", MessageBoxButtons.OK);
        }
        public void LimpaCampos()
        {
            maskedTxtCPF.Text = "";
            txtNome.Text = "";
            dateTimePicker.Text = "";
            maskedTxtRG.Text = "";
            comboBoxEstadoCivil.Text = "";
            maskedTxtCelular.Text = "";
            txtMail.Text = "";
        }



        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                TrataString MeuNum = new TrataString();
                Medico NovoMedico = new Medico();

                NovoMedico.CPF = maskedTxtCPF.Text;
                NovoMedico.Nome = txtNome.Text;
                NovoMedico.DataNasc = Convert.ToDateTime(dateTimePicker.Text);
                NovoMedico.RG = maskedTxtRG.Text;
                NovoMedico.EstadoCivil = comboBoxEstadoCivil.Text;
                NovoMedico.Celular = maskedTxtCelular.Text;
                NovoMedico.Mail = txtMail.Text;
                string config = @"server=localhost;user id=root;persistsecurityinfo=True;database=acmc;PWD=123456;SslMode=none";
                MySqlConnection conexão = new MySqlConnection(config);

                conexão.Open();

                MySqlCommand command = new MySqlCommand();

                command.Connection = conexão;

                command.CommandType = CommandType.Text;

                command.CommandText = "insert into Medicos values ('" + NovoMedico.CPF + "','" + NovoMedico.Nome + "'," +
                    "'" + NovoMedico.DataNasc.ToString("yyyy/MM/dd") + "', '" + NovoMedico.RG + "'," +
                    "'" + NovoMedico.EstadoCivil + "','" + NovoMedico.Celular + "'," +
                    "'" + NovoMedico.Mail + "')";

                command.ExecuteNonQuery();
                command.Connection.Close();

                Mensagem("Cadastrado com sucesso!");
                LimpaCampos();
            }
            catch(MySqlException x)
            {
                Mensagem("Já existe cadastro com este CPF!\n" + x.Message);
            }
            catch(Exception x)
            {
                Mensagem("Ocorreu algum erro!\n" + x.Message);
            }
            
        }


        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMenu form = new FormMenu();
            form.Show();
        }

        private void buttonNovoCadastro_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            Operacoes Op = new Operacoes();
            Mensagem(Op.ValidaCPF(maskedTxtCPF.Text));

        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            HabilitaBotao();
        }

        private void maskedTxtCPF_Leave(object sender, EventArgs e)
        {
            HabilitaBotao();
        }

        private void maskedTxtRG_Leave(object sender, EventArgs e)
        {
            HabilitaBotao();
        }

        private void comboBoxEstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitaBotao();
        }
    }
}
