using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace _1.Application_Console_metier
{
    public class conteneurMenuType
    {
        private ArrayList lesMenuType;


        public conteneurMenuType()
        {
            this.lesMenuType = new ArrayList();
        }

        public conteneurMenuType(string[,] unTableau)
        {
            this.lesMenuType = new ArrayList();
            for (int i = 0; i < unTableau.GetLength(0); i++)
            {
                ajouteUnMenuType(Convert.ToInt32(unTableau[i, 0]), Convert.ToInt32(unTableau[i, 1]), Convert.ToString(unTableau[i,2]), Convert.ToInt32(unTableau[i,3]));
            }
        }

        public int nbrTypeMenu()
        {
            return this.lesMenuType.Count;
        }

        public void ajouteUnMenuType(int leCodeMenuType, int laQuantiteRecommandeMenuType, String leLibelleAlimentComposeMenuType, int leCodeEspece)
        {
            menuType unMenuType;
            unMenuType = new menuType( leCodeMenuType, laQuantiteRecommandeMenuType, leLibelleAlimentComposeMenuType, leCodeEspece);
            this.lesMenuType.Add(unMenuType);
        }




    }
}