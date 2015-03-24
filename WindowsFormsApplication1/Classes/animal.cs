using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Application_Console_metier
{
    class animal
    {

        private int codeEspece;
        private String nomBapteme;
        private String sexeAnimal;
        private int dateNaisAnimal;
        private int dateDecesAnimal;

        public animal()
        {

        }

        public animal(int leCodeEspece, String leNomBapteme, String leSexeAnimal, int laDateNaisAnimal, int laDateDecesAnimal)
        {
            this.codeEspece = leCodeEspece;
            this.nomBapteme = leNomBapteme;
            this.sexeAnimal = leSexeAnimal;
            this.dateNaisAnimal = laDateNaisAnimal;
            this.dateDecesAnimal = laDateDecesAnimal;
        }

        public int getCodeEspece()
        {
            return this.codeEspece;
        }

        public String getNomBapteme()
        {
            return this.nomBapteme;
        }

        public String getSexeAnimal()
        {
            return this.sexeAnimal;
        }

        public int getDateNaisAnimal()
        {
            return this.dateNaisAnimal;
        }

        public int getDateDecesAnimal()
        {
            return this.dateDecesAnimal;
        }

        public void setCodeEspece(int leCodeEspece)
        {
            this.codeEspece = leCodeEspece;
        }

        public void setNomBapteme(String leNomBapteme)
        {
            this.nomBapteme = leNomBapteme;
        }

        public void setSexeAnimal(String leSexeAnimal)
        {
            this.sexeAnimal = leSexeAnimal;
        }
        public void setDateNaisAnimal(int laDateNaisAnimal)
        {
            this.dateNaisAnimal = laDateNaisAnimal;
        }

        public void setDateDecesAnimal(int laDateDecesAnimal)
        {
            this.dateDecesAnimal = laDateDecesAnimal;
        }

    }
}
