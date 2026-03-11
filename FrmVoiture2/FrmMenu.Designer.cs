namespace FrmVoiture2
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
        private void InitializeComponent()
        {
            grpReservoir = new GroupBox();
            txtContenu = new TextBox();
            txtCapacite = new TextBox();
            btnValiderR = new Button();
            lblContenu = new Label();
            lblCapacite = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            grpVehicule = new GroupBox();
            txtimmat = new TextBox();
            txtVitesse = new TextBox();
            txtKmCompteur = new TextBox();
            txtVitesseMax = new TextBox();
            txtReservoir = new TextBox();
            btnValiderV = new Button();
            lblReservoir = new Label();
            lblVitesseMax = new Label();
            lblKmCompteur = new Label();
            lblVitesse = new Label();
            lblimmat = new Label();
            grpReservoir.SuspendLayout();
            grpVehicule.SuspendLayout();
            SuspendLayout();
            // 
            // grpReservoir
            // 
            grpReservoir.Controls.Add(txtContenu);
            grpReservoir.Controls.Add(txtCapacite);
            grpReservoir.Controls.Add(btnValiderR);
            grpReservoir.Controls.Add(lblContenu);
            grpReservoir.Controls.Add(lblCapacite);
            grpReservoir.Location = new Point(0, 0);
            grpReservoir.Name = "grpReservoir";
            grpReservoir.Size = new Size(300, 160);
            grpReservoir.TabIndex = 0;
            grpReservoir.TabStop = false;
            grpReservoir.Text = "Réservoir";
            // 
            // txtContenu
            // 
            txtContenu.Location = new Point(88, 78);
            txtContenu.Name = "txtContenu";
            txtContenu.Size = new Size(150, 31);
            txtContenu.TabIndex = 4;
            // 
            // txtCapacite
            // 
            txtCapacite.Location = new Point(88, 30);
            txtCapacite.Name = "txtCapacite";
            txtCapacite.Size = new Size(150, 31);
            txtCapacite.TabIndex = 3;
            // 
            // btnValiderR
            // 
            btnValiderR.Location = new Point(94, 120);
            btnValiderR.Name = "btnValiderR";
            btnValiderR.Size = new Size(112, 34);
            btnValiderR.TabIndex = 2;
            btnValiderR.Text = "Valider";
            btnValiderR.UseVisualStyleBackColor = true;
            btnValiderR.Click += btnValiderR_Click;
            // 
            // lblContenu
            // 
            lblContenu.AutoSize = true;
            lblContenu.Location = new Point(3, 78);
            lblContenu.Name = "lblContenu";
            lblContenu.Size = new Size(79, 25);
            lblContenu.TabIndex = 1;
            lblContenu.Text = "Contenu";
            // 
            // lblCapacite
            // 
            lblCapacite.AutoSize = true;
            lblCapacite.Location = new Point(3, 27);
            lblCapacite.Name = "lblCapacite";
            lblCapacite.Size = new Size(79, 25);
            lblCapacite.TabIndex = 0;
            lblCapacite.Text = "Capacite";
            // 
            // grpVehicule
            // 
            grpVehicule.Controls.Add(txtimmat);
            grpVehicule.Controls.Add(txtVitesse);
            grpVehicule.Controls.Add(txtKmCompteur);
            grpVehicule.Controls.Add(txtVitesseMax);
            grpVehicule.Controls.Add(txtReservoir);
            grpVehicule.Controls.Add(btnValiderV);
            grpVehicule.Controls.Add(lblReservoir);
            grpVehicule.Controls.Add(lblVitesseMax);
            grpVehicule.Controls.Add(lblKmCompteur);
            grpVehicule.Controls.Add(lblVitesse);
            grpVehicule.Controls.Add(lblimmat);
            grpVehicule.Location = new Point(332, 10);
            grpVehicule.Name = "grpVehicule";
            grpVehicule.Size = new Size(319, 292);
            grpVehicule.TabIndex = 5;
            grpVehicule.TabStop = false;
            grpVehicule.Text = "Véhicule";
            // 
            // txtimmat
            // 
            txtimmat.Location = new Point(143, 30);
            txtimmat.Name = "txtimmat";
            txtimmat.Size = new Size(150, 31);
            txtimmat.TabIndex = 6;
            // 
            // txtVitesse
            // 
            txtVitesse.Location = new Point(143, 71);
            txtVitesse.Name = "txtVitesse";
            txtVitesse.Size = new Size(150, 31);
            txtVitesse.TabIndex = 9;
            // 
            // txtKmCompteur
            // 
            txtKmCompteur.Location = new Point(143, 116);
            txtKmCompteur.Name = "txtKmCompteur";
            txtKmCompteur.Size = new Size(150, 31);
            txtKmCompteur.TabIndex = 8;
            // 
            // txtVitesseMax
            // 
            txtVitesseMax.Location = new Point(143, 154);
            txtVitesseMax.Name = "txtVitesseMax";
            txtVitesseMax.Size = new Size(150, 31);
            txtVitesseMax.TabIndex = 7;
            // 
            // txtReservoir
            // 
            txtReservoir.Location = new Point(143, 201);
            txtReservoir.Name = "txtReservoir";
            txtReservoir.Size = new Size(150, 31);
            txtReservoir.TabIndex = 6;
            // 
            // btnValiderV
            // 
            btnValiderV.Location = new Point(89, 252);
            btnValiderV.Name = "btnValiderV";
            btnValiderV.Size = new Size(112, 34);
            btnValiderV.TabIndex = 5;
            btnValiderV.Text = "Valider";
            btnValiderV.UseVisualStyleBackColor = true;
            btnValiderV.Click += btnValiderV_Click;
            // 
            // lblReservoir
            // 
            lblReservoir.AutoSize = true;
            lblReservoir.Location = new Point(6, 207);
            lblReservoir.Name = "lblReservoir";
            lblReservoir.Size = new Size(84, 25);
            lblReservoir.TabIndex = 4;
            lblReservoir.Text = "Réservoir";
            // 
            // lblVitesseMax
            // 
            lblVitesseMax.AutoSize = true;
            lblVitesseMax.Location = new Point(6, 160);
            lblVitesseMax.Name = "lblVitesseMax";
            lblVitesseMax.Size = new Size(105, 25);
            lblVitesseMax.TabIndex = 3;
            lblVitesseMax.Text = "Vitesse Max";
            // 
            // lblKmCompteur
            // 
            lblKmCompteur.AutoSize = true;
            lblKmCompteur.Location = new Point(6, 116);
            lblKmCompteur.Name = "lblKmCompteur";
            lblKmCompteur.Size = new Size(92, 25);
            lblKmCompteur.TabIndex = 2;
            lblKmCompteur.Text = "Compteur";
            // 
            // lblVitesse
            // 
            lblVitesse.AutoSize = true;
            lblVitesse.Location = new Point(6, 74);
            lblVitesse.Name = "lblVitesse";
            lblVitesse.Size = new Size(67, 25);
            lblVitesse.TabIndex = 1;
            lblVitesse.Text = "Vitesse";
            // 
            // lblimmat
            // 
            lblimmat.AutoSize = true;
            lblimmat.Location = new Point(1, 36);
            lblimmat.Name = "lblimmat";
            lblimmat.Size = new Size(136, 25);
            lblimmat.TabIndex = 0;
            lblimmat.Text = "Immatriculation";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpVehicule);
            Controls.Add(grpReservoir);
            Name = "FrmMenu";
            Text = "Menu";
            grpReservoir.ResumeLayout(false);
            grpReservoir.PerformLayout();
            grpVehicule.ResumeLayout(false);
            grpVehicule.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpReservoir;
        private TextBox txtContenu;
        private TextBox txtCapacite;
        private Button btnValiderR;
        private Label lblContenu;
        private Label lblCapacite;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grpVehicule;
        private TextBox txtimmat;
        private TextBox txtVitesse;
        private TextBox txtKmCompteur;
        private TextBox txtVitesseMax;
        private TextBox txtReservoir;
        private Button btnValiderV;
        private Label lblReservoir;
        private Label lblVitesseMax;
        private Label lblKmCompteur;
        private Label lblVitesse;
        private Label lblimmat;
    }
}
