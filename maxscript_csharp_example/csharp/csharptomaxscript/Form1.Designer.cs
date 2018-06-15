namespace MaxScriptIntegrationDemo
{
	partial class MaxScriptIntegrationDemoControl
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
			this.btnCreateSphere = new System.Windows.Forms.Button();
			this.btnCreateLight = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCreateSphere
			// 
			this.btnCreateSphere.Location = new System.Drawing.Point(91, 61);
			this.btnCreateSphere.Name = "btnCreateSphere";
			this.btnCreateSphere.Size = new System.Drawing.Size(87, 23);
			this.btnCreateSphere.TabIndex = 0;
			this.btnCreateSphere.Text = "CreateSphere";
			this.btnCreateSphere.UseVisualStyleBackColor = true;
			this.btnCreateSphere.Click += _makeCircleButton_Click;
			// 
			// btnCreateLight
			// 
			this.btnCreateLight.Location = new System.Drawing.Point(91, 106);
			this.btnCreateLight.Name = "btnCreateLight";
			this.btnCreateLight.Size = new System.Drawing.Size(87, 23);
			this.btnCreateLight.TabIndex = 1;
			this.btnCreateLight.Text = "CreateLight";
			this.btnCreateLight.UseVisualStyleBackColor = true;
			this.btnCreateLight.Click += _makeOmniLightButton_Click;
			// 
			// MaxScriptIntegrationDemoControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnCreateLight);
			this.Controls.Add(this.btnCreateSphere);
			this.Name = "MaxScriptIntegrationDemoControl";
			this.Size = new System.Drawing.Size(800, 450);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCreateSphere;
		private System.Windows.Forms.Button btnCreateLight;
	}
}

