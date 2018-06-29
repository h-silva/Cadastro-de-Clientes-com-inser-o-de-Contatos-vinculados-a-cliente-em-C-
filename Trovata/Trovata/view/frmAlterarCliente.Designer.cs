namespace Trovato.view
{
    partial class frmAlterarCliente
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
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.mskRGIE = new System.Windows.Forms.MaskedTextBox();
            this.mskCPFCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblNumEndereço = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblRGIE = new System.Windows.Forms.Label();
            this.lblCPFCNPJ = new System.Windows.Forms.Label();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.gbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.mskRGIE);
            this.gbCliente.Controls.Add(this.mskCPFCNPJ);
            this.gbCliente.Controls.Add(this.mskCelular);
            this.gbCliente.Controls.Add(this.mskTelefone);
            this.gbCliente.Controls.Add(this.btnAtualizar);
            this.gbCliente.Controls.Add(this.lblCidade);
            this.gbCliente.Controls.Add(this.lblBairro);
            this.gbCliente.Controls.Add(this.lblNumEndereço);
            this.gbCliente.Controls.Add(this.lblEndereco);
            this.gbCliente.Controls.Add(this.lblEmail);
            this.gbCliente.Controls.Add(this.lblCelular);
            this.gbCliente.Controls.Add(this.lblTelefone);
            this.gbCliente.Controls.Add(this.lblSituacao);
            this.gbCliente.Controls.Add(this.lblTipo);
            this.gbCliente.Controls.Add(this.lblRGIE);
            this.gbCliente.Controls.Add(this.lblCPFCNPJ);
            this.gbCliente.Controls.Add(this.lblNomeFantasia);
            this.gbCliente.Controls.Add(this.lblRazaoSocial);
            this.gbCliente.Controls.Add(this.cbCidade);
            this.gbCliente.Controls.Add(this.txtBairro);
            this.gbCliente.Controls.Add(this.txtNumero);
            this.gbCliente.Controls.Add(this.txtEndereco);
            this.gbCliente.Controls.Add(this.txtEmail);
            this.gbCliente.Controls.Add(this.cbSituacao);
            this.gbCliente.Controls.Add(this.cbTipo);
            this.gbCliente.Controls.Add(this.txtNomeFantasia);
            this.gbCliente.Controls.Add(this.txtRazaoSocial);
            this.gbCliente.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(12, 15);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(817, 348);
            this.gbCliente.TabIndex = 1;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Atualização de dados";
            // 
            // mskRGIE
            // 
            this.mskRGIE.Enabled = false;
            this.mskRGIE.Location = new System.Drawing.Point(194, 130);
            this.mskRGIE.Name = "mskRGIE";
            this.mskRGIE.Size = new System.Drawing.Size(169, 29);
            this.mskRGIE.TabIndex = 5;
            this.mskRGIE.TabStop = false;
            // 
            // mskCPFCNPJ
            // 
            this.mskCPFCNPJ.Enabled = false;
            this.mskCPFCNPJ.Location = new System.Drawing.Point(21, 130);
            this.mskCPFCNPJ.Name = "mskCPFCNPJ";
            this.mskCPFCNPJ.Size = new System.Drawing.Size(151, 29);
            this.mskCPFCNPJ.TabIndex = 4;
            this.mskCPFCNPJ.TabStop = false;
            // 
            // mskCelular
            // 
            this.mskCelular.Location = new System.Drawing.Point(194, 214);
            this.mskCelular.Mask = "(99)0000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(169, 29);
            this.mskCelular.TabIndex = 8;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(21, 214);
            this.mskTelefone.Mask = "(99)0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(151, 29);
            this.mskTelefone.TabIndex = 7;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Location = new System.Drawing.Point(627, 291);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(116, 39);
            this.btnAtualizar.TabIndex = 14;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(383, 275);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(60, 23);
            this.lblCidade.TabIndex = 38;
            this.lblCidade.Text = "Cidade";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(190, 275);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(51, 23);
            this.lblBairro.TabIndex = 36;
            this.lblBairro.Text = "Bairro";
            // 
            // lblNumEndereço
            // 
            this.lblNumEndereço.AutoSize = true;
            this.lblNumEndereço.Location = new System.Drawing.Point(17, 275);
            this.lblNumEndereço.Name = "lblNumEndereço";
            this.lblNumEndereço.Size = new System.Drawing.Size(66, 23);
            this.lblNumEndereço.TabIndex = 34;
            this.lblNumEndereço.Text = "Número";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(383, 188);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(78, 23);
            this.lblEndereco.TabIndex = 32;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(383, 104);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 23);
            this.lblEmail.TabIndex = 30;
            this.lblEmail.Text = "E-mail";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(190, 188);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(59, 23);
            this.lblCelular.TabIndex = 28;
            this.lblCelular.Text = "Celular";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(17, 188);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(70, 23);
            this.lblTelefone.TabIndex = 26;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(651, 34);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(70, 23);
            this.lblSituacao.TabIndex = 24;
            this.lblSituacao.Text = "Situação";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(553, 32);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(40, 23);
            this.lblTipo.TabIndex = 22;
            this.lblTipo.Text = "Tipo";
            // 
            // lblRGIE
            // 
            this.lblRGIE.AutoSize = true;
            this.lblRGIE.Location = new System.Drawing.Point(190, 104);
            this.lblRGIE.Name = "lblRGIE";
            this.lblRGIE.Size = new System.Drawing.Size(50, 23);
            this.lblRGIE.TabIndex = 20;
            this.lblRGIE.Text = "RG/IE";
            // 
            // lblCPFCNPJ
            // 
            this.lblCPFCNPJ.AutoSize = true;
            this.lblCPFCNPJ.Location = new System.Drawing.Point(17, 104);
            this.lblCPFCNPJ.Name = "lblCPFCNPJ";
            this.lblCPFCNPJ.Size = new System.Drawing.Size(85, 23);
            this.lblCPFCNPJ.TabIndex = 18;
            this.lblCPFCNPJ.Text = "CPF/CNPJ";
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Location = new System.Drawing.Point(307, 34);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(116, 23);
            this.lblNomeFantasia.TabIndex = 16;
            this.lblNomeFantasia.Text = "Nome Fantasia";
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Location = new System.Drawing.Point(17, 34);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(102, 23);
            this.lblRazaoSocial.TabIndex = 14;
            this.lblRazaoSocial.Text = "Razão Social";
            // 
            // cbCidade
            // 
            this.cbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.ItemHeight = 23;
            this.cbCidade.Location = new System.Drawing.Point(387, 301);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(184, 31);
            this.cbCidade.TabIndex = 13;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(194, 301);
            this.txtBairro.MaxLength = 60;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(169, 29);
            this.txtBairro.TabIndex = 11;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(21, 301);
            this.txtNumero.MaxLength = 20;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(151, 29);
            this.txtNumero.TabIndex = 10;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(387, 214);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(356, 29);
            this.txtEndereco.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(387, 130);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(356, 29);
            this.txtEmail.TabIndex = 6;
            // 
            // cbSituacao
            // 
            this.cbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbSituacao.Location = new System.Drawing.Point(655, 58);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(88, 31);
            this.cbSituacao.TabIndex = 3;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Enabled = false;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Física",
            "Júridica"});
            this.cbTipo.Location = new System.Drawing.Point(557, 58);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(80, 31);
            this.cbTipo.TabIndex = 2;
            this.cbTipo.TabStop = false;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Location = new System.Drawing.Point(311, 60);
            this.txtNomeFantasia.MaxLength = 100;
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(225, 29);
            this.txtNomeFantasia.TabIndex = 1;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(21, 60);
            this.txtRazaoSocial.MaxLength = 100;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(266, 29);
            this.txtRazaoSocial.TabIndex = 0;
            // 
            // frmAlterarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 379);
            this.Controls.Add(this.gbCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAlterarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trovata - Atualizar Cliente";
            this.Load += new System.EventHandler(this.frmAlterarCliente_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.MaskedTextBox mskRGIE;
        private System.Windows.Forms.MaskedTextBox mskCPFCNPJ;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblNumEndereço;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblRGIE;
        private System.Windows.Forms.Label lblCPFCNPJ;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.TextBox txtRazaoSocial;
    }
}