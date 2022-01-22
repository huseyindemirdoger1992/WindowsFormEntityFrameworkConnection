namespace WindowsFormEntityFrameworkConnection
{
    partial class Form1
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
            this.dataGridViewPersonel = new System.Windows.Forms.DataGridView();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPersonel
            // 
            this.dataGridViewPersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPersonel.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonel.Location = new System.Drawing.Point(12, 66);
            this.dataGridViewPersonel.Name = "dataGridViewPersonel";
            this.dataGridViewPersonel.RowTemplate.Height = 24;
            this.dataGridViewPersonel.Size = new System.Drawing.Size(776, 250);
            this.dataGridViewPersonel.TabIndex = 0;
            this.dataGridViewPersonel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPersonel_CellContentClick);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(12, 29);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(354, 22);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(372, 29);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(191, 22);
            this.txtSoyad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kayıt Et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(713, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(569, 29);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(138, 22);
            this.txtTelefon.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(566, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefon";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 353);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.dataGridViewPersonel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPersonel;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label3;
    }
}

