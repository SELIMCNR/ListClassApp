namespace WindowsListSoure
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnlist1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnlist2 = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btnlist3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(175, 290);
            this.listBox1.TabIndex = 0;
            // 
            // btnlist1
            // 
            this.btnlist1.Location = new System.Drawing.Point(13, 313);
            this.btnlist1.Name = "btnlist1";
            this.btnlist1.Size = new System.Drawing.Size(175, 30);
            this.btnlist1.TabIndex = 1;
            this.btnlist1.Text = "Listele 1";
            this.btnlist1.UseVisualStyleBackColor = true;
            this.btnlist1.Click += new System.EventHandler(this.btnlist1_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(229, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(176, 290);
            this.listBox2.TabIndex = 0;
            // 
            // btnlist2
            // 
            this.btnlist2.Location = new System.Drawing.Point(229, 312);
            this.btnlist2.Name = "btnlist2";
            this.btnlist2.Size = new System.Drawing.Size(176, 30);
            this.btnlist2.TabIndex = 1;
            this.btnlist2.Text = "Listele 2";
            this.btnlist2.UseVisualStyleBackColor = true;
            this.btnlist2.Click += new System.EventHandler(this.btnlist2_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(439, 12);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(166, 290);
            this.listBox3.TabIndex = 0;
            // 
            // btnlist3
            // 
            this.btnlist3.Location = new System.Drawing.Point(439, 312);
            this.btnlist3.Name = "btnlist3";
            this.btnlist3.Size = new System.Drawing.Size(166, 30);
            this.btnlist3.TabIndex = 1;
            this.btnlist3.Text = "Listele 3";
            this.btnlist3.UseVisualStyleBackColor = true;
            this.btnlist3.Click += new System.EventHandler(this.btnlist3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 355);
            this.Controls.Add(this.btnlist3);
            this.Controls.Add(this.btnlist2);
            this.Controls.Add(this.btnlist1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnlist1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnlist2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btnlist3;
    }
}

