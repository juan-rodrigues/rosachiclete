namespace EmpresaTextil
{
    partial class FormFornecedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>dadadadadadadada ué
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
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btInserir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.tbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNome
            // 
            this.tbNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNome.Location = new System.Drawing.Point(129, 26);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(108, 20);
            this.tbNome.TabIndex = 2;
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbEmail.Location = new System.Drawing.Point(350, 26);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "CNPJ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // btInserir
            // 
            this.btInserir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btInserir.Location = new System.Drawing.Point(76, 61);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(75, 23);
            this.btInserir.TabIndex = 9;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.BtInserir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btAlterar.Location = new System.Drawing.Point(157, 61);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 10;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.BtAlterar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btBuscar.Location = new System.Drawing.Point(319, 61);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 11;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btDeletar.Location = new System.Drawing.Point(238, 61);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(75, 23);
            this.btDeletar.TabIndex = 12;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.BtDeletar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbTelefone);
            this.panel1.Controls.Add(this.tbCNPJ);
            this.panel1.Controls.Add(this.btInserir);
            this.panel1.Controls.Add(this.btAlterar);
            this.panel1.Controls.Add(this.btDeletar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btBuscar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbNome);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 96);
            this.panel1.TabIndex = 15;
            // 
            // tbCNPJ
            // 
            this.tbCNPJ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbCNPJ.Location = new System.Drawing.Point(15, 26);
            this.tbCNPJ.Mask = "00.000.000/0000-00";
            this.tbCNPJ.Name = "tbCNPJ";
            this.tbCNPJ.Size = new System.Drawing.Size(108, 20);
            this.tbCNPJ.TabIndex = 13;
            this.tbCNPJ.Tag = "";
            // 
            // tbTelefone
            // 
            this.tbTelefone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTelefone.Location = new System.Drawing.Point(243, 26);
            this.tbTelefone.Mask = "(99) 00000-0000";
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(100, 20);
            this.tbTelefone.TabIndex = 14;
            // 
            // FormFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 96);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(459, 135);
            this.Name = "FormFornecedores";
            this.Text = "Fornecedores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox tbCNPJ;
        private System.Windows.Forms.MaskedTextBox tbTelefone;
    }
}