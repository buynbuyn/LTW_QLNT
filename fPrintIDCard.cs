using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT
{
    public partial class fPrintIDCard : Form
    {
        public fPrintIDCard(string name, string position, string hiredate, Image avatar = null, bool embed = false)
        {
            InitializeComponent();

            lblName.Text = name;
            lblPosition.Text = "CHỨC VỤ: " + position;
            lblID.Text = "NGÀY LÀM VIỆC: " + hiredate;
            if (embed)
            {
                this.TopLevel = false;
                this.FormBorderStyle = FormBorderStyle.None;
                this.Dock = DockStyle.Fill;
            }

        }
    }
}
