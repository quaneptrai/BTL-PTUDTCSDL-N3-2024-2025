using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class ThongTinGiaoVien : Form
    {
        string tdn;
        public ThongTinGiaoVien(string username)
        {
            InitializeComponent();
            TXTGiaoVien.Text = username;
            tdn = username;
        }

        private void ThongTinGiaoVien_Load(object sender, EventArgs e)
        {

        }
    }
}
