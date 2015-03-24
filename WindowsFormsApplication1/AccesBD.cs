using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading;
using System.Globalization;

namespace catoesDistributionMenu
{

    class accesBD
    {
        SqlConnection connection;

        //----------------------------------------------------------
        //     Constructeur : permet de se connecter à la BD       -
        //----------------------------------------------------------
        public accesBD(string nomBase, string nomServeur)
        {
            //Je me connecte à la BD en local
            string connectString = "database=" + nomBase + ";server=" + nomServeur + ";Integrated Security=SSPI;";
            // Je me connecte à la BD depuis un serveur distant
            // mettre ici la chaine specifique a son serveur

            connection = new SqlConnection(connectString);

        }

        //----------------------------------------------------------
        //     Les méthodes qui permettent de faire des ajouts     -
        //----------------------------------------------------------

        //- Ajouter un Animal


        public void ajouterUnAnimal(int leCodeEspece, String leNomBapteme, String leSexe, int laDateNaissAnimal, int laDateDeces)
        {
            try
            {
                connection.Open();
                string maRequete = "insert into animal values (" + leCodeEspece + ",'" + leNomBapteme + "','" + leSexe + "'," + laDateNaissAnimal + "," + laDateDeces + ");";
                SqlCommand maCommande = new SqlCommand(maRequete, connection);
                maCommande.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException ex)
            {
                connection.Close();
                System.Windows.Forms.MessageBox.Show(ex.Errors[0].Message);
            }
        }


        //- Ajouter un menu Type (attention ma base n'a pas d'autoincrémentation)

        public void ajouterUnMenuType(int laQuantiteRecommandeMenuType, String leLibelleAlimentComposeMenuType, int leCodeEspece)
        {
            try
            {
                // je recupère le code le plus grand dans ma table, j'ajoute 1
                int nbrMax;
                connection.Open();
                string maRequeteCode = "select max(codeMenu) from menuType";
                SqlCommand maCommandeCode = new SqlCommand(maRequeteCode, connection);
                SqlDataReader maLectureCode = maCommandeCode.ExecuteReader();
                maLectureCode.Read();
                nbrMax = (int)maLectureCode[0] + 1;
                maLectureCode.Close();
                string maRequete = "insert into MenuType values (" + nbrMax + "," + leCodeEspece + ",'" + leLibelleAlimentComposeMenuType + "'," + laQuantiteRecommandeMenuType + ");";
                SqlCommand maCommande = new SqlCommand(maRequete, connection);
                maCommande.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException ex)
            {
                connection.Close();
                System.Windows.Forms.MessageBox.Show(ex.Errors[0].Message);
            }
        }



        //- Ajouter un Menu Distribue

        public void ajouterUneDistribution(int leCodeMenu, int leCodeEspece, String leNomBapteme, int laQuantiteAbsorbe, DateTime laDateHeure)
        {
            try
            {
                connection.Open();
                string maRequete2 = "select count(*) from dateheurerepas where dateheuremanger = '" + laDateHeure + "';";
                SqlCommand maCommande2 = new SqlCommand(maRequete2, connection);
                maCommande2.ExecuteNonQuery();
                SqlDataReader maLectureCode = maCommande2.ExecuteReader();
                maLectureCode.Read();
                Console.WriteLine(" le nombre de date identique {0}", (int)maLectureCode[0]);
                if ((int)maLectureCode[0] < 1)
                {
                    string maRequete1 = "insert into DateHeureRepas values ('" + laDateHeure + "')";
                    SqlCommand maCommande1 = new SqlCommand(maRequete1, connection);
                    maCommande1.ExecuteNonQuery();
                }
                maLectureCode.Close();
                leNomBapteme = leNomBapteme.Replace(" ", "");
                string maRequete = "insert into animalRecevoirMenu values (" + leCodeMenu + "," + leCodeEspece + ",'" + leNomBapteme + "','" + laDateHeure + "'," + laQuantiteAbsorbe + ")";
                Console.WriteLine("la requete que j'envoie : {0}", maRequete);
                SqlCommand maCommande = new SqlCommand(maRequete, connection);
                maCommande.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException ex)
            {
                connection.Close();
                System.Windows.Forms.MessageBox.Show(ex.Errors[0].Message);
            }
        }



