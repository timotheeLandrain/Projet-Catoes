namespace WindowsFormsApplication1.frm
{
    partial class frmEspeceAjouter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEspeceAjouter));
            this.libelleEspece = new System.Windows.Forms.TextBox();
            this.btnValiderAjoutEspece = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // libelleEspece
            // 
            this.libelleEspece.Location = new System.Drawing.Point(80, 127);
            this.libelleEspece.Name = "libelleEspece";
            this.libelleEspece.Size = new System.Drawing.Size(144, 20);
            this.libelleEspece.TabIndex = 0;
            this.libelleEspece.Text = "Libellé de l\'espece";
            this.libelleEspece.TextChanged += new System.EventHandler(this.libelleEspece_TextChanged);
            // 
            // btnValiderAjoutEspece
            // 
            this.btnValiderAjoutEspece.Location = new System.Drawing.Point(96, 210);
            this.btnValiderAjoutEspece.Name = "btnValiderAjoutEspece";
            this.btnValiderAjoutEspece.Size = new System.Drawing.Size(101, 25);
            this.btnValiderAjoutEspece.TabIndex = 1;
            this.btnValiderAjoutEspece.Text = "Ajouter";
            this.btnValiderAjoutEspece.UseVisualStyleBackColor = true;
            this.btnValiderAjoutEspece.Click += new System.EventHandler(this.btnValiderAjoutEspece_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 65);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmEspeceAjouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 262);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnValiderAjoutEspece);
            this.Controls.Add(this.libelleEspece);
            this.Name = "frmEspeceAjouter";
            this.Text = "frmEspeceAjouter";
            this.Load += new System.EventHandler(this.frmEspeceAjouter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox libelleEspece;
        private System.Windows.Forms.Button btnValiderAjoutEspece;
        private System.EventHandler pictureBox1_Click;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}