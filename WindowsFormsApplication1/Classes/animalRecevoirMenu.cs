using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Application_Console_metier
{
    class animalRecevoirMenu
    {
        private int codeMenu;
        private int codeEspece;
        private String nomBapteme;
        private DateTime dateHeureManger;
        private int quantiteAbsorbe;

        public animalRecevoirMenu()
        {
        }
        public animalRecevoirMenu(int leCodeMenu, int leCodeEspece, String leNomBapteme, DateTime laDateHeureManger, int laQuantiteAbsorbe)
        {
            this.codeMenu = leCodeMenu;
            this.codeEspece = leCodeEspece;
            this.dateHeureManger = laDateHeureManger;
            this.nomBapteme = leNomBapteme;
            this.quantiteAbsorbe = laQuantiteAbsorbe;
        }

        public int getCodeMenu()
        {
            return this.codeMenu;
        }
        public int getEspece()
        {
            return this.codeEspece;
        }

        public String getNomBapteme()
        {
            return this.nomBapteme;
        }

        public DateTime getDateHeureManger()
        {
            return this.dateHeureManger;
        }

        public int getQuantiteAbsorbe()
        {
            return this.quantiteAbsorbe;
        }

        public void setCodeMenu(int leCodeMenu)
        {
            this.codeMenu = leCodeMenu;
        }

        public void setCodeEspece(int leCodeEspece)
        {
            this.codeEspece = leCodeEspece;
        }

        public void setNomBapteme(String leNomBapteme)
        {
            this.nomBapteme = leNomBapteme;
        }

        public void setDateHeureManger(DateTime laDateHeureManger)
        {
            this.dateHeureManger = laDateHeureManger;
        }

        public void setQuantiteAbsorbe(int laQuantiteAbsorbe)
        {
            this.quantiteAbsorbe = laQuantiteAbsorbe;
        }
    
    }
}
