using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _1.Application_Console_metier
{
    class conteneurAnimalRecevoirMenu
    {private ArrayList lesAnimauxRecevoirMenu;


        public conteneurAnimalRecevoirMenu()
        {
            this.lesAnimauxRecevoirMenu = new ArrayList();
        }

        public conteneurAnimalRecevoirMenu(string[,] unTableau)
        {
            this.lesAnimauxRecevoirMenu = new ArrayList();
            for (int i = 0; i < unTableau.GetLength(0); i++)
            {
               ajouteUneDistributionDeRepas(Convert.ToInt32(unTableau[i, 0]), Convert.ToInt32(unTableau[i, 1]),Convert.ToString(unTableau[i, 2]),Convert.ToDateTime(unTableau[i, 3]),Convert.ToInt32(unTableau[i, 4]));
            }
        }

        public int nbrRepasDistribue()
        {
            return this.lesAnimauxRecevoirMenu.Count;
        }

        public void ajouteUneDistributionDeRepas(int leCodeMenu, int leCodeEspece, String leNomBapteme, DateTime laDateHeureManger, int laQuantiteAbsorbe)
        {
             animalRecevoirMenu uneDistributionDeRepas;
            uneDistributionDeRepas = new  animalRecevoirMenu(leCodeMenu, leCodeEspece, leNomBapteme, laDateHeureManger, laQuantiteAbsorbe);
            this.lesAnimauxRecevoirMenu.Add(uneDistributionDeRepas);
        }




    }
}

