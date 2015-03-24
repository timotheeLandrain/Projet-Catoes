using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Application_Console_metier
{
    class menuType
    {
        private int codeMenuType;
        private int quantiteRecommandeMenuType;
        private String libelleAlimentComposeMenuType;
        private int codeEspece;

        public menuType()
        {
        }
        public menuType(int leCodeMenuType, int laQuantiteRecommandeMenuType, String leLibelleAlimentComposeMenuType, int leCodeEspece)
        {
            this.codeMenuType = leCodeMenuType;
            this.quantiteRecommandeMenuType = laQuantiteRecommandeMenuType;
            this.libelleAlimentComposeMenuType = leLibelleAlimentComposeMenuType;
            this.codeEspece = leCodeEspece;
        }

        public int getMenuType()
        {
            return this.codeMenuType;
        }

        public String getLibelleAlimentComposeMenuType()
        {
            return this.libelleAlimentComposeMenuType;
        }

        public int getQuantiteRecommandeMenuType()
        {
            return this.quantiteRecommandeMenuType;
        }

        public int getCodeEspece()
        {
            return this.codeEspece;
        }


        public void setCodeMenuType(int leCodeMenuType)
        {
            this.codeMenuType = leCodeMenuType;
        }

        public void setLibelleAlimentComposeMenuType(String leLibelleAlimentComposeMenuType)
        {
            this.libelleAlimentComposeMenuType = leLibelleAlimentComposeMenuType;
        }

        public void setQuantiteRecommandeMenuType(int laQuantiteRecommandeMenuType)
        {
            this.quantiteRecommandeMenuType = laQuantiteRecommandeMenuType;
        }

        public void setCodeEspece(int leCodeEspece)
        {
            this.codeEspece = leCodeEspece;
        }
    }
}
