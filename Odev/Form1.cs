using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.label1.ForeColor = System.Drawing.Color.Green;

            Label lbl_isim = new Label();
            lbl_isim.AutoSize = true;
            lbl_isim.Text = "İsim:";
            lbl_isim.Location = new Point(250, 30);
            this.Controls.Add(lbl_isim);

            Label lbl_soyisim = new Label();
            lbl_soyisim.Text = "Soyisim:";
            lbl_soyisim.Location = new Point(250, 57);
            this.Controls.Add(lbl_soyisim);

            TextBox tb_isim = new TextBox();
            tb_isim.Location = new Point(300, 30);
            this.Controls.Add(tb_isim);
        }

       
    }
}