        //- Ajouter une espece (attention ma base n'a pas d'autoincrémentation)
        public void ajouterUneEspece(string leLibelleEspece)
        {
            try
            {
                // je recupère le code le plus grand dans ma table, j'ajoute 1
                int nbrMax;
                connection.Open();
                string maRequeteCode = "select max(codeEspece) from espece";
                SqlCommand maCommandeCode = new SqlCommand(maRequeteCode, connection);
                SqlDataReader maLectureCode = maCommandeCode.ExecuteReader();
                maLectureCode.Read();
                nbrMax = (int)maLectureCode[0] + 1;
                maLectureCode.Close();
                string maRequeteInsertion = "insert into Espece values (" + nbrMax + ",'" + leLibelleEspece + "');";
                SqlCommand maCommandeInsertion = new SqlCommand(maRequeteInsertion, connection);
                maCommandeInsertion.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException ex)
            {
                connection.Close();
                System.Windows.Forms.MessageBox.Show(ex.Errors[0].Message);
            }


        }

        //-------------------------------------------------------------
        //     Les méthodes qui permettent de faire des modifications -
        //-------------------------------------------------------------

        //- Modifier un Animal : on ne peut pas modifier le codeEspece et le nomBapteme (clé primaire dans la base)


        public void modifierUnAnimal(int leCodeEspece, String leNomBapteme, string leSexe, int laDateNaissAnimal, int laDateDecesAnimal)
        {
            try
            {

                connection.Open();
                leNomBapteme = leNomBapteme.Replace(" ", "");
                String maRequete = "update animal set datenaissance = " + laDateNaissAnimal + " where CodeEspece = " + leCodeEspece + " and nomBapteme = '" + leNomBapteme + "'";
                SqlCommand maCommande = new SqlCommand(maRequete, connection);
                maCommande.ExecuteNonQuery();
                String maRequete1 = "update ANIMAL set DATEDECES = " + laDateDecesAnimal + " where CODEESPECE = " + leCodeEspece + " and NOMBAPTEME = '" + leNomBapteme + "';";
                SqlCommand maCommande1 = new SqlCommand(maRequete1, connection);
                maCommande1.ExecuteNonQuery();
                String maRequete2 = "update ANIMAL set SEXE = '" + Convert.ToChar(leSexe) + "' where CodeEspece = " + leCodeEspece + " and nomBapteme = '" + leNomBapteme + "'";
                SqlCommand maCommande2 = new SqlCommand(maRequete2, connection);
                maCommande2.ExecuteNonQuery();
                connection.Close();

            }
            catch (SqlException ex)
            {
                connection.Close();
                System.Windows.Forms.MessageBox.Show(ex.Errors[0].Message);
            }

        }

        //- Modifier un Menu Type : on ne peut pas modifier le code du menu (clé primaire dans la base)

        public void modifierUnMenuType(int leCodeMenuType, int leCodeEspece, string leLibelleAlimentComposeMenuType, int laQuantiteRecommande)
        {
            try
            {
                Console.WriteLine(" codeMenu : {0} libelle : {1} quantite : {2} codeEspece {3} ", leCodeMenuType, leLibelleAlimentComposeMenuType, laQuantiteRecommande, leCodeEspece);
                connection.Open();
                string maRequete = "update menuType set libelleAlimentCompose = '" + leLibelleAlimentComposeMenuType + "' where codeMenu = " + leCodeMenuType + ";";
                SqlCommand maCommande = new SqlCommand(maRequete, connection);
                maCommande.ExecuteNonQuery();
                string maRequete1 = "update menuType set QteRecommande = " + laQuantiteRecommande + " where codeMenu = " + leCodeMenuType + ";";
                SqlCommand maCommande1 = new SqlCommand(maRequete1, connection);
                maCommande1.ExecuteNonQuery();
                string maRequete2 = "update menuType set codeEspece = " + leCodeEspece + " where codeMenu = " + leCodeMenuType + ";";
                SqlCommand maCommande2 = new SqlCommand(maRequete2, connection);
                maCommande2.ExecuteNonQuery();
                connection.Close();

            }
            catch (SqlException ex)
            {
                connection.Close();
                System.Windows.Forms.MessageBox.Show(ex.Errors[0].Message);
            }

        }

        //-  Modifier un menu recu par un animal : on ne doit pouvoir modifier que la quantité absorbée

        public void modifierUnRepasRecu(int leCodeMenuType, string leNomBapteme, DateTime laDateheuremanger, int laQuantiteAbsorbe, int leCodeEspece)
        {
            try
            {
                connection.Open();
                string maRequete = "update animalRecevoirMenu set qteAbsorbee = " + laQuantiteAbsorbe + " where codeMenu = " + leCodeMenuType + " and nomBapteme = '" + leNomBapteme + " and codeEspece = " + leCodeEspece + "and dateheuremanger = #" + laDateheuremanger + "#";
                SqlCommand maCommande = new SqlCommand(maRequete, connection);
                maCommande.ExecuteNonQuery();
                connection.Close();

            }
            catch (SqlException ex)
            {
                connection.Close();
                System.Windows.Forms.MessageBox.Show(ex.Errors[0].Message);
            }

        }

