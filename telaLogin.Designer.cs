namespace senacBank
{
    partial class telaLogin
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaLogin));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            botaoRegistro = new Guna.UI2.WinForms.Guna2Button();
            botaoLogin = new Guna.UI2.WinForms.Guna2Button();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // botaoRegistro
            // 
            botaoRegistro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            botaoRegistro.CustomizableEdges = customizableEdges1;
            botaoRegistro.DisabledState.BorderColor = Color.DarkGray;
            botaoRegistro.DisabledState.CustomBorderColor = Color.DarkGray;
            botaoRegistro.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            botaoRegistro.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            botaoRegistro.Font = new Font("Impact", 12F);
            botaoRegistro.ForeColor = Color.Black;
            botaoRegistro.Location = new Point(626, 472);
            botaoRegistro.Margin = new Padding(3, 2, 3, 2);
            botaoRegistro.Name = "botaoRegistro";
            botaoRegistro.ShadowDecoration.CustomizableEdges = customizableEdges2;
            botaoRegistro.Size = new Size(228, 78);
            botaoRegistro.TabIndex = 6;
            botaoRegistro.Text = "CRIAR CONTA";
            botaoRegistro.Click += botaoRegistro_Click;
            // 
            // botaoLogin
            // 
            botaoLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            botaoLogin.CustomizableEdges = customizableEdges3;
            botaoLogin.DisabledState.BorderColor = Color.DarkGray;
            botaoLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            botaoLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            botaoLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            botaoLogin.Font = new Font("Impact", 12F);
            botaoLogin.ForeColor = Color.Black;
            botaoLogin.Location = new Point(626, 335);
            botaoLogin.Margin = new Padding(3, 2, 3, 2);
            botaoLogin.Name = "botaoLogin";
            botaoLogin.ShadowDecoration.CustomizableEdges = customizableEdges4;
            botaoLogin.Size = new Size(228, 78);
            botaoLogin.TabIndex = 5;
            botaoLogin.Text = "JÁ TENHO CONTA";
            botaoLogin.Click += botaoLogin_Click;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.Anchor = AnchorStyles.Top;
            guna2PictureBox1.CustomizableEdges = customizableEdges5;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(524, 11);
            guna2PictureBox1.Margin = new Padding(3, 2, 3, 2);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2PictureBox1.Size = new Size(454, 237);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabIndex = 4;
            guna2PictureBox1.TabStop = false;
            // 
            // telaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(76, 75, 105);
            ClientSize = new Size(1492, 689);
            Controls.Add(botaoRegistro);
            Controls.Add(botaoLogin);
            Controls.Add(guna2PictureBox1);
            Name = "telaLogin";
            Text = "telaLogin";
            WindowState = FormWindowState.Maximized;
            Load += telaLogin_Load;
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button botaoRegistro;
        private Guna.UI2.WinForms.Guna2Button botaoLogin;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}