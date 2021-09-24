namespace maxcare
{
	// Token: 0x020000F8 RID: 248
	public partial class frm_progress : global::System.Windows.Forms.Form
	{
		// Token: 0x06000A28 RID: 2600 RVA: 0x001CDE04 File Offset: 0x001CC004
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x001CDE64 File Offset: 0x001CC064
		private void InitializeComponent()
		{
			this.lblproccess = new global::System.Windows.Forms.Label();
			this.progressBar1 = new global::MetroFramework.Controls.MetroProgressBar();
			base.SuspendLayout();
			this.lblproccess.AutoSize = true;
			this.lblproccess.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblproccess.Location = new global::System.Drawing.Point(34, 22);
			this.lblproccess.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1MyTXlUa2xUYmxwYVRXczFjMWw2VGs1UVVUMDk="))))))));
			this.lblproccess.Size = new global::System.Drawing.Size(215, 16);
			this.lblproccess.TabIndex = 1;
			this.lblproccess.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1EyRkhTblJaTW1SclZEQmpNbUo2U25KYU1sWkpWMFZTTUZSWWJFTlpiVEZxWXpCc1NWZHFSbWhWTUVwNldXcG9OVkZYU25SWk1tUmFUVzF3U0dJeVRqVlJWV3hFV2pOa1MxVXlkREZVUjJzd1VGRTlQUT09"))))))));
			this.progressBar1.Location = new global::System.Drawing.Point(37, 52);
			this.progressBar1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCb1MyUnNiM3BUYlhocVRUQTFSRmRXYUVwbFFUMDk="))))))));
			this.progressBar1.Size = new global::System.Drawing.Size(219, 23);
			this.progressBar1.TabIndex = 2;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			base.ClientSize = new global::System.Drawing.Size(294, 104);
			base.Controls.Add(this.progressBar1);
			base.Controls.Add(this.lblproccess);
			this.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjIwMVMyUkdaM3BSYm14cFRXMVNOVmRzYUU5bFp6MDk="))))))));
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjIwMVMyUkdaM3BSYm14cFRXMVNOVmRzYUU5bFp6MDk="))))))));
			base.Load += new global::System.EventHandler(this.frm_progress_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000EAF RID: 3759
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000EB0 RID: 3760
		private global::System.Windows.Forms.Label lblproccess;

		// Token: 0x04000EB1 RID: 3761
		private global::MetroFramework.Controls.MetroProgressBar progressBar1;
	}
}
