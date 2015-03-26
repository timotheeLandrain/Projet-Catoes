using _1.Application_Console_metier;
using System;
using System.Collections;
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
        private controleur leControleur = new controleur();
        public frmEspeceAfficher()
        {
            InitializeComponent();
        }

        private void comboBoxEspece_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmEspeceAfficher_Load(object sender, EventArgs e)
        {
            ArrayList LaListeEspece = leControleur.afficheListeEspece();
            for (int i = 0; i < LaListeEspece.Count; i++)
            {
                espece uneEspece = (espece)LaListeEspece[i];
                this.comboBoxEspece.Items.Add(uneEspece.getLibelleEspece());
            }
        }
    }
}
