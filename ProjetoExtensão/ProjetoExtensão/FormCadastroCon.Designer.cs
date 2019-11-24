namespace ProjetoExtensão
{
    partial class FormCadastroCon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroCon));
            this.lblBuscarPac = new System.Windows.Forms.Label();
            this.txtNomeMed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastroCon = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnDetHora = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBoxPaciente = new System.Windows.Forms.GroupBox();
            this.txtCpfPac = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNomePac = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDataNascPac = new System.Windows.Forms.TextBox();
            this.btnBuscaPac = new System.Windows.Forms.Button();
            this.txtBuscaPac = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCpfMed = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDataNascMed = new System.Windows.Forms.TextBox();
            this.btnBuscaMed = new System.Windows.Forms.Button();
            this.txtBuscaMed = new System.Windows.Forms.TextBox();
            this.lblBuscarMed = new System.Windows.Forms.Label();
            this.labelDiag = new System.Windows.Forms.Label();
            this.txtdiag = new System.Windows.Forms.TextBox();
            this.labelLinha = new System.Windows.Forms.Label();
            this.Assinatura = new System.Windows.Forms.Label();
            this.groupBoxPaciente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBuscarPac
            // 
            this.lblBuscarPac.AutoSize = true;
            this.lblBuscarPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPac.Location = new System.Drawing.Point(283, 17);
            this.lblBuscarPac.Name = "lblBuscarPac";
            this.lblBuscarPac.Size = new System.Drawing.Size(148, 16);
            this.lblBuscarPac.TabIndex = 1;
            this.lblBuscarPac.Text = "Buscar (Nome ou CPF):";
            // 
            // txtNomeMed
            // 
            this.txtNomeMed.Location = new System.Drawing.Point(83, 24);
            this.txtNomeMed.Name = "txtNomeMed";
            this.txtNomeMed.Size = new System.Drawing.Size(192, 23);
            this.txtNomeMed.TabIndex = 25;
            this.txtNomeMed.TextChanged += new System.EventHandler(this.txtNomeMed_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnCadastroCon
            // 
            this.btnCadastroCon.Location = new System.Drawing.Point(307, 626);
            this.btnCadastroCon.Name = "btnCadastroCon";
            this.btnCadastroCon.Size = new System.Drawing.Size(70, 29);
            this.btnCadastroCon.TabIndex = 4;
            this.btnCadastroCon.Text = "Cadastrar";
            this.btnCadastroCon.UseVisualStyleBackColor = true;
            this.btnCadastroCon.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(19, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data e Hora da Consulta:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker1.Location = new System.Drawing.Point(221, 298);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(438, 23);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // btnDetHora
            // 
            this.btnDetHora.Location = new System.Drawing.Point(232, 575);
            this.btnDetHora.Name = "btnDetHora";
            this.btnDetHora.Size = new System.Drawing.Size(230, 29);
            this.btnDetHora.TabIndex = 10;
            this.btnDetHora.Text = "Determinar Hora";
            this.btnDetHora.UseVisualStyleBackColor = true;
            this.btnDetHora.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(580, 629);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(18, 629);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 12;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            this.btnImprimir.MouseHover += new System.EventHandler(this.btnImprimir_MouseHover);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // groupBoxPaciente
            // 
            this.groupBoxPaciente.Controls.Add(this.txtCpfPac);
            this.groupBoxPaciente.Controls.Add(this.label11);
            this.groupBoxPaciente.Controls.Add(this.txtNomePac);
            this.groupBoxPaciente.Controls.Add(this.label8);
            this.groupBoxPaciente.Controls.Add(this.label6);
            this.groupBoxPaciente.Controls.Add(this.txtDataNascPac);
            this.groupBoxPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxPaciente.Location = new System.Drawing.Point(22, 41);
            this.groupBoxPaciente.Name = "groupBoxPaciente";
            this.groupBoxPaciente.Size = new System.Drawing.Size(637, 106);
            this.groupBoxPaciente.TabIndex = 14;
            this.groupBoxPaciente.TabStop = false;
            this.groupBoxPaciente.Text = "Dados do Paciente";
            // 
            // txtCpfPac
            // 
            this.txtCpfPac.Location = new System.Drawing.Point(395, 24);
            this.txtCpfPac.Name = "txtCpfPac";
            this.txtCpfPac.Size = new System.Drawing.Size(138, 23);
            this.txtCpfPac.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(351, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "CPF:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtNomePac
            // 
            this.txtNomePac.Location = new System.Drawing.Point(83, 27);
            this.txtNomePac.Name = "txtNomePac";
            this.txtNomePac.Size = new System.Drawing.Size(192, 23);
            this.txtNomePac.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Data de Nascimento:";
            // 
            // txtDataNascPac
            // 
            this.txtDataNascPac.Location = new System.Drawing.Point(170, 56);
            this.txtDataNascPac.Name = "txtDataNascPac";
            this.txtDataNascPac.Size = new System.Drawing.Size(105, 23);
            this.txtDataNascPac.TabIndex = 15;
            // 
            // btnBuscaPac
            // 
            this.btnBuscaPac.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscaPac.BackgroundImage")));
            this.btnBuscaPac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaPac.Location = new System.Drawing.Point(634, 15);
            this.btnBuscaPac.Name = "btnBuscaPac";
            this.btnBuscaPac.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBuscaPac.Size = new System.Drawing.Size(25, 26);
            this.btnBuscaPac.TabIndex = 23;
            this.btnBuscaPac.UseVisualStyleBackColor = true;
            this.btnBuscaPac.Click += new System.EventHandler(this.btnBuscaPac_Click);
            // 
            // txtBuscaPac
            // 
            this.txtBuscaPac.Location = new System.Drawing.Point(436, 16);
            this.txtBuscaPac.Name = "txtBuscaPac";
            this.txtBuscaPac.Size = new System.Drawing.Size(192, 20);
            this.txtBuscaPac.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCpfMed);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNomeMed);
            this.groupBox1.Controls.Add(this.txtDataNascMed);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(22, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 111);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Médico";
            // 
            // txtCpfMed
            // 
            this.txtCpfMed.Location = new System.Drawing.Point(395, 21);
            this.txtCpfMed.Name = "txtCpfMed";
            this.txtCpfMed.Size = new System.Drawing.Size(145, 23);
            this.txtCpfMed.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(351, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 17);
            this.label15.TabIndex = 26;
            this.label15.Text = "CPF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Data de Nascimento:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtDataNascMed
            // 
            this.txtDataNascMed.Location = new System.Drawing.Point(170, 53);
            this.txtDataNascMed.Name = "txtDataNascMed";
            this.txtDataNascMed.Size = new System.Drawing.Size(105, 23);
            this.txtDataNascMed.TabIndex = 17;
            this.txtDataNascMed.TextChanged += new System.EventHandler(this.txtDataNascMed_TextChanged);
            // 
            // btnBuscaMed
            // 
            this.btnBuscaMed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscaMed.BackgroundImage")));
            this.btnBuscaMed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaMed.Location = new System.Drawing.Point(634, 154);
            this.btnBuscaMed.Name = "btnBuscaMed";
            this.btnBuscaMed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBuscaMed.Size = new System.Drawing.Size(25, 26);
            this.btnBuscaMed.TabIndex = 24;
            this.btnBuscaMed.UseVisualStyleBackColor = true;
            this.btnBuscaMed.Click += new System.EventHandler(this.btnBuscaMed_Click);
            // 
            // txtBuscaMed
            // 
            this.txtBuscaMed.Location = new System.Drawing.Point(436, 158);
            this.txtBuscaMed.Name = "txtBuscaMed";
            this.txtBuscaMed.Size = new System.Drawing.Size(192, 20);
            this.txtBuscaMed.TabIndex = 22;
            // 
            // lblBuscarMed
            // 
            this.lblBuscarMed.AutoSize = true;
            this.lblBuscarMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarMed.Location = new System.Drawing.Point(288, 159);
            this.lblBuscarMed.Name = "lblBuscarMed";
            this.lblBuscarMed.Size = new System.Drawing.Size(148, 16);
            this.lblBuscarMed.TabIndex = 19;
            this.lblBuscarMed.Text = "Buscar (Nome ou CPF):";
            // 
            // labelDiag
            // 
            this.labelDiag.AutoSize = true;
            this.labelDiag.Location = new System.Drawing.Point(273, 343);
            this.labelDiag.Name = "labelDiag";
            this.labelDiag.Size = new System.Drawing.Size(104, 13);
            this.labelDiag.TabIndex = 17;
            this.labelDiag.Text = "Diagnóstico Médico:";
            this.labelDiag.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtdiag
            // 
            this.txtdiag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtdiag.Location = new System.Drawing.Point(20, 363);
            this.txtdiag.Multiline = true;
            this.txtdiag.Name = "txtdiag";
            this.txtdiag.Size = new System.Drawing.Size(637, 79);
            this.txtdiag.TabIndex = 18;
            this.txtdiag.TextChanged += new System.EventHandler(this.txtdiag_TextChanged);
            // 
            // labelLinha
            // 
            this.labelLinha.AutoSize = true;
            this.labelLinha.Location = new System.Drawing.Point(124, 524);
            this.labelLinha.Name = "labelLinha";
            this.labelLinha.Size = new System.Drawing.Size(451, 13);
            this.labelLinha.TabIndex = 25;
            this.labelLinha.Text = "__________________________________________________________________________";
            this.labelLinha.Click += new System.EventHandler(this.label5_Click);
            // 
            // Assinatura
            // 
            this.Assinatura.AutoSize = true;
            this.Assinatura.Location = new System.Drawing.Point(315, 548);
            this.Assinatura.Name = "Assinatura";
            this.Assinatura.Size = new System.Drawing.Size(56, 13);
            this.Assinatura.TabIndex = 26;
            this.Assinatura.Text = "Assinatura";
            // 
            // FormCadastroCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.Assinatura);
            this.Controls.Add(this.labelLinha);
            this.Controls.Add(this.txtdiag);
            this.Controls.Add(this.labelDiag);
            this.Controls.Add(this.btnBuscaPac);
            this.Controls.Add(this.txtBuscaPac);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscaMed);
            this.Controls.Add(this.groupBoxPaciente);
            this.Controls.Add(this.txtBuscaMed);
            this.Controls.Add(this.lblBuscarMed);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblBuscarPac);
            this.Controls.Add(this.btnDetHora);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCadastroCon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastroCon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Consulta";
            this.Load += new System.EventHandler(this.CadastrarConsulta_Load);
            this.groupBoxPaciente.ResumeLayout(false);
            this.groupBoxPaciente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
     
        private System.Windows.Forms.Label lblBuscarPac;
        private System.Windows.Forms.TextBox txtNomeMed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastroCon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnDetHora;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.GroupBox groupBoxPaciente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDataNascPac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDataNascMed;
        private System.Windows.Forms.TextBox txtNomePac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCpfPac;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBuscaPac;
        private System.Windows.Forms.TextBox txtBuscaMed;
        private System.Windows.Forms.Label lblBuscarMed;
        private System.Windows.Forms.Button btnBuscaPac;
        private System.Windows.Forms.Button btnBuscaMed;
        private System.Windows.Forms.TextBox txtCpfMed;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelDiag;
        private System.Windows.Forms.TextBox txtdiag;
        private System.Windows.Forms.Label labelLinha;
        private System.Windows.Forms.Label Assinatura;
    }
}