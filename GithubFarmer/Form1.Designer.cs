namespace GithubFarmer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelFarm = new System.Windows.Forms.Panel();
            this.textBoxGitName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoadGit = new System.Windows.Forms.Button();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // panelFarm
            // 
            this.panelFarm.Location = new System.Drawing.Point(10, 39);
            this.panelFarm.Name = "panelFarm";
            this.panelFarm.Size = new System.Drawing.Size(722, 88);
            this.panelFarm.TabIndex = 0;
            // 
            // textBoxGitName
            // 
            this.textBoxGitName.Location = new System.Drawing.Point(99, 12);
            this.textBoxGitName.Name = "textBoxGitName";
            this.textBoxGitName.Size = new System.Drawing.Size(139, 21);
            this.textBoxGitName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "깃허브 닉네임";
            // 
            // buttonLoadGit
            // 
            this.buttonLoadGit.Location = new System.Drawing.Point(657, 11);
            this.buttonLoadGit.Name = "buttonLoadGit";
            this.buttonLoadGit.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadGit.TabIndex = 3;
            this.buttonLoadGit.Text = "로드";
            this.buttonLoadGit.UseVisualStyleBackColor = true;
            this.buttonLoadGit.Click += new System.EventHandler(this.buttonLoadGit_Click);
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.ItemHeight = 12;
            this.listBoxLog.Location = new System.Drawing.Point(10, 133);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(532, 136);
            this.listBoxLog.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 274);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.buttonLoadGit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGitName);
            this.Controls.Add(this.panelFarm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFarm;
        private System.Windows.Forms.TextBox textBoxGitName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoadGit;
        private System.Windows.Forms.ListBox listBoxLog;
    }
}

