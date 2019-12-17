using System;
using System.Collections.Generic;
using System.Text;

namespace metier
{
    class séjour
    {
        private DateTime dateDebut;
        private DateTime dateFin;
        private List<famille> fa;
        static List<séjour> sejours;

        public DateTime debut
        {
            get => debut;
            set => debut = value;
        }

        public DateTime fin
        {
            get => fin;
            set => fin = value;
        }

        public int nbPersonnes()
        {
            return fa.Count;
        }

        public int nbAdultes(int nbA)
        {
            return fa.Count;
        }

        public int nbEnfants(int nbE)
        {
            return fa.Count;
        }
    }
}

