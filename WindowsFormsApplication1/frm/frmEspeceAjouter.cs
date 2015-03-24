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
    public partial class frmEspeceAjouter : Form
    {
        controleur leControleur = new controleur();
        public frmEspeceAjouter()
        {
            InitializeComponent();
        }

        private void btnValiderAjoutEspece_Click(object sender, EventArgs e)
        {
            
                string[] mess = new String[1];

                mess[0] = libelleEspece.Text;
                
                leControleur.afficheEcran(mess, "validationAjoutEspece");
                Close();

            

        }

        private void libelleEspece_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmEspeceAjouter_Load(object sender, EventArgs e)
        {

        }

       
    }
}
