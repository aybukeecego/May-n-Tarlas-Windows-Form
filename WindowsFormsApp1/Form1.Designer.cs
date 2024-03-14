namespace WindowsFormsApp1
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
			this.buttonForm1 = new System.Windows.Forms.Button();
			this.textBoxForm1 = new System.Windows.Forms.TextBox();
			this.labelForm1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonForm1
			// 
			this.buttonForm1.Location = new System.Drawing.Point(76, 146);
			this.buttonForm1.Name = "buttonForm1";
			this.buttonForm1.Size = new System.Drawing.Size(188, 49);
			this.buttonForm1.TabIndex = 0;
			this.buttonForm1.Text = "MerhabaForm";
			this.buttonForm1.UseVisualStyleBackColor = true;
			this.buttonForm1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBoxForm1
			// 
			this.textBoxForm1.Location = new System.Drawing.Point(76, 109);
			this.textBoxForm1.Name = "textBoxForm1";
			this.textBoxForm1.Size = new System.Drawing.Size(188, 22);
			this.textBoxForm1.TabIndex = 1;
			this.textBoxForm1.Text = "Metni Giriniz";
			this.textBoxForm1.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// labelForm1
			// 
			this.labelForm1.AutoSize = true;
			this.labelForm1.Location = new System.Drawing.Point(80, 53);
			this.labelForm1.Name = "labelForm1";
			this.labelForm1.Size = new System.Drawing.Size(175, 32);
			this.labelForm1.TabIndex = 2;
			this.labelForm1.Text = "MerhabaForm için yazılacak\r\n yazıyı giriniz.";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(370, 248);
			this.Controls.Add(this.labelForm1);
			this.Controls.Add(this.textBoxForm1);
			this.Controls.Add(this.buttonForm1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonForm1;
		private System.Windows.Forms.TextBox textBoxForm1;
		private System.Windows.Forms.Label labelForm1;
	}
}

