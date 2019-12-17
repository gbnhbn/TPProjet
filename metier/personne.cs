using System;
using System.Collections.Generic;
using System.Text;

namespace metier
{
    public class personne
    {
        private Boolean ald;
        private Boolean enf;
        private String nom;
        private String prenom;

        public Boolean adulte
        {
            get => ald;
            set => ald = value;
        }

        public Boolean enfant
        {
            get => enf;
            set => enf = value;
        }

        public String Nom
        {
            get => nom;
            set => nom = value;
        }

        public String Prenom
        {
            get => prenom;
            set => prenom = value;
        }
    }
}
