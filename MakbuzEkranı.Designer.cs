namespace yurt_uygulaması
{
    partial class MakbuzEkranı
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
            label1 = new Label();
            panel1 = new Panel();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(484, 29);
            label1.Name = "label1";
            label1.Size = new Size(316, 44);
            label1.TabIndex = 0;
            label1.Text = "Ödeme Makbuzu";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(46, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(1212, 5);
            panel1.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader6, columnHeader5, columnHeader7 });
            listView1.Location = new Point(46, 135);
            listView1.Name = "listView1";
            listView1.Size = new Size(1212, 497);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "id";
            columnHeader1.Width = 62;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Taksit No";
            columnHeader2.Width = 185;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Kalan Borç";
            columnHeader3.Width = 192;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ödenen Miktar";
            columnHeader4.Width = 192;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Ödeme Tarihi";
            columnHeader6.Width = 192;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Toplam Taksit";
            columnHeader5.Width = 192;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Kalan Taksit";
            columnHeader7.Width = 192;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.125F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(895, 655);
            label2.Name = "label2";
            label2.Size = new Size(363, 31);
            label2.TabIndex = 3;
            label2.Text = "Ödemeleriniz için teşekkürler";
            // 
            // MakbuzEkranı
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 722);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "MakbuzEkranı";
            Text = "Makbuz";
            Load += MakbuzEkranı_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader7;
        private Label label2;
    }
}