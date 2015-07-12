using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Color MyColor = Color.FromArgb(0x00, 0xFF, 0x00);
            MyColor = Color.FromName("Green");
            MyColor = Color.Green;
        }
    }
}
