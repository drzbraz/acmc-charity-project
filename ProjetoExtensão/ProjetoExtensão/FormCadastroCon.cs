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
using System.Threading;



namespace ProjetoExtensão
{
    public partial class FormCadastroCon : Form
    {
        Consulta consulta = new Consulta();
        BD banco = new BD();
 
        public FormCadastroCon()
        {
            InitializeComponent();
            labelLinha.Hide();
            Assinatura.Hide();
        }

        private void CadastrarConsulta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int qtd = 0; string resp = "";
            BD bancoreq = new BD();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm:ss";

            try
            {
                if (txtCpfPac.Text == string.Empty || txtCpfMed.Text == string.Empty)
                {
                    throw new Exception("Existem campos não preenchidos");
                }

                qtd = bancoreq.quantidadeConsultas(txtCpfPac.Text);
                if (qtd < 1)
                {
                    throw new Exception("Paciente não tem consultas restantes");
                }

                consulta.DataConsulta = dateTimePicker1.Text;
                consulta.CPF_medico = txtCpfMed.Text;
                consulta.CPF_paciente = txtCpfPac.Text;
                consulta.DiagMed = txtdiag.Text;

                resp = bancoreq.insereConsulta(consulta, qtd);

                if (resp != "ok")
                {
                    throw new Exception("problema ao casdatrar consulta "+resp);
                }
                qtd--;
                resp = bancoreq.atualizaConsultas(consulta.CPF_paciente, qtd);
                if(resp != "ok")
                {
                    throw new Exception("Problema desconhecido ao salvar consulta no paciente");
                }

                MessageBox.Show("Sucesso! Pacientes possui "+qtd+" consultas restantes", "Aviso", MessageBoxButtons.OK);

            }
            catch (Exception x)
            {
                MessageBox.Show("Erro! "+x.Message, "Aviso", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm:ss";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMenu form = new FormMenu();
            form.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
            
        }
        Bitmap bmp;

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            txtBuscaMed.Focus();
            txtBuscaMed.DeselectAll();
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            txtdiag.Hide();            
            labelDiag.Hide();
            lblBuscarMed.Hide();
            lblBuscarPac.Hide();
            btnBuscaMed.Hide();
            btnBuscaPac.Hide();
            txtBuscaMed.Hide();
            txtBuscaPac.Hide();
            btnCadastroCon.Hide();
            btnDetHora.Hide();
            btnVoltar.Hide();
            btnImprimir.Hide();

            Thread.Sleep(1000);




            bmp = new Bitmap(this.Size.Width, this.Size.Height);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 80, 100, this.Size);

            string text1 = txtdiag.Text;
            using (Font font1 = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(100, 450, 637, 79);
                mg.DrawString(text1, font1, Brushes.Black, rectF1);
                mg.DrawRectangle(Pens.Black, Rectangle.Round(rectF1));
            }
            
            try
            {
               
                printPreviewDialog1.ShowDialog();


            }
            catch (ObjectDisposedException x)
            {

                MessageBox.Show("Aconteceu algo de errado!" + x.Message, "Aviso", MessageBoxButtons.OK);

            }

            labelLinha.Hide();
            Assinatura.Hide();
            labelDiag.Show();
            txtdiag.Show();
            lblBuscarMed.Show();
            lblBuscarPac.Show();
            btnBuscaMed.Show();
            btnBuscaPac.Show();
            txtBuscaMed.Show();
            txtBuscaPac.Show();
            btnCadastroCon.Show();
            btnDetHora.Show();
            btnVoltar.Show();
            btnImprimir.Show();
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void btnBuscaPac_Click(object sender, EventArgs e)
        {
            String cpf = txtBuscaPac.Text;
            String nome = txtBuscaPac.Text;
            String dtNasc;
            Pessoa pac = new Pessoa();
            BD bancoreq = new BD();

            pac = bancoreq.buscarPessoaPorCpf(cpf,"pacientes");

            if (pac.Nome == "nulo" && pac.CPF == "nulo")
            {
                pac = bancoreq.buscarPessoaPorNome(nome,"pacientes");
                if (pac.Nome == "nulo" && pac.CPF == "nulo")
                {
                    cpf = "";
                    nome = "";
                    dtNasc = "";
                }
                else
                {
                    cpf = pac.CPF;
                    nome = pac.Nome;
                    dtNasc = pac.DataNasc.ToString("dd/MM/yyyy");
                }
            }
            else
            {
                cpf = pac.CPF;
                nome = pac.Nome;
                dtNasc = pac.DataNasc.ToString("dd/MM/yyyy");
            }

            txtCpfPac.Text = cpf;
            txtNomePac.Text = nome;
            txtDataNascPac.Text = dtNasc;

        }

        private void btnBuscaMed_Click(object sender, EventArgs e)
        {
            String cpf = txtBuscaMed.Text;
            String nome = txtBuscaMed.Text;
            String dtNasc;
            Pessoa pac = new Pessoa();
            BD bancoreq = new BD();

            pac = bancoreq.buscarPessoaPorCpf(cpf, "medicos");

            if (pac.Nome == "nulo" && pac.CPF == "nulo")
            {
                pac = bancoreq.buscarPessoaPorNome(nome, "medicos");
                if (pac.Nome == "nulo" && pac.CPF == "nulo")
                {
                    nome = "";
                    cpf = "";
                    dtNasc = "";
                }
                else
                {
                    nome = pac.Nome;
                    cpf = pac.CPF;
                    dtNasc = pac.DataNasc.ToString("dd/MM/yyyy");
                }
            }
            else
            {
                nome = pac.Nome;
                cpf = pac.CPF;
                dtNasc = pac.DataNasc.ToString("dd/MM/yyyy");
            }

            txtNomeMed.Text = nome;
            txtDataNascMed.Text = dtNasc;
            txtCpfMed.Text = cpf;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDiag_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeMed_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtDataNascMed_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtdiag_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_MouseHover(object sender, EventArgs e)
        {
            labelLinha.Show();
            Assinatura.Show();
        }
    }
}
