namespace Login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lLogin = new Label();
            lCadastro = new Label();
            tBLoginUsuario = new TextBox();
            tBLoginSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tBCadastroSenha = new TextBox();
            tBCadastroUsuario = new TextBox();
            bEntrar = new Button();
            bCadastrar = new Button();
            lResCadastro = new Label();
            lResLogin = new Label();
            SuspendLayout();
            // 
            // lLogin
            // 
            lLogin.AutoSize = true;
            lLogin.ForeColor = SystemColors.ControlText;
            lLogin.Location = new Point(55, 53);
            lLogin.Name = "lLogin";
            lLogin.Size = new Size(64, 15);
            lLogin.TabIndex = 0;
            lLogin.Text = "Faça login:";
            // 
            // lCadastro
            // 
            lCadastro.AutoSize = true;
            lCadastro.Location = new Point(362, 53);
            lCadastro.Name = "lCadastro";
            lCadastro.Size = new Size(72, 15);
            lCadastro.TabIndex = 1;
            lCadastro.Text = "Cadastre-se:";
            // 
            // tBLoginUsuario
            // 
            tBLoginUsuario.Location = new Point(55, 116);
            tBLoginUsuario.Name = "tBLoginUsuario";
            tBLoginUsuario.Size = new Size(203, 23);
            tBLoginUsuario.TabIndex = 2;
            // 
            // tBLoginSenha
            // 
            tBLoginSenha.Location = new Point(55, 160);
            tBLoginSenha.Name = "tBLoginSenha";
            tBLoginSenha.PasswordChar = '*';
            tBLoginSenha.Size = new Size(203, 23);
            tBLoginSenha.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 98);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 4;
            label1.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 142);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 5;
            label2.Text = "Senha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(362, 142);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 9;
            label3.Text = "Senha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 98);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 8;
            label4.Text = "Usuário:";
            // 
            // tBCadastroSenha
            // 
            tBCadastroSenha.Location = new Point(362, 160);
            tBCadastroSenha.Name = "tBCadastroSenha";
            tBCadastroSenha.PasswordChar = '*';
            tBCadastroSenha.Size = new Size(203, 23);
            tBCadastroSenha.TabIndex = 7;
            // 
            // tBCadastroUsuario
            // 
            tBCadastroUsuario.Location = new Point(362, 116);
            tBCadastroUsuario.Name = "tBCadastroUsuario";
            tBCadastroUsuario.Size = new Size(203, 23);
            tBCadastroUsuario.TabIndex = 6;
            // 
            // bEntrar
            // 
            bEntrar.Location = new Point(111, 203);
            bEntrar.Name = "bEntrar";
            bEntrar.Size = new Size(87, 31);
            bEntrar.TabIndex = 10;
            bEntrar.Text = "Entrar";
            bEntrar.UseVisualStyleBackColor = true;
            bEntrar.Click += bEntrar_Click;
            // 
            // bCadastrar
            // 
            bCadastrar.Location = new Point(418, 203);
            bCadastrar.Name = "bCadastrar";
            bCadastrar.Size = new Size(87, 31);
            bCadastrar.TabIndex = 11;
            bCadastrar.Text = "Cadastrar";
            bCadastrar.UseVisualStyleBackColor = true;
            bCadastrar.Click += bCadastrar_Click;
            // 
            // lResCadastro
            // 
            lResCadastro.AutoSize = true;
            lResCadastro.Location = new Point(362, 239);
            lResCadastro.Name = "lResCadastro";
            lResCadastro.Size = new Size(0, 15);
            lResCadastro.TabIndex = 12;
            // 
            // lResLogin
            // 
            lResLogin.AutoSize = true;
            lResLogin.Location = new Point(55, 239);
            lResLogin.Name = "lResLogin";
            lResLogin.Size = new Size(0, 15);
            lResLogin.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(623, 447);
            Controls.Add(lResLogin);
            Controls.Add(lResCadastro);
            Controls.Add(bCadastrar);
            Controls.Add(bEntrar);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(tBCadastroSenha);
            Controls.Add(tBCadastroUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tBLoginSenha);
            Controls.Add(tBLoginUsuario);
            Controls.Add(lCadastro);
            Controls.Add(lLogin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lLogin;
        private Label lCadastro;
        private TextBox tBLoginUsuario;
        private TextBox tBLoginSenha;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tBCadastroSenha;
        private TextBox tBCadastroUsuario;
        private Button bEntrar;
        private Button bCadastrar;
        private Label lResCadastro;
        private Label lResLogin;
    }
}
