namespace BlackFit.Telas
{
    partial class TelaAlterarSenha
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.TxtConfNovaSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNovaSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSenhaAtual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.BtnCancelar);
            this.groupBox1.Controls.Add(this.BtnConfirmar);
            this.groupBox1.Controls.Add(this.TxtConfNovaSenha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtNovaSenha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtSenhaAtual);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(61, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 324);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alterar Senha";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(50, 253);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(110, 43);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Location = new System.Drawing.Point(166, 253);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(121, 43);
            this.BtnConfirmar.TabIndex = 6;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            // 
            // TxtConfNovaSenha
            // 
            this.TxtConfNovaSenha.Location = new System.Drawing.Point(50, 196);
            this.TxtConfNovaSenha.Name = "TxtConfNovaSenha";
            this.TxtConfNovaSenha.PasswordChar = '*';
            this.TxtConfNovaSenha.Size = new System.Drawing.Size(237, 31);
            this.TxtConfNovaSenha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirmar Nova Senha:";
            // 
            // TxtNovaSenha
            // 
            this.TxtNovaSenha.Location = new System.Drawing.Point(50, 134);
            this.TxtNovaSenha.Name = "TxtNovaSenha";
            this.TxtNovaSenha.PasswordChar = '*';
            this.TxtNovaSenha.Size = new System.Drawing.Size(237, 31);
            this.TxtNovaSenha.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nova Senha:";
            // 
            // TxtSenhaAtual
            // 
            this.TxtSenhaAtual.Location = new System.Drawing.Point(50, 72);
            this.TxtSenhaAtual.Name = "TxtSenhaAtual";
            this.TxtSenhaAtual.PasswordChar = '*';
            this.TxtSenhaAtual.Size = new System.Drawing.Size(237, 31);
            this.TxtSenhaAtual.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Senha Atual:";
            // 
            // TelaAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackFit.Properties.Resources.alterarsenha;
            this.ClientSize = new System.Drawing.Size(443, 552);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TelaAlterarSenha";
            this.Text = "TelaAlterarSenha";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.TextBox TxtConfNovaSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNovaSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSenhaAtual;
        private System.Windows.Forms.Label label1;
    }
}