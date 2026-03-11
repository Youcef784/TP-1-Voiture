using System.Security.Cryptography;

namespace Voiture
{
    public class Reservoir
    {
        private int capacite;
        public int contenu;

        public Reservoir(int capa)
        {
            this.capacite = capa;

        }

        public void diminuer(int nblitres)
        {
            this.capacite -= nblitres;
        }
        public int getContenu()
        {
            return this.contenu;
        }
        public int getCapacite()
        {
            return this.capacite;
        }

        public void remplir()
        {
            this.capacite++;
        }


        public override string ToString()
        {
            return "Contenu du réservoir : " + this.capacite + " litres";
        }


    }

}