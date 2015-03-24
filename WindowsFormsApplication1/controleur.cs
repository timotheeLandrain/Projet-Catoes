using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.frm;

namespace WindowsFormsApplication1
{
    class controleur
    {
        private gestionDistributionRepas laGestion = new gestionDistributionRepas();
        public void afficheEcran(String[] mess, String vue)
        {
            switch (vue)
            {
                case "ValidationAjoutEspece":
                    laGestion.ajouteUneEspece(mess);
                    break;
                case"ajouterEspece" :
                    frmEspeceAjouter lEcranEspeceAjouter = new frmEspeceAjouter();
                    lEcranEspeceAjouter.Show();
                    break;

                case"afficherEspece" :
                    frmEspeceAfficher lEcranEspeceAfficher = new frmEspeceAfficher();
                    lEcranEspeceAfficher.Show();
                    break;
                case "afficherListe":
                    laGestion.afficherLesEspeces();
                    break;
            }
        }
    }
}
