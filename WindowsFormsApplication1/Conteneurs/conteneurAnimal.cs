using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace _1.Application_Console_metier
{
    public class conteneurAnimal
    {
        private ArrayList lesAnimaux;


        public conteneurAnimal()
        {
            this.lesAnimaux = new ArrayList();
        }

        public conteneurAnimal(string[,] unTableau)
        {
            this.lesAnimaux = new ArrayList();
            for (int i = 0; i < unTableau.GetLength(0); i++)
            {
                ajouteUnAnimal(Convert.ToInt32(unTableau[i, 0]), Convert.ToString(unTableau[i, 1]), Convert.ToString(unTableau[i,2]), Convert.ToInt32(unTableau[i,3]), Convert.ToInt32(unTableau[i,4]));
            }
        }

        public int nbrAnimal()
        {
            return this.lesAnimaux.Count;
        }

        public void ajouteUnAnimal(int leCodeEspece, String leNomBapteme, String leSexeAnimal, int laDateNaisAnimal, int laDateDecesAnimal)
        {
            animal unAnimal;
            unAnimal = new animal(leCodeEspece, leNomBapteme, leSexeAnimal, laDateNaisAnimal, laDateDecesAnimal);
            this.lesAnimaux.Add(unAnimal);
        }

         public void afficheDesAnimaux(int leCodeEspeceChoisi)
        {
            animal unAnimal;
            Console.WriteLine("Les Animaux de l'espèce choisi sont : ");
            for (int i = 0; i < lesAnimaux.Count; i++)
            {

                unAnimal = (animal)lesAnimaux[i];
                if (unAnimal.getCodeEspece() == leCodeEspeceChoisi)
                {

                    Console.WriteLine();
                    Console.WriteLine(unAnimal.getNomBapteme());

                }


            }
        }

         public Object rechercheUnAnimalFonctionDeSonCodeEtSonNomBapteme(int leCodeEspeceChoisi, String leNomBapteme)
         {
             animal lAnimalTrouve = new animal();
             animal unAnimal;

             for (int i = 0; i < lesAnimaux.Count; i++)
             {
                 unAnimal = (animal)lesAnimaux[i];
                 if (unAnimal.getCodeEspece() == leCodeEspeceChoisi && unAnimal.getNomBapteme() == leNomBapteme)
                 {
                     lAnimalTrouve = unAnimal;
                 }
             }
                
             //completer la méthode de manière à renvoyer un animal en fonction du codeEspece et du Nom de bapteme passé en paramètre.
             return (lAnimalTrouve);
         }

    }
}
