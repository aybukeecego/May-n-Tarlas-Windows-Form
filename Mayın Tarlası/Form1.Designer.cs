namespace Mayın_Tarlası
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUret = new System.Windows.Forms.Button();
            this.lblMayınGösterge = new System.Windows.Forms.Label();
            this.lblMayın = new System.Windows.Forms.Label();
            this.lblSkorGösterge = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(546, 447);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // btnUret
            // 
            this.btnUret.Location = new System.Drawing.Point(587, 12);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(201, 336);
            this.btnUret.TabIndex = 1;
            this.btnUret.Text = "Üret";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // lblMayınGösterge
            // 
            this.lblMayınGösterge.AutoSize = true;
            this.lblMayınGösterge.Location = new System.Drawing.Point(651, 395);
            this.lblMayınGösterge.Name = "lblMayınGösterge";
            this.lblMayınGösterge.Size = new System.Drawing.Size(0, 16);
            this.lblMayınGösterge.TabIndex = 2;
            // 
            // lblMayın
            // 
            this.lblMayın.AutoSize = true;
            this.lblMayın.Location = new System.Drawing.Point(584, 395);
            this.lblMayın.Name = "lblMayın";
            this.lblMayın.Size = new System.Drawing.Size(49, 16);
            this.lblMayın.TabIndex = 3;
            this.lblMayın.Text = "Mayın :";
            // 
            // lblSkorGösterge
            // 
            this.lblSkorGösterge.AutoSize = true;
            this.lblSkorGösterge.Location = new System.Drawing.Point(651, 367);
            this.lblSkorGösterge.Name = "lblSkorGösterge";
            this.lblSkorGösterge.Size = new System.Drawing.Size(0, 16);
            this.lblSkorGösterge.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Skor :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSkorGösterge);
            this.Controls.Add(this.lblMayın);
            this.Controls.Add(this.lblMayınGösterge);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.btnUret);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.Label lblMayınGösterge;
        private System.Windows.Forms.Label lblMayın;
        private System.Windows.Forms.Label lblSkorGösterge;
        private System.Windows.Forms.Label label2;
    }
}

