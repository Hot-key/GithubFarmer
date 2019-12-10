namespace GithubFarmer
{
    partial class FmSetting
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
            this.panelFarm = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelFarm
            // 
            this.panelFarm.Location = new System.Drawing.Point(12, 12);
            this.panelFarm.Name = "panelFarm";
            this.panelFarm.Size = new System.Drawing.Size(722, 88);
            this.panelFarm.TabIndex = 1;
            // 
            // FmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.panelFarm);
            this.Name = "FmSetting";
            this.Text = "FmSetting";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFarm;
    }
}