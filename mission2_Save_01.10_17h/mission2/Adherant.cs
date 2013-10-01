using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mission2
{
    class Adherant
    {
        private Int32 numero;
        private String nom;
        private String prenom;
        private Int32 numLigue;
        private String mdp;
        private Int32 droit;

        public Adherant(Int32 pNumero, String pNom, String pPrenom, Int32 pNumLigue, String pMdp, Int32 pDroit)
        {
            numero = pNumero;
            nom = pNom;
            prenom = pPrenom;
            numLigue = pNumLigue;
            mdp = pMdp;
            droit = pDroit;
        }

        public Int32 GetDroit()
        {
            return (droit);
        }

    }
}
