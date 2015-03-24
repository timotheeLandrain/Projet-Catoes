using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Application_Console_metier
{
    class espece
    {
        private int codeEspece;
        private String libelleEspece;

        public espece()
        {
        }
        public espece(int leCodeEspece, String leLibelleEspece)
        {
            this.codeEspece = leCodeEspece;
            this.libelleEspece = leLibelleEspece;
        }

        public int getEspece()
        {
            return this.codeEspece;
        }

        public String getLibelleEspece()
        {
            return this.libelleEspece;
        }

        public void setCodeEspece(int leCodeEspece)
        {
            this.codeEspece = leCodeEspece;
        }

        public void setLibelleEspece(String leLibelleEspece)
        {
            this.libelleEspece = leLibelleEspece;
        }
    }
}