        //-  Modifier une espece : on ne doit pouvoir modifier que le libellé de l'espece

        public void modifierUneEspece(int leCodeEspece, string leLibelleEspece)
        {
            try
            {
                connection.Open();
                string maRequete = "update espece set libelle = '" + leLibelleEspece + "' where codeEspece = " + leCodeEspece + ";";
                SqlCommand maCommande = new SqlCommand(maRequete, connection);
                maCommande.ExecuteNonQuery();
                connection.Close();

            }
            catch (SqlException ex)
            {
                connection.Close();
                System.Windows.Forms.MessageBox.Show(ex.Errors[0].Message);
            }

        }

        //------------------------------------------------------------------------------
        //-       Méthodes permettant de charger les différents conteneurs             -
        //------------------------------------------------------------------------------

        //Chargement des animaux

        public string[,] chargementAnimal()
        {
            try
            {
                // Je vais voir combien de lignes il y a dans mon résultat de requete
                string nbrLigne1;
                int nbrLigne;
                connection.Open();
                string maRequete = "select count(*) from animal";
                SqlCommand maCommande = new SqlCommand(maRequete, connection);
                SqlDataReader monLecteur = maCommande.ExecuteReader();
                nbrLigne1 = "";
                while (monLecteur.Read())
                {
                    nbrLigne1 = monLecteur[0].ToString();
                }
                monLecteur.Close(); //Je ferme ma requête. 

                // J'initialise le compteur des lignes et de colonne du tableaux
                nbrLigne = Convert.ToInt32(nbrLigne1);
                int nbrCol = 5;

                // je vais récupérer les animaux dans ma base de données

                string maRequeteSelection = "select codeespece, nomBapteme, sexe, dateNaissance, dateDeces from animal";
                SqlCommand maCommandeSelection = new SqlCommand(maRequeteSelection, connection);
                SqlDataReader maLecture = maCommandeSelection.ExecuteReader();
                int i = 0;
                string[,] TableauTable = new string[nbrLigne, nbrCol];
                while (maLecture.Read())
                {
                    for (int j = 0; j < 5; j++)
                    {
                        TableauTable[i, j] = maLecture[j].ToString();
                    }
                    i++;
                }

                //Je renvoie mon tableau 2 dimensions avec tous les animaux.
                connection.Close();
                maLecture.Close();
                return TableauTable;
            }
            catch (SqlException ex)
            {
                connection.Close();
                string[,] TableauTableErreur = new string[1, 1];
                TableauTableErreur[0, 0] = "erreur dans la requete";
                System.Windows.Forms.MessageBox.Show(TableauTableErreur[0, 0]);
                System.Windows.Forms.MessageBox.Show(ex.Errors[0].Message);
                return (TableauTableErreur);

            }

        }

        //- Chargement du conteneur des menus types

        public string[,] chargementMenuType()
        {
            try
            {
                // Je vais voir combien de lignes il y a dans mon résultat de requete
                string nbrLigne1;
                int nbrLigne;
                connection.Open();
                string maRequete = "select count(*) from MenuType";
                SqlCommand maCommande = new SqlCommand(maRequete, connection);
                SqlDataReader monLecteur = maCommande.ExecuteReader();
                nbrLigne1 = "";
                while (monLecteur.Read())
                {
                    nbrLigne1 = monLecteur[0].ToString();
                }
                monLecteur.Close(); //Je ferme ma requête. 

                // J'initialise le compteur des lignes et de colonne du tableaux
                nbrLigne = Convert.ToInt32(nbrLigne1);
                int nbrCol = 4;

                // je vais récupérer les Menus Types dans ma base de données

                string maRequeteSelection = "select codeMenu, codeEspece, libelleAlimentCompose, qteRecommande from menuType";
                SqlCommand maCommandeSelection = new SqlCommand(maRequeteSelection, connection);
                SqlDataReader maLecture = maCommandeSelection.ExecuteReader();
                int i = 0;
                string[,] TableauTable = new string[nbrLigne, nbrCol];
                while (maLecture.Read())
                {
                    for (int j = 0; j < 4; j++)
                    {
                        TableauTable[i, j] = maLecture[j].ToString();
                    }
                    i++;
                }

                //Je renvoie mon tableau 2 dimensions avec tous les menus types.
                connection.Close();
                maLecture.Close();
                return TableauTable;
            }
            catch (SqlException ex)
            {
                connection.Close();
                string[,] TableauTableErreur = new string[1, 1];
                TableauTableErreur[0, 0] = "erreur dans la requete";
                System.Windows.Forms.MessageBox.Show(TableauTableErreur[0, 0]);
                System.Windows.Forms.MessageBox.Show(ex.Errors[0].Message);
                return (TableauTableErreur);

            }


        }

