namespace ProjetoExtensão
{
    partial class FormCadastroMed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroMed));
            this.groupBoxDadosCompl = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.maskedTxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.groupBoxDadosPaciente = new System.Windows.Forms.GroupBox();
            this.buttonValidar = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.maskedTxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTxtRG = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonNovoCadastro = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.groupBoxDadosCompl.SuspendLayout();
            this.groupBoxDadosPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDadosCompl
            // 
            this.groupBoxDadosCompl.Controls.Add(this.label13);
            this.groupBoxDadosCompl.Controls.Add(this.maskedTxtCelular);
            this.groupBoxDadosCompl.Controls.Add(this.label16);
            this.groupBoxDadosCompl.Controls.Add(this.comboBoxEstadoCivil);
            this.groupBoxDadosCompl.Controls.Add(this.label18);
            this.groupBoxDadosCompl.Controls.Add(this.txtMail);
            this.groupBoxDadosCompl.Location = new System.Drawing.Point(19, 270);
            this.groupBoxDadosCompl.Name = "groupBoxDadosCompl";
            this.groupBoxDadosCompl.Size = new System.Drawing.Size(650, 143);
            this.groupBoxDadosCompl.TabIndex = 85;
            this.groupBoxDadosCompl.TabStop = false;
            this.groupBoxDadosCompl.Text = "Dados Complementares";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(88, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 58;
            this.label13.Text = "Celular:";
            // 
            // maskedTxtCelular
            // 
            this.maskedTxtCelular.Location = new System.Drawing.Point(137, 67);
            this.maskedTxtCelular.Mask = "(99) 0-0000-0000";
            this.maskedTxtCelular.Name = "maskedTxtCelular";
            this.maskedTxtCelular.Size = new System.Drawing.Size(93, 20);
            this.maskedTxtCelular.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(62, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 65;
            this.label16.Text = "Estado Civil:*";
            // 
            // comboBoxEstadoCivil
            // 
            this.comboBoxEstadoCivil.FormattingEnabled = true;
            this.comboBoxEstadoCivil.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Separado(a)",
            "Divorciado(a)",
            "Viúvo(a)"});
            this.comboBoxEstadoCivil.Location = new System.Drawing.Point(137, 40);
            this.comboBoxEstadoCivil.Name = "comboBoxEstadoCivil";
            this.comboBoxEstadoCivil.Size = new System.Drawing.Size(93, 21);
            this.comboBoxEstadoCivil.TabIndex = 7;
            this.comboBoxEstadoCivil.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstadoCivil_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(88, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 13);
            this.label18.TabIndex = 69;
            this.label18.Text = "E-Mail:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(137, 93);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(171, 20);
            this.txtMail.TabIndex = 12;
            // 
            // groupBoxDadosPaciente
            // 
            this.groupBoxDadosPaciente.Controls.Add(this.buttonValidar);
            this.groupBoxDadosPaciente.Controls.Add(this.dateTimePicker);
            this.groupBoxDadosPaciente.Controls.Add(this.label1);
            this.groupBoxDadosPaciente.Controls.Add(this.txtNome);
            this.groupBoxDadosPaciente.Controls.Add(this.maskedTxtCPF);
            this.groupBoxDadosPaciente.Controls.Add(this.label10);
            this.groupBoxDadosPaciente.Controls.Add(this.label9);
            this.groupBoxDadosPaciente.Controls.Add(this.maskedTxtRG);
            this.groupBoxDadosPaciente.Controls.Add(this.label12);
            this.groupBoxDadosPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDadosPaciente.Location = new System.Drawing.Point(19, 92);
            this.groupBoxDadosPaciente.Name = "groupBoxDadosPaciente";
            this.groupBoxDadosPaciente.Size = new System.Drawing.Size(650, 172);
            this.groupBoxDadosPaciente.TabIndex = 84;
            this.groupBoxDadosPaciente.TabStop = false;
            this.groupBoxDadosPaciente.Text = "Dados do Médico";
            // 
            // buttonValidar
            // 
            this.buttonValidar.Location = new System.Drawing.Point(229, 95);
            this.buttonValidar.Name = "buttonValidar";
            this.buttonValidar.Size = new System.Drawing.Size(75, 21);
            this.buttonValidar.TabIndex = 63;
            this.buttonValidar.Text = "Validar";
            this.buttonValidar.UseVisualStyleBackColor = true;
            this.buttonValidar.Click += new System.EventHandler(this.buttonValidar_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "";
            this.dateTimePicker.Location = new System.Drawing.Point(137, 70);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(213, 20);
            this.dateTimePicker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nome:*";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(137, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(358, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // maskedTxtCPF
            // 
            this.maskedTxtCPF.Location = new System.Drawing.Point(137, 96);
            this.maskedTxtCPF.Mask = "000-000-000-00";
            this.maskedTxtCPF.Name = "maskedTxtCPF";
            this.maskedTxtCPF.Size = new System.Drawing.Size(87, 20);
            this.maskedTxtCPF.TabIndex = 3;
            this.maskedTxtCPF.Leave += new System.EventHandler(this.maskedTxtCPF_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(101, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "CPF:*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Data de Nascimento:";
            // 
            // maskedTxtRG
            // 
            this.maskedTxtRG.Location = new System.Drawing.Point(137, 122);
            this.maskedTxtRG.Mask = "00-000-000";
            this.maskedTxtRG.Name = "maskedTxtRG";
            this.maskedTxtRG.Size = new System.Drawing.Size(63, 20);
            this.maskedTxtRG.TabIndex = 4;
            this.maskedTxtRG.Leave += new System.EventHandler(this.maskedTxtRG_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(105, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 56;
            this.label12.Text = "RG:*";
            // 
            // buttonNovoCadastro
            // 
            this.buttonNovoCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovoCadastro.Location = new System.Drawing.Point(386, 599);
            this.buttonNovoCadastro.Name = "buttonNovoCadastro";
            this.buttonNovoCadastro.Size = new System.Drawing.Size(112, 29);
            this.buttonNovoCadastro.TabIndex = 83;
            this.buttonNovoCadastro.Text = "NOVO CADASTRO";
            this.buttonNovoCadastro.UseVisualStyleBackColor = true;
            this.buttonNovoCadastro.Click += new System.EventHandler(this.buttonNovoCadastro_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVoltar.Location = new System.Drawing.Point(194, 599);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(81, 29);
            this.buttonVoltar.TabIndex = 82;
            this.buttonVoltar.Text = "VOLTAR";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Enabled = false;
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrar.Location = new System.Drawing.Point(283, 551);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(97, 29);
            this.buttonCadastrar.TabIndex = 81;
            this.buttonCadastrar.Text = "CADASTRAR";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // FormCadastroMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.groupBoxDadosCompl);
            this.Controls.Add(this.groupBoxDadosPaciente);
            this.Controls.Add(this.buttonNovoCadastro);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonCadastrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastroMed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Médico";
            this.groupBoxDadosCompl.ResumeLayout(false);
            this.groupBoxDadosCompl.PerformLayout();
            this.groupBoxDadosPaciente.ResumeLayout(false);
            this.groupBoxDadosPaciente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxDadosCompl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox maskedTxtCelular;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBoxEstadoCivil;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.GroupBox groupBoxDadosPaciente;
        private System.Windows.Forms.Button buttonValidar;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox maskedTxtCPF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTxtRG;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonNovoCadastro;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonCadastrar;
    }
}
