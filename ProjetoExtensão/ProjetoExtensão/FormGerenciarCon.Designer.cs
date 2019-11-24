namespace ProjetoExtensão
{
    partial class FormGerenciarCon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerenciarCon));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAtualiza = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdita = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSalva = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleta = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBoxPesquisa = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonPesquisa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSair = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(0, 28);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(807, 423);
            this.dataGridView.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAtualiza,
            this.toolStripButtonEdita,
            this.toolStripButtonSalva,
            this.toolStripButtonDeleta,
            this.toolStripSeparator1,
            this.toolStripTextBoxPesquisa,
            this.toolStripButtonPesquisa,
            this.toolStripSeparator2,
            this.toolStripButtonSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAtualiza
            // 
            this.toolStripButtonAtualiza.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAtualiza.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAtualiza.Image")));
            this.toolStripButtonAtualiza.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAtualiza.Name = "toolStripButtonAtualiza";
            this.toolStripButtonAtualiza.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAtualiza.Text = "Atualizar";
            this.toolStripButtonAtualiza.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButtonEdita
            // 
            this.toolStripButtonEdita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEdita.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEdita.Image")));
            this.toolStripButtonEdita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdita.Name = "toolStripButtonEdita";
            this.toolStripButtonEdita.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEdita.Text = "Editar";
            this.toolStripButtonEdita.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButtonSalva
            // 
            this.toolStripButtonSalva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSalva.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSalva.Image")));
            this.toolStripButtonSalva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSalva.Name = "toolStripButtonSalva";
            this.toolStripButtonSalva.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSalva.Text = "Salvar";
            this.toolStripButtonSalva.Click += new System.EventHandler(this.toolStripButtonSalva_Click);
            // 
            // toolStripButtonDeleta
            // 
            this.toolStripButtonDeleta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeleta.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeleta.Image")));
            this.toolStripButtonDeleta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleta.Name = "toolStripButtonDeleta";
            this.toolStripButtonDeleta.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDeleta.Text = "Deletar";
            this.toolStripButtonDeleta.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBoxPesquisa
            // 
            this.toolStripTextBoxPesquisa.BackColor = System.Drawing.SystemColors.HighlightText;
            this.toolStripTextBoxPesquisa.Name = "toolStripTextBoxPesquisa";
            this.toolStripTextBoxPesquisa.Size = new System.Drawing.Size(125, 25);
            this.toolStripTextBoxPesquisa.Text = "Digite o CPF ou Nome";
            this.toolStripTextBoxPesquisa.Click += new System.EventHandler(this.toolStripTextBoxPesquisa_Click);
            // 
            // toolStripButtonPesquisa
            // 
            this.toolStripButtonPesquisa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPesquisa.Image")));
            this.toolStripButtonPesquisa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPesquisa.Name = "toolStripButtonPesquisa";
            this.toolStripButtonPesquisa.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPesquisa.Text = "Pesquisar";
            this.toolStripButtonPesquisa.Click += new System.EventHandler(this.toolStripButtonPesquisa_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSair
            // 
            this.toolStripButtonSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSair.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSair.Image")));
            this.toolStripButtonSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSair.Name = "toolStripButtonSair";
            this.toolStripButtonSair.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSair.Text = "Sair";
            this.toolStripButtonSair.Click += new System.EventHandler(this.toolStripButton1_Click_2);
            // 
            // FormGerenciarCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGerenciarCon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxPesquisa;
        private System.Windows.Forms.ToolStripButton toolStripButtonPesquisa;
        private System.Windows.Forms.ToolStripButton toolStripButtonSair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonAtualiza;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdita;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleta;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSalva;
    }
}