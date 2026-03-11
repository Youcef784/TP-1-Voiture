using System;
using System.Collections.Generic;
using System.Text;

namespace Voiture
{
    public class VoiturePersonnel
    {
        private string immatriculation;
        private int vitesse;
        private int kmCompteur;
        private int vitesseMax;

        private Reservoir monReservoir;
        public VoiturePersonnel(string imma, int vMax, Reservoir r)
        {
            this.immatriculation = imma;
            this.vitesseMax = vMax;
            this.monReservoir = r;
        }

        public int consommationAu100km()
        {
            return 5;
        }

        public void fairePlein()
        {
            monReservoir.remplir();
        }

        public Reservoir GetReservoir()
        {
            return this.monReservoir;
        }

        public void rouler(int nbKm, int vitesse)
        {
            this.vitesse = vitesse;
            this.kmCompteur += nbKm;
            int consommation = (nbKm * consommationAu100km()) / 100;
            monReservoir.diminuer(consommation);
        }

        public override string ToString()
        {
            return $"km au compteur : {this.kmCompteur} km ,vitesse :   {vitesse} km/h,   {monReservoir.ToString()}";

        }
    }
}
