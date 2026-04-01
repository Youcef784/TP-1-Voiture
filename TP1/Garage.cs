namespace Voiture
{
    public class Garage
    {
        List<VoiturePersonnel> listVoiture;
        public Garage() 
        {
            this.listVoiture = new List<VoiturePersonnel>();
        }
        public List<VoiturePersonnel> getVoiture()
        { 
            return listVoiture;
        }
    }
}
