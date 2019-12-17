using System;
using System.Collections.Generic;
using System.Text;

namespace metier
{
    public class famille
    {
        private List<depense> depenses;
        private List<personne> personnes;
        static List<famille> familles;


        public int nombre()
        {
            return 0;
        }


        public void setPersonnes(List<personne> ps)
        {
            this.personnes = ps;
        }
    }
}
