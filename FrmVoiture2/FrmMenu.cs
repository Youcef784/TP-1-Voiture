using Voiture;
namespace FrmVoiture2
{
    public partial class FrmMenu : Form
    {
        List<Reservoir> listReservoir;
        int i = 0;
        public FrmMenu()
        {
            InitializeComponent();
            listReservoir = new List<Reservoir>();
        }

        private void btnValiderR_Click(object sender, EventArgs e)
        {
            listReservoir.Add(new Reservoir(Convert.ToInt16(txtCapacite.Text)))
        }

        private void btnValiderV_Click(object sender, EventArgs e)
        {
            Reservoir r = new Reservoir();
            foreach (Reservoir res in tabReservoir)
            {
                if (res.getCapacite() == Convert.ToInt16(txtCapacite.Text))
                {
                    r = res;
                }
            }
            VoiturePersonnel v1 = new VoiturePersonnel(txtimmat.Text, Convert.ToInt16(txtVitesseMax.Text), r);
        }

        private void lblCapacite_Click(object sender, EventArgs e)
        {

        }

        private void grpReservoir_Enter(object sender, EventArgs e)
        {

        }
    }
}
