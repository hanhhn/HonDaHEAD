using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_HondaHead
{
    public partial class frmBaoCaoTon : MyFormPage
    {
        public frmBaoCaoTon()
        {
            InitializeComponent();
            this.pnl = panel1;
        }

        private void frmBaoCaoTon_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
