namespace yurt_uygulaması
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnGiris = new Button();
            txtKullanici = new TextBox();
            txtSifre = new TextBox();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGiris
            // 
            btnGiris.BackColor = SystemColors.Control;
            btnGiris.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnGiris.Location = new Point(227, 244);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(150, 46);
            btnGiris.TabIndex = 0;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // txtKullanici
            // 
            txtKullanici.Location = new Point(208, 103);
            txtKullanici.Name = "txtKullanici";
            txtKullanici.PlaceholderText = "Kullanıcı Adı";
            txtKullanici.RightToLeft = RightToLeft.No;
            txtKullanici.Size = new Size(200, 39);
            txtKullanici.TabIndex = 1;
            txtKullanici.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(208, 172);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.PlaceholderText = "Şifre";
            txtSifre.Size = new Size(200, 39);
            txtSifre.TabIndex = 2;
            txtSifre.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaShell;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtSifre);
            panel1.Controls.Add(txtKullanici);
            panel1.Controls.Add(btnGiris);
            panel1.Location = new Point(92, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(630, 332);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Location = new Point(449, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(154, 5);
            panel3.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Location = new Point(33, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(154, 5);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaShell;
            label1.Font = new Font("Arial", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(193, 44);
            label1.Name = "label1";
            label1.Size = new Size(250, 32);
            label1.TabIndex = 3;
            label1.Text = "Yurt Kayıt Sistemi";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Yurt Kayıt";
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // Form1
            // 
            AcceptButton = btnGiris;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Resize += Form1_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGiris;
        private TextBox txtKullanici;
        private TextBox txtSifre;
        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Panel panel2;
        private NotifyIcon notifyIcon1;
    }
}