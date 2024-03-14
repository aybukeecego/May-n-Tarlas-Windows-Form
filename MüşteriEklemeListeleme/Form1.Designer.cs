namespace MüşteriEklemeListeleme
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
            this.components = new System.ComponentModel.Container();
            this.gboxEkle = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.txtBoxSoyisim = new System.Windows.Forms.TextBox();
            this.txtBoxİsim = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSoyisim = new System.Windows.Forms.Label();
            this.lblİsim = new System.Windows.Forms.Label();
            this.gboxListe = new System.Windows.Forms.GroupBox();
            this.bildirimcbg = new System.Windows.Forms.NotifyIcon(this.components);
            this.dgwLst = new System.Windows.Forms.DataGridView();
            this.gboxEkle.SuspendLayout();
            this.gboxListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLst)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxEkle
            // 
            this.gboxEkle.Controls.Add(this.btnEkle);
            this.gboxEkle.Controls.Add(this.txtBoxMail);
            this.gboxEkle.Controls.Add(this.txtBoxSoyisim);
            this.gboxEkle.Controls.Add(this.txtBoxİsim);
            this.gboxEkle.Controls.Add(this.lblEmail);
            this.gboxEkle.Controls.Add(this.lblSoyisim);
            this.gboxEkle.Controls.Add(this.lblİsim);
            this.gboxEkle.Location = new System.Drawing.Point(0, 0);
            this.gboxEkle.Name = "gboxEkle";
            this.gboxEkle.Size = new System.Drawing.Size(309, 346);
            this.gboxEkle.TabIndex = 0;
            this.gboxEkle.TabStop = false;
            this.gboxEkle.Text = "Müşteri Ekle";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(135, 199);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(94, 29);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Location = new System.Drawing.Point(86, 143);
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.Size = new System.Drawing.Size(217, 27);
            this.txtBoxMail.TabIndex = 1;
            // 
            // txtBoxSoyisim
            // 
            this.txtBoxSoyisim.Location = new System.Drawing.Point(86, 104);
            this.txtBoxSoyisim.Name = "txtBoxSoyisim";
            this.txtBoxSoyisim.Size = new System.Drawing.Size(217, 27);
            this.txtBoxSoyisim.TabIndex = 1;
            // 
            // txtBoxİsim
            // 
            this.txtBoxİsim.Location = new System.Drawing.Point(86, 71);
            this.txtBoxİsim.Name = "txtBoxİsim";
            this.txtBoxİsim.Size = new System.Drawing.Size(217, 27);
            this.txtBoxİsim.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 146);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.Location = new System.Drawing.Point(12, 107);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(60, 20);
            this.lblSoyisim.TabIndex = 0;
            this.lblSoyisim.Text = "Soyisim";
            // 
            // lblİsim
            // 
            this.lblİsim.AutoSize = true;
            this.lblİsim.Location = new System.Drawing.Point(12, 74);
            this.lblİsim.Name = "lblİsim";
            this.lblİsim.Size = new System.Drawing.Size(36, 20);
            this.lblİsim.TabIndex = 0;
            this.lblİsim.Text = "İsim";
            // 
            // gboxListe
            // 
            this.gboxListe.Controls.Add(this.dgwLst);
            this.gboxListe.Location = new System.Drawing.Point(315, 0);
            this.gboxListe.Name = "gboxListe";
            this.gboxListe.Size = new System.Drawing.Size(482, 346);
            this.gboxListe.TabIndex = 1;
            this.gboxListe.TabStop = false;
            this.gboxListe.Text = "Müşteri Listesi";
            // 
            // bildirimcbg
            // 
            this.bildirimcbg.Text = "bildirimcbg";
            this.bildirimcbg.Visible = true;
            // 
            // dgwLst
            // 
            this.dgwLst.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLst.Location = new System.Drawing.Point(15, 41);
            this.dgwLst.Name = "dgwLst";
            this.dgwLst.RowHeadersWidth = 51;
            this.dgwLst.RowTemplate.Height = 29;
            this.dgwLst.Size = new System.Drawing.Size(410, 270);
            this.dgwLst.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 369);
            this.Controls.Add(this.gboxListe);
            this.Controls.Add(this.gboxEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gboxEkle.ResumeLayout(false);
            this.gboxEkle.PerformLayout();
            this.gboxListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwLst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gboxEkle;
        private Button btnEkle;
        private TextBox txtBoxMail;
        private TextBox txtBoxSoyisim;
        private TextBox txtBoxİsim;
        private Label lblEmail;
        private Label lblSoyisim;
        private Label lblİsim;
        private GroupBox gboxListe;
        private NotifyIcon bildirimcbg;
        private DataGridView dgwLst;
    }
}