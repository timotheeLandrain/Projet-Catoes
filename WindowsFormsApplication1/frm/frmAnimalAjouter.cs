using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmAnimalAjouter : Form
    {
        controleur leControleur = new controleur();
        private ListBox espece;
        private TextBox nomDeBapteme;
        private ListBox sexe;
        private TextBox dateDeNaissance;
        private Button btnValiderAjoutAnimal;
        private PictureBox pictureBox1;
    
        public frmAnimalAjouter()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnimalAjouter));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.espece = new System.Windows.Forms.ListBox();
            this.nomDeBapteme = new System.Windows.Forms.TextBox();
            this.sexe = new System.Windows.Forms.ListBox();
            this.dateDeNaissance = new System.Windows.Forms.TextBox();
            this.btnValiderAjoutAnimal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 89);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // espece
            // 
            this.espece.FormattingEnabled = true;
            this.espece.Location = new System.Drawing.Point(76, 107);
            this.espece.Name = "espece";
            this.espece.Size = new System.Drawing.Size(131, 17);
            this.espece.TabIndex = 1;
            // 
            // nomDeBapteme
            // 
            this.nomDeBapteme.AcceptsTab = true;
            this.nomDeBapteme.Location = new System.Drawing.Point(76, 130);
            this.nomDeBapteme.Name = "nomDeBapteme";
            this.nomDeBapteme.Size = new System.Drawing.Size(128, 20);
            this.nomDeBapteme.TabIndex = 2;
            this.nomDeBapteme.Text = "Nom de Baptème";
            this.nomDeBapteme.TextChanged += new System.EventHandler(this.nomDeBapteme_TextChanged);
            // 
            // sexe
            // 
            this.sexe.FormattingEnabled = true;
            this.sexe.Location = new System.Drawing.Point(75, 156);
            this.sexe.Name = "sexe";
            this.sexe.Size = new System.Drawing.Size(132, 17);
            this.sexe.TabIndex = 3;
            // 
            // dateDeNaissance
            // 
            this.dateDeNaissance.Location = new System.Drawing.Point(76, 179);
            this.dateDeNaissance.Name = "dateDeNaissance";
            this.dateDeNaissance.Size = new System.Drawing.Size(133, 20);
            this.dateDeNaissance.TabIndex = 4;
            this.dateDeNaissance.Text = "Date de naissance";
            this.dateDeNaissance.TextChanged += new System.EventHandler(this.dateDeNaissance_TextChanged);
            // 
            // btnValiderAjoutAnimal
            // 
            this.btnValiderAjoutAnimal.Location = new System.Drawing.Point(59, 220);
            this.btnValiderAjoutAnimal.Name = "btnValiderAjoutAnimal";
            this.btnValiderAjoutAnimal.Size = new System.Drawing.Size(150, 30);
            this.btnValiderAjoutAnimal.TabIndex = 5;
            this.btnValiderAjoutAnimal.Text = "Ajouter";
            this.btnValiderAjoutAnimal.UseVisualStyleBackColor = true;
            this.btnValiderAjoutAnimal.Click += new System.EventHandler(this.btnValiderAjoutAnimal_Click);
            // 
            // frmAnimalAjouter
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnValiderAjoutAnimal);
            this.Controls.Add(this.dateDeNaissance);
            this.Controls.Add(this.sexe);
            this.Controls.Add(this.nomDeBapteme);
            this.Controls.Add(this.espece);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmAnimalAjouter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void dateDeNaissance_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomDeBapteme_TextChanged(object sender, EventArgs e)
        {

        }

        private void espece_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sexe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnValiderAjoutAnimal_Click(object sender, EventArgs e)
        {
            string[] message = new String[1];

            message[0] = espece.Text;
            message[1] = nomDeBapteme.Text;
            message[2] = dateDeNaissance.Text;
            message[3] = sexe.Text;
            leControleur.afficheEcran(message, "validationAjoutAnimal");
            Close();

        }

        
    }
}
