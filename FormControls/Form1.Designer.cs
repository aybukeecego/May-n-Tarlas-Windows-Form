namespace FormControls
{
    partial class frmKayıt
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnÖnizleme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(61, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(36, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "İsim";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(133, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 27);
            this.txtName.TabIndex = 0;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(61, 92);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(60, 20);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Soyisim";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(133, 89);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(182, 27);
            this.txtSurname.TabIndex = 1;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(61, 165);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(62, 20);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Numara";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(133, 162);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(182, 27);
            this.txtNumber.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(61, 131);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(133, 128);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(182, 27);
            this.txtEmail.TabIndex = 2;
            // 
            // btnÖnizleme
            // 
            this.btnÖnizleme.Location = new System.Drawing.Point(117, 204);
            this.btnÖnizleme.Name = "btnÖnizleme";
            this.btnÖnizleme.Size = new System.Drawing.Size(135, 42);
            this.btnÖnizleme.TabIndex = 4;
            this.btnÖnizleme.Text = "Kaydet ve Önizle";
            this.btnÖnizleme.UseVisualStyleBackColor = true;
            this.btnÖnizleme.Click += new System.EventHandler(this.btnÖnizleme_Click);
            // 
            // frmKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 287);
            this.Controls.Add(this.btnÖnizleme);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Label lblSurname;
        private TextBox txtSurname;
        private Label lblNumber;
        private TextBox txtNumber;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnÖnizleme;
    }
}