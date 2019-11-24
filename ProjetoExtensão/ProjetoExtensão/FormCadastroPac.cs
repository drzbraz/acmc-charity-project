using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExtensão
{
    public partial class CadastroPaciente : Form
    {

        public CadastroPaciente()
        {
            InitializeComponent();
        }

        public void Mensagem(string Titulo)
        {
            MessageBox.Show(Titulo, "Aviso", MessageBoxButtons.OK);
        }
        public void HabilitaBotao()
        {
            Operacoes Op = new Operacoes();

            if (maskedTxtCPF.Text != "" && txtNome.Text != "" && maskedTxtRG.Text != "" && comboBoxEstadoCivil.Text != "" && Op.ValidaCPF(maskedTxtCPF.Text) == "O cpf é válido!")
            {
                buttonCadastrar.Enabled = true;
            }
            if (maskedTxtCPF.Text == "" || txtNome.Text == "" || maskedTxtRG.Text == "" || comboBoxEstadoCivil.Text == "" || Op.ValidaCPF(maskedTxtCPF.Text) == "CPF incorreto!")
            {
                buttonCadastrar.Enabled = false;
            }
        }
        public void LimpaCampos()
        {
            maskedTxtCPF.Text = "";
            txtNome.Text = "";
            dateTimePicker.Text = "";
            maskedTxtRG.Text = "";
            maskedTxtTítuloEleitor.Text = "";
            txtNomeMãe.Text = "";
            comboBoxEstadoCivil.Text = "";
            txtFamiliares.Text = "";
            maskedTxtCelular.Text = "";
            maskedTxtTelefoneFixo.Text = "";
            maskedTxtContatoAmigo.Text = "";
            txtMail.Text = "";
            radioButtonNão.Checked = false;
            radioButtonSim.Checked = false;
            txtQntConsultas.Text = "";
            txtCEP.Text = "";
            txtRua.Text = "";
            txtNúmero.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
        }
        private void buttonBuscarCEP_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", txtCEP.Text);
                ds.ReadXml(xml);

                txtRua.Text = ds.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = ds.Tables[0].Rows[0]["cidade"].ToString();
                txtEstado.Text = ds.Tables[0].Rows[0]["uf"].ToString();

            }
            catch (Exception)
            {
                Mensagem("O computador está sem acesso a internet, favor digitar manualmente!");
            }
        }


        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                TrataString MeuNum = new TrataString();
                Paciente NovoPaciente = new Paciente();

                NovoPaciente.CPF = maskedTxtCPF.Text;
                NovoPaciente.Nome = txtNome.Text;
                NovoPaciente.DataNasc = Convert.ToDateTime(dateTimePicker.Text);
                NovoPaciente.RG = maskedTxtRG.Text;
                NovoPaciente.TituloDeEleitor = maskedTxtTítuloEleitor.Text;
                NovoPaciente.NomeMãe = txtNomeMãe.Text;
                NovoPaciente.EstadoCivil = comboBoxEstadoCivil.Text;
                NovoPaciente.Familiares = txtFamiliares.Text;
                NovoPaciente.Celular = maskedTxtCelular.Text;
                NovoPaciente.TelefoneFixo = maskedTxtTelefoneFixo.Text;
                NovoPaciente.ContatoAmigo = maskedTxtContatoAmigo.Text;
                NovoPaciente.Mail = txtMail.Text;

                if (radioButtonSim.Checked)
                    NovoPaciente.ReCadBiométrico = "S";
                else
                    NovoPaciente.ReCadBiométrico = "N";
                if (txtQntConsultas.Text == "")
                {
                    txtQntConsultas.Text = "0";
                }
                else
                    NovoPaciente.QntConsultas = Convert.ToDouble(txtQntConsultas.Text);

                NovoPaciente.CEP = txtCEP.Text;
                NovoPaciente.Rua = txtRua.Text;
                NovoPaciente.Número = txtNúmero.Text;
                NovoPaciente.Complemento = txtComplemento.Text;
                NovoPaciente.Bairro = txtBairro.Text;
                NovoPaciente.Cidade = txtCidade.Text;
                NovoPaciente.Estado = txtEstado.Text;

                string config = @"server=localhost;user id=root;persistsecurityinfo=True;database=acmc;PWD=123456;SslMode=required";
                MySqlConnection conexão = new MySqlConnection(config);

                conexão.Open();

                MySqlCommand command = new MySqlCommand();

                command.Connection = conexão;

                command.CommandType = CommandType.Text;

                command.CommandText = "insert into Pacientes values ('" + NovoPaciente.CPF + "','" + NovoPaciente.Nome + "'," +
                    "'" + NovoPaciente.DataNasc.ToString("yyyy/MM/dd") + "', '" + NovoPaciente.RG + "'," +
                    "'" + NovoPaciente.TituloDeEleitor + "','" + NovoPaciente.NomeMãe + "'," +
                    "'" + NovoPaciente.EstadoCivil + "', '" + NovoPaciente.Familiares + "','" + NovoPaciente.Celular + "'," +
                    "'" + NovoPaciente.TelefoneFixo + "', '" + NovoPaciente.ContatoAmigo + "'," +
                    "'" + NovoPaciente.Mail + "', '" + NovoPaciente.ReCadBiométrico + "', " + NovoPaciente.QntConsultas + ", '" + NovoPaciente.CEP + "', " +
                    "'" + NovoPaciente.Rua + "',  '" + NovoPaciente.Número + "','" + NovoPaciente.Complemento + "', '" + NovoPaciente.Bairro + "','" + NovoPaciente.Cidade + "', '" + NovoPaciente.Estado + "')";

                command.ExecuteNonQuery();
                command.Connection.Close();

                Mensagem("Cadastrado com sucesso!");
                LimpaCampos();
            }
            catch (MySqlException x)
            {
                Mensagem("Já existe um cadastro com esse CPF!\n"+x.Message);
            }
            catch(Exception x)
            {
                Mensagem("Ocorreu algum erro! Tente novamente.\n" + x.Message);
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

        private void comboBoxEstadoCivil_Leave(object sender, EventArgs e)
        {
            HabilitaBotao();
        }
    }
}

