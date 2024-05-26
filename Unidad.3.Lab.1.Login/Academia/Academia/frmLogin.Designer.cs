namespace Academia
{
    partial class frmLogin
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
            btnIngresar = new Button();
            lblUsuario = new Label();
            lblPass = new Label();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            lnkOlvidaPass = new LinkLabel();
            lblBienvenido = new Label();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(317, 269);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(105, 133);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(112, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Nombre de usuario:";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(105, 172);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(70, 15);
            lblPass.TabIndex = 2;
            lblPass.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(235, 125);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(235, 169);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(100, 23);
            txtPass.TabIndex = 4;
            // 
            // lnkOlvidaPass
            // 
            lnkOlvidaPass.AutoSize = true;
            lnkOlvidaPass.Location = new Point(34, 273);
            lnkOlvidaPass.Name = "lnkOlvidaPass";
            lnkOlvidaPass.Size = new Size(119, 15);
            lnkOlvidaPass.TabIndex = 5;
            lnkOlvidaPass.TabStop = true;
            lnkOlvidaPass.Text = "Olvidé mi contraseña";
            lnkOlvidaPass.Click += lnkOlvidaPass_Click;
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Location = new Point(120, 68);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(229, 30);
            lblBienvenido.TabIndex = 6;
            lblBienvenido.Text = "¡Bienvenido al Sistema!\r\nPor favor digite su información de usuario";
            lblBienvenido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmLogin
            // 
            AcceptButton = btnIngresar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 328);
            Controls.Add(lblBienvenido);
            Controls.Add(lnkOlvidaPass);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(lblPass);
            Controls.Add(lblUsuario);
            Controls.Add(btnIngresar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ingreso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private Label lblUsuario;
        private Label lblPass;
        private TextBox txtUsuario;
        private TextBox txtPass;
        private LinkLabel lnkOlvidaPass;
        private Label lblBienvenido;
    }
}
