namespace FrmVoiture
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(EventHandler label5_Click)
        {
            grpRéservoir = new GroupBox();
            lblCapacite = new Label();
            txtCapacite = new TextBox();
            lblContenu = new Label();
            txtContenu = new TextBox();
            btnValiderR = new Button();
            grpVéhicule = new GroupBox();
            lblimmat = new Label();
            txtimmat = new TextBox();
            lblVitesse = new Label();
            lblKmCompteur = new Label();
            lblVitesseMax = new Label();
            lblReservoir = new Label();
            txtVitesse = new TextBox();
            txtKmCompteur = new TextBox();
            txtVitesseMax = new TextBox();
            txtReservoir = new TextBox();
            btnValiderV = new Button();
            grpRéservoir.SuspendLayout();
            grpVéhicule.SuspendLayout();
            SuspendLayout();
            // 
            // grpRéservoir
            // 
            grpRéservoir.Controls.Add(btnValiderR);
            grpRéservoir.Controls.Add(txtContenu);
            grpRéservoir.Controls.Add(lblContenu);
            grpRéservoir.Controls.Add(txtCapacite);
            grpRéservoir.Controls.Add(lblCapacite);
            grpRéservoir.Location = new Point(0, 0);
            grpRéservoir.Name = "grpRéservoir";
            grpRéservoir.Size = new Size(325, 191);
            grpRéservoir.TabIndex = 0;
            grpRéservoir.TabStop = false;
            grpRéservoir.Text = "Réservoir";
        
            // 
            // lblCapacite
            // 
            lblCapacite.AutoSize = true;
            lblCapacite.Location = new Point(23, 49);
            lblCapacite.Name = "lblCapacite";
            lblCapacite.Size = new Size(79, 25);
            lblCapacite.TabIndex = 0;
            lblCapacite.Text = "Capacite";
            // 
            // txtCapacite
            // 
            txtCapacite.Location = new Point(127, 49);
            txtCapacite.Name = "txtCapacite";
            txtCapacite.Size = new Size(150, 31);
            txtCapacite.TabIndex = 1;
            txtCapacite.TextChanged += textBox1_TextChanged;
            // 
            // lblContenu
            // 
            lblContenu.AutoSize = true;
            lblContenu.Location = new Point(23, 107);
            lblContenu.Name = "lblContenu";
            lblContenu.Size = new Size(79, 25);
            lblContenu.TabIndex = 2;
            lblContenu.Text = "Contenu";
            lblContenu.Click += label2_Click;
            // 
            // txtContenu
            // 
            txtContenu.Location = new Point(127, 101);
            txtContenu.Name = "txtContenu";
            txtContenu.Size = new Size(150, 31);
            txtContenu.TabIndex = 3;
            // 
            // btnValiderR
            // 
            btnValiderR.Location = new Point(127, 151);
            btnValiderR.Name = "btnValiderR";
            btnValiderR.Size = new Size(112, 34);
            btnValiderR.TabIndex = 4;
            btnValiderR.Text = "Valider";
            btnValiderR.UseVisualStyleBackColor = true;
            btnValiderR.Click += button1_Click;
            // 
            // grpVéhicule
            // 
            grpVéhicule.Controls.Add(btnValiderV);
            grpVéhicule.Controls.Add(txtReservoir);
            grpVéhicule.Controls.Add(txtVitesseMax);
            grpVéhicule.Controls.Add(txtKmCompteur);
            grpVéhicule.Controls.Add(txtVitesse);
            grpVéhicule.Controls.Add(lblReservoir);
            grpVéhicule.Controls.Add(lblVitesseMax);
            grpVéhicule.Controls.Add(lblKmCompteur);
            grpVéhicule.Controls.Add(lblVitesse);
            grpVéhicule.Controls.Add(txtimmat);
            grpVéhicule.Controls.Add(lblimmat);
            grpVéhicule.Location = new Point(385, 12);
            grpVéhicule.Name = "grpVéhicule";
            grpVéhicule.Size = new Size(369, 293);
            grpVéhicule.TabIndex = 1;
            grpVéhicule.TabStop = false;
            grpVéhicule.Text = "Véhicule";
            grpVéhicule.Enter += groupBox2_Enter;
            // 
            // lblimmat
            // 
            lblimmat.AutoSize = true;
            lblimmat.Location = new Point(3, 27);
            lblimmat.Name = "lblimmat";
            lblimmat.Size = new Size(136, 25);
            lblimmat.TabIndex = 0;
            lblimmat.Text = "Immatriculation";
            // 
            // txtimmat
            // 
            txtimmat.Location = new Point(144, 27);
            txtimmat.Name = "txtimmat";
            txtimmat.Size = new Size(150, 31);
            txtimmat.TabIndex = 1;
            // 
            // lblVitesse
            // 
            lblVitesse.AutoSize = true;
            lblVitesse.Location = new Point(6, 67);
            lblVitesse.Name = "lblVitesse";
            lblVitesse.Size = new Size(67, 25);
            lblVitesse.TabIndex = 2;
            lblVitesse.Text = "Vitesse";
            // 
            // lblKmCompteur
            // 
            lblKmCompteur.AutoSize = true;
            lblKmCompteur.Location = new Point(6, 106);
            lblKmCompteur.Name = "lblKmCompteur";
            lblKmCompteur.Size = new Size(92, 25);
            lblKmCompteur.TabIndex = 3;
            lblKmCompteur.Text = "Compteur";
            lblKmCompteur.Click += label5_Click;
            // 
            // lblVitesseMax
            // 
            lblVitesseMax.AutoSize = true;
            lblVitesseMax.Location = new Point(6, 144);
            lblVitesseMax.Name = "lblVitesseMax";
            lblVitesseMax.Size = new Size(105, 25);
            lblVitesseMax.TabIndex = 4;
            lblVitesseMax.Text = "Vitesse Max";
            // 
            // lblReservoir
            // 
            lblReservoir.AutoSize = true;
            lblReservoir.Location = new Point(6, 186);
            lblReservoir.Name = "lblReservoir";
            lblReservoir.Size = new Size(84, 25);
            lblReservoir.TabIndex = 5;
            lblReservoir.Text = "Réservoir";
            // 
            // txtVitesse
            // 
            txtVitesse.Location = new Point(144, 67);
            txtVitesse.Name = "txtVitesse";
            txtVitesse.Size = new Size(150, 31);
            txtVitesse.TabIndex = 6;
            // 
            // txtKmCompteur
            // 
            txtKmCompteur.Location = new Point(144, 106);
            txtKmCompteur.Name = "txtKmCompteur";
            txtKmCompteur.Size = new Size(150, 31);
            txtKmCompteur.TabIndex = 7;
            // 
            // txtVitesseMax
            // 
            txtVitesseMax.Location = new Point(144, 144);
            txtVitesseMax.Name = "txtVitesseMax";
            txtVitesseMax.Size = new Size(150, 31);
            txtVitesseMax.TabIndex = 8;
            // 
            // txtReservoir
            // 
            txtReservoir.Location = new Point(144, 186);
            txtReservoir.Name = "txtReservoir";
            txtReservoir.Size = new Size(150, 31);
            txtReservoir.TabIndex = 9;
            // 
            // btnValiderV
            // 
            btnValiderV.Location = new Point(162, 243);
            btnValiderV.Name = "btnValiderV";
            btnValiderV.Size = new Size(112, 34);
            btnValiderV.TabIndex = 10;
            btnValiderV.Text = "Valider";
            btnValiderV.UseVisualStyleBackColor = true;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpVéhicule);
            Controls.Add(grpRéservoir);
            Name = "FrmMenu";
            Text = "Menu";
            grpRéservoir.ResumeLayout(false);
            grpRéservoir.PerformLayout();
            grpVéhicule.ResumeLayout(false);
            grpVéhicule.PerformLayout();
            ResumeLayout(false);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox grpRéservoir;
        private TextBox txtCapacite;
        private Label lblCapacite;
        private Button btnValiderR;
        private TextBox txtContenu;
        private Label lblContenu;
        private GroupBox grpVéhicule;
        private Label lblReservoir;
        private Label lblVitesseMax;
        private Label lblKmCompteur;
        private Label lblVitesse;
        private TextBox txtimmat;
        private Label lblimmat;
        private Button btnValiderV;
        private TextBox txtReservoir;
        private TextBox txtVitesseMax;
        private TextBox txtKmCompteur;
        private TextBox txtVitesse;
    }
}
