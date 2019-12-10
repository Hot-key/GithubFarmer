using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace GithubFarmer
{
    public partial class FmMain : Form
    {
        HtmlWeb gitPageWeb = new HtmlWeb();

        public FmMain()
        {
            InitializeComponent();
        }

        private void buttonLoadGit_Click(object sender, EventArgs e)
        {
            if (textBoxGitName.Text.Length > 1)
            {
                panelFarm.Controls.Clear();

                WriteLog("Connect", $"Start load page https://github.com/users/{textBoxGitName.Text}/contributions");
                var gitPageHtml = gitPageWeb.Load($"https://github.com/users/{textBoxGitName.Text}/contributions");
                WriteLog("Connect", $"End load page https://github.com/users/{textBoxGitName.Text}/contributions");

                var farm = gitPageHtml.DocumentNode.SelectSingleNode("/div/div[1]/div/div[1]/svg/g");
                var yearFarm = farm.SelectNodes("g");
                for (int i = 0; i < yearFarm.Count; i++)
                {
                    var weekFarm = yearFarm[i].SelectNodes("rect");
                    for (int j = 0; j < weekFarm.Count; j++)
                    {
                        var tmpPanel = new Panel();
                       
                        tmpPanel.BackColor = ColorTranslator.FromHtml(weekFarm[j].Attributes["fill"].Value);
                        tmpPanel.Location = new Point(13 * i, 13 * j);
                        tmpPanel.Size = new Size(10, 10);

                        var countLable = new Label();

                        countLable.BackColor = tmpPanel.BackColor;
                        countLable.Text = weekFarm[j].Attributes["data-count"].Value;
                        countLable.Font = new Font("굴림", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                        tmpPanel.Controls.Add(countLable);

                        panelFarm.Controls.Add(tmpPanel);

                        WriteLog("Panel", $"Add Panel at{13*i},{13 * j}[{weekFarm[j].Attributes["fill"].Value}]");
                    }
                }
            }
            else
            {
                MessageBox.Show("닉네임 입력이 필요합니다.", "오류!");
            }
        }

        private void WriteLog(string type, string text)
        {
            listBoxLog.Items.Add($"{$" [{type}] ".PadRight(15)} {text}");

            listBoxLog.SelectedIndex = listBoxLog.Items.Count - 1;
            listBoxLog.SelectedIndex = -1;
        }
    }
}
