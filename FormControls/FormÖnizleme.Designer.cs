namespace FormControls
{
    partial class FormÖnizleme
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
            this.txtEmailÖnzl = new System.Windows.Forms.TextBox();
            this.txtNumberÖnzl = new System.Windows.Forms.TextBox();
            this.txtSurnameÖnzl = new System.Windows.Forms.TextBox();
            this.txtNameÖnzl = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmailÖnzl
            // 
            this.txtEmailÖnzl.Enabled = false;
            this.txtEmailÖnzl.Location = new System.Drawing.Point(146, 159);
            this.txtEmailÖnzl.Name = "txtEmailÖnzl";
            this.txtEmailÖnzl.Size = new System.Drawing.Size(182, 27);
            this.txtEmailÖnzl.TabIndex = 6;
            // 
            // txtNumberÖnzl
            // 
            this.txtNumberÖnzl.Enabled = false;
            this.txtNumberÖnzl.Location = new System.Drawing.Point(146, 193);
            this.txtNumberÖnzl.Name = "txtNumberÖnzl";
            this.txtNumberÖnzl.Size = new System.Drawing.Size(182, 27);
            this.txtNumberÖnzl.TabIndex = 7;
            // 
            // txtSurnameÖnzl
            // 
            this.txtSurnameÖnzl.Enabled = false;
            this.txtSurnameÖnzl.Location = new System.Drawing.Point(146, 120);
            this.txtSurnameÖnzl.Name = "txtSurnameÖnzl";
            this.txtSurnameÖnzl.Size = new System.Drawing.Size(182, 27);
            this.txtSurnameÖnzl.TabIndex = 8;
            // 
            // txtNameÖnzl
            // 
            this.txtNameÖnzl.Enabled = false;
            this.txtNameÖnzl.Location = new System.Drawing.Point(146, 83);
            this.txtNameÖnzl.Name = "txtNameÖnzl";
            this.txtNameÖnzl.Size = new System.Drawing.Size(182, 27);
            this.txtNameÖnzl.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(74, 162);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(74, 196);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(62, 20);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "Numara";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(74, 123);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(60, 20);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Soyisim";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(74, 86);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(36, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "İsim";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(234, 238);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 29);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FormÖnizleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 290);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtEmailÖnzl);
            this.Controls.Add(this.txtNumberÖnzl);
            this.Controls.Add(this.txtSurnameÖnzl);
            this.Controls.Add(this.txtNameÖnzl);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormÖnizleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormÖnizleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtEmailÖnzl;
        private TextBox txtNumberÖnzl;
        private TextBox txtSurnameÖnzl;
        private TextBox txtNameÖnzl;
        private Label lblEmail;
        private Label lblNumber;
        private Label lblSurname;
        private Label lblName;
        private Button btnOk;
    }
}