using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GithubFarmer
{
    public partial class FmSetting : Form
    {
        private FmMain formMain;
        public FmSetting(FmMain formMain)
        {
            InitializeComponent();

            this.formMain = formMain;
        }
    }
}
