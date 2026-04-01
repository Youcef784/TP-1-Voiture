using Voiture;
namespace FrmVoiture2
{
    public partial class FrmMenu : Form
    {
        List<Reservoir> listReservoir;
        int i = 0;
        List<VoiturePersonnel> listVoiturePersonnel;
        int j = 0;
        public FrmMenu()
        {
            InitializeComponent();
            listReservoir = new List<Reservoir>();
            listVoiturePersonnel = new List<VoiturePersonnel>();
        }

        private void btnValiderR_Click(object sender, EventArgs e)
        {
            listReservoir.Add(new Reservoir(Convert.ToInt16(txtCapacite.Text)));
            cmbReservoir.Items.Clear();
            foreach (Reservoir res in listReservoir)
            {
                //MessageBox.Show(Convert.ToString(res.getContenu()));
                cmbReservoir.Items.Add(res.getContenu());
            }

            int voiture = Convert.ToInt16(cmbvoiture.Items);
            cmbvoiture.Items.Clear();
            foreach (VoiturePersonnel vp in listVoiturePersonnel)
            {
                    lstVehicule.Items.Add(vp.ToString());
            }
        }

        private void btnValiderV_Click(object sender, EventArgs e)
        {
            Reservoir r = new Reservoir();
            int reservoir = Convert.ToInt16(cmbReservoir.SelectedItem.ToString());
            foreach (Reservoir res in listReservoir)
            {
                if (res.getCapacite() == reservoir)
                {
                    r = res;
                }
            }
            VoiturePersonnel v1 = new VoiturePersonnel(txtimmat.Text, Convert.ToInt16(txtVitesseMax.Text), r);

            Garage g = new Garage();
        }


        private void lblCapacite_Click(object sender, EventArgs e)
        {

        }

        private void grpReservoir_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnvalider_Click(object sender, EventArgs e)
        {

        }

        private void cmbReservoir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
