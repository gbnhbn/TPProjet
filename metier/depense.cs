using System;
using System.Collections.Generic;
using System.Text;

namespace metier
{
    public class depense
    {

        private float valeur;
        private DateTime date;
        private séjour s;
        private famille f;

        public float val
        {
            get => val;
            set => val = value;
        }

        public DateTime d
        {
            get => d;
            set => d = value;
        }

        public depense(float val, DateTime date)
        {
            this.valeur = val;
            this.date = date;
        }



    }
}
