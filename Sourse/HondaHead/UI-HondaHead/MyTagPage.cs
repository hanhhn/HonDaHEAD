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
    public class MyFormPage : Form
    {
        public Panel pnl;
    }
    public partial class MyTagPage : MyFormPage
    {
        private Form frm;
        public MyTagPage(MyFormPage frm_contensido)
        {
            this.frm = frm_contensido;
            this.Controls.Add(frm_contensido.pnl);
            this.Text = frm_contensido.Text;
        }
    }
}