        //- Chargement du conteneur des repas distribués

        public string[,] chargementRepasDistribues()
        {
            try
            {
                // Je vais voir combien de lignes il y a dans mon résultat de requete
                string nbrLigne1;
                int nbrLigne;
                connection.Open();
                string maRequete = "select count(*) from AnimalRecevoirMenu";
                SqlCommand maCommande = new SqlCommand(maRequete, connection);
                SqlDataReader monLecteur = maCommande.ExecuteReader();
                nbrLigne1 = "";
                while (monLecteur.Read())
                {
                    nbrLigne1 = monLecteur[0].ToString();
                }
                monLecteur.Close(); //Je ferme ma requête. 

                // J'initialise le compteur des lignes et de colonne du tableaux
                nbrLigne = Convert.ToInt32(nbrLigne1);
                int nbrCol = 5;

                // je vais récupérer les Menus Distribués dans ma base de données

                string maRequeteSelection = "select codeMenu, codeEspece, nomBapteme, dateheureManger, qteAbsorbee from animalRecevoirMenu";
                SqlCommand maCommandeSelection = new SqlCommand(maRequeteSelection, connection);
                SqlDataReader maLecture = maCommandeSelection.ExecuteReader();
                int i = 0;
                string[,] TableauTable = new string[nbrLigne, nbrCol];
                while (maLecture.Read())
                {
                    for (int j = 0; j < 5; j++)
                    {
                        TableauTable[i, j] = maLecture[j].ToString();
                    }
                    i++;
                }

                //Je renvoie mon tableau 2 dimensions avec tous les menus distribués.
                connection.Close();
                maLecture.Close();
                return TableauTable;
            }
            catch (SqlException ex)
            {
                connection.Close();
                string[,] TableauTableErreur = new string[1, 1];
                TableauTableErreur[0, 0] = "erreur dans la requete";
                System.Windows.Forms.MessageBox.Show(TableauTableErreur[0, 0]);
                System.Windows.Forms.MessageBox.Show(ex.Errors[0].Message);
                return (TableauTableErreur);

            }


        }

        //- Chargement du conteneur des especes

        public string[,] chargementEspece()
        {
            try
            {
                // Je vais voir combien de lignes il y a dans mon résultat de requete
                string nbrLigne1;
                int nbrLigne;
                connection.Open();
                string maRequete = "select count(*) from espece";
                SqlCommand maCommande = new SqlCommand(maRequete, connection);
                SqlDataReader monLecteur = maCommande.ExecuteReader();
                nbrLigne1 = "";
                while (monLecteur.Read())
                {
                    nbrLigne1 = monLecteur[0].ToString();
                }
                monLecteur.Close(); //Je ferme ma requête. 

                // J'initialise le compteur des lignes et de colonne du tableaux
                nbrLigne = Convert.ToInt32(nbrLigne1);
                int nbrCol = 2;

                // je vais récupérer les especes dans ma base de données

                string maRequeteSelection = "select codeEspece, libelle from espece";
                SqlCommand maCommandeSelection = new SqlCommand(maRequeteSelection, connection);
                SqlDataReader maLecture = maCommandeSelection.ExecuteReader();
                int i = 0;
                string[,] TableauTable = new string[nbrLigne, nbrCol];
                while (maLecture.Read())
                {
                    for (int j = 0; j < 2; j++)
                    {
                        TableauTable[i, j] = maLecture[j].ToString();
                    }
                    i++;
                }

                //Je renvoie mon tableau 2 dimensions avec toutes les especes.
                connection.Close();
                maLecture.Close();
                return TableauTable;
            }
            catch (SqlException ex)
            {
                connection.Close();
                string[,] TableauTableErreur = new string[1, 1];
                TableauTableErreur[0, 0] = "erreur dans la requete";
                System.Windows.Forms.MessageBox.Show(TableauTableErreur[0, 0]);
                System.Windows.Forms.MessageBox.Show(ex.Errors[0].Message);
                return (TableauTableErreur);

            }


        }

    }

}

