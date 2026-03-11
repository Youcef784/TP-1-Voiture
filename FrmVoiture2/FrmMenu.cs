using Voiture;
namespace FrmVoiture2
{
    public partial class FrmMenu : Form
    {
        Reservoir[] tabReservoir = new Reservoir[3];
        int i = 0;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnValiderR_Click(object sender, EventArgs e)
        {
            tabReservoir[i] = new Reservoir(Convert.ToInt16(txtCapacite.Text));
            i++;
            if (i == tabReservoir.Length)
            {
                btnValiderR.Enabled = false;
                MessageBox.Show($"vous avez créez les {tabReservoir.Length} réservoirs");
            }
            txtCapacite.Clear();
            txtContenu.Clear();

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
    }
}
