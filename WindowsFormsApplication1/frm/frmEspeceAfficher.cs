using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.frm
{
    public partial class frmEspeceAfficher : Form
    {
        public frmEspeceAfficher()
        {
            InitializeComponent();
        }

        private void comboBoxEspece_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmEspeceAfficher_Load(object sender, EventArgs e)
        {
            comboBoxEspece.Items.Add("blabla");
        }
    }
}
