using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pantallas_con_diseño_moderno
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            eventButton();
        }

        public void eventButton()
        {
            btn2.MouseEnter += new EventHandler(btn2MouseEnter);
            btn2.MouseLeave += new EventHandler(btn2MouseLeave);
            btn3.MouseEnter += new EventHandler(btn3MouseEnter);
            btn3.MouseLeave += new EventHandler(btn3MouseLeave);
            btn4.MouseEnter += new EventHandler(btn4MouseEnter);
            btn4.MouseLeave += new EventHandler(btn4MouseLeave);
            btn6.MouseEnter += new EventHandler(btn6MouseEnter);
            btn6.MouseLeave += new EventHandler(btn6MouseLeave);
            btn5.MouseEnter += new EventHandler(btn5MouseEnter);
            btn5.MouseLeave += new EventHandler(btn5MouseLeave);
        }

        public void btn2MouseEnter(object sender, EventArgs e)
        {
            btn2.ForeColor = Color.Indigo;
            btn2.FillColor = Color.White;
        }

        public void btn2MouseLeave(object sender, EventArgs e)
        {
            btn2.ForeColor = Color.White;
            btn2.FillColor = Color.Indigo;
        }

        public void btn3MouseEnter(object sender, EventArgs e)
        {
            btn3.ForeColor = Color.Indigo;
            btn3.FillColor = Color.White;
        }

        public void btn3MouseLeave(object sender, EventArgs e)
        {
            btn3.ForeColor = Color.White;
            btn3.FillColor = Color.Indigo;
        }

        public void btn4MouseEnter(object sender, EventArgs e)
        {
            btn4.ForeColor = Color.Indigo;
            btn4.FillColor = Color.White;
        }

        public void btn4MouseLeave(object sender, EventArgs e)
        {
            btn4.ForeColor = Color.White;
            btn4.FillColor = Color.Indigo;
        }

        public void btn5MouseEnter(object sender, EventArgs e)
        {
            btn5.ForeColor = Color.Indigo;
            btn5.FillColor = Color.White;
        }

        public void btn5MouseLeave(object sender, EventArgs e)
        {
            btn5.ForeColor = Color.White;
            btn5.FillColor = Color.Indigo;
        }

        public void btn6MouseEnter(object sender, EventArgs e)
        {
            btn6.ForeColor = Color.Indigo;
            btn6.FillColor = Color.White;
        }

        public void btn6MouseLeave(object sender, EventArgs e)
        {
            btn6.ForeColor = Color.White;
            btn6.FillColor = Color.Indigo;
        }
    }
}
