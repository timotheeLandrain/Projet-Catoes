using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _1.Application_Console_metier;

using catoesDistributionMenu;
using System.Collections;

namespace WindowsFormsApplication1
{
    class gestionDistributionRepas
    {
        accesBD maBD;
        conteneurAnimal tousLesAnimaux;
        conteneurEspece toutesLesEspeces;
        conteneurMenuType tousLesMenusTypes;
        conteneurAnimalRecevoirMenu tousLesMenusDistribues;

        public gestionDistributionRepas()
        {
            conteneurAnimal lesAnimaux=new conteneurAnimal();
            conteneurEspece lesEspeces= new conteneurEspece();
            conteneurMenuType lesMenuTypes= new conteneurMenuType();
            conteneurAnimalRecevoirMenu lesMenusDistribues = new conteneurAnimalRecevoirMenu();
           
        }
        
        public void ajouteUneEspece(String[] leMess)
        {                  
                int code = 1;
                toutesLesEspeces.ajouteUneEspece(code, leMess[0]);
               
        }
            
            
        public ArrayList afficherLesEspeces()
        {
            return this.toutesLesEspeces.getLesEspece();
        }
        }
    }

