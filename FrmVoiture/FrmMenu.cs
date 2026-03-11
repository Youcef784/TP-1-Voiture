using Voiture;

namespace FrmVoiture
{

    public partial class FrmMenu : Form
    {
        Reservoir[] tabResevoir = new Reservoir[3];
        int i = 0;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnValiderR_Clik(object sender, EventArgs e)
        {
            tabResevoir[i] = new Reservoir(Convert.ToInt16(txtCapacite.Text));
            i++;
            if(i == tabResevoir.Length)
            {
                btnValiderR.Enabled = false;
                MessageBox.Show($"Vous avez créer les {tabResevoir.Length} réservoirs");
            }
            txtCapacite.Clear();
            txtContenu.Clear();
        }
    }
}
