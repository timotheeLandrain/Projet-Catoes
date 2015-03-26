using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _1.Application_Console_metier
{
    public class conteneurEspece
    {
        private ArrayList lesEspeces;


        public conteneurEspece()
        {
            this.lesEspeces = new ArrayList();
        }

        public conteneurEspece(string[,] unTableau)
        {
            this.lesEspeces = new ArrayList();
            for (int i = 0; i < unTableau.GetLength(0); i++)
            {
                ajouteUneEspece(Convert.ToInt32(unTableau[i, 0]), Convert.ToString(unTableau[i, 1]));
            }
        }

        public int nbrEspece()
        {
            return this.lesEspeces.Count;
        }

        public void ajouteUneEspece(int leCodeEspece, String leLibelleEspece)
        {
            espece uneEspece;
            uneEspece = new espece(leCodeEspece, leLibelleEspece);
            this.lesEspeces.Add(uneEspece);
        }



     

        public ArrayList getLesEspece()
        {
            return this.lesEspeces;
        }
        public ArrayList afficherLesEspeces()
        {
            return this.lesEspeces;
        }
    }
}
