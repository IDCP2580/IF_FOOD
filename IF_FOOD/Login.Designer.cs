namespace IF_FOOD
{
    partial class w_Login
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
            txb_Username = new TextBox();
            lbl_Username = new Label();
            btn_Login = new Button();
            txb_Senha = new TextBox();
            lbl_Senha = new Label();
            cb_MostrarSenha = new CheckBox();
            btn_CancelarLogin = new Button();
            panel1 = new Panel();
            label1 = new Label();
            SuspendLayout();
            // 
            // txb_Username
            // 
            txb_Username.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_Username.Location = new Point(326, 148);
            txb_Username.Margin = new Padding(3, 2, 3, 2);
            txb_Username.Multiline = true;
            txb_Username.Name = "txb_Username";
            txb_Username.Size = new Size(332, 27);
            txb_Username.TabIndex = 1;
            txb_Username.TextChanged += txb_Username_TextChanged;
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Username.Location = new Point(326, 118);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(87, 19);
            lbl_Username.TabIndex = 2;
            lbl_Username.Text = "Username";
            // 
            // btn_Login
            // 
            btn_Login.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Login.Location = new Point(326, 321);
            btn_Login.Margin = new Padding(3, 2, 3, 2);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(110, 37);
            btn_Login.TabIndex = 3;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // txb_Senha
            // 
            txb_Senha.Location = new Point(329, 244);
            txb_Senha.Margin = new Padding(3, 2, 3, 2);
            txb_Senha.Multiline = true;
            txb_Senha.Name = "txb_Senha";
            txb_Senha.PasswordChar = '*';
            txb_Senha.Size = new Size(332, 28);
            txb_Senha.TabIndex = 4;
            // 
            // lbl_Senha
            // 
            lbl_Senha.AutoSize = true;
            lbl_Senha.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Senha.Location = new Point(329, 217);
            lbl_Senha.Name = "lbl_Senha";
            lbl_Senha.Size = new Size(58, 19);
            lbl_Senha.TabIndex = 5;
            lbl_Senha.Text = "Senha";
            // 
            // cb_MostrarSenha
            // 
            cb_MostrarSenha.AutoSize = true;
            cb_MostrarSenha.Location = new Point(550, 284);
            cb_MostrarSenha.Margin = new Padding(3, 2, 3, 2);
            cb_MostrarSenha.Name = "cb_MostrarSenha";
            cb_MostrarSenha.Size = new Size(102, 19);
            cb_MostrarSenha.TabIndex = 6;
            cb_MostrarSenha.Text = "Mostrar Senha";
            cb_MostrarSenha.UseVisualStyleBackColor = true;
            cb_MostrarSenha.CheckedChanged += cb_MostrarSenha_CheckedChanged;
            // 
            // btn_CancelarLogin
            // 
            btn_CancelarLogin.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CancelarLogin.Location = new Point(548, 321);
            btn_CancelarLogin.Margin = new Padding(3, 2, 3, 2);
            btn_CancelarLogin.Name = "btn_CancelarLogin";
            btn_CancelarLogin.Size = new Size(113, 37);
            btn_CancelarLogin.TabIndex = 7;
            btn_CancelarLogin.Text = "Cancelar";
            btn_CancelarLogin.UseVisualStyleBackColor = true;
            btn_CancelarLogin.Click += btn_CancelarLogin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Location = new Point(-7, -8);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 396);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(329, 43);
            label1.Name = "label1";
            label1.Size = new Size(153, 31);
            label1.TabIndex = 9;
            label1.Text = "Bem Vindo!";
            // 
            // w_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 382);
            Controls.Add(txb_Senha);
            Controls.Add(lbl_Senha);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btn_CancelarLogin);
            Controls.Add(cb_MostrarSenha);
            Controls.Add(btn_Login);
            Controls.Add(lbl_Username);
            Controls.Add(txb_Username);
            Margin = new Padding(3, 2, 3, 2);
            Name = "w_Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txb_Username;
        private Label lbl_Username;
        private Button btn_Login;
        private TextBox txb_Senha;
        private Label lbl_Senha;
        private CheckBox cb_MostrarSenha;
        private Button btn_CancelarLogin;
        private Panel panel1;
        private Label label1;
    }
}