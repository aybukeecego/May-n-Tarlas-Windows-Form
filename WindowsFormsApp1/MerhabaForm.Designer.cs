namespace WindowsFormsApp1
{
	partial class MerhabaForm
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
			this.labelMForm1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelMForm1
			// 
			this.labelMForm1.AutoSize = true;
			this.labelMForm1.Location = new System.Drawing.Point(98, 54);
			this.labelMForm1.Name = "labelMForm1";
			this.labelMForm1.Size = new System.Drawing.Size(44, 16);
			this.labelMForm1.TabIndex = 0;
			this.labelMForm1.Text = "label1";
			this.labelMForm1.Click += new System.EventHandler(this.label1_Click);


		}

		#endregion

		private System.Windows.Forms.Label labelMForm1;
	}
}