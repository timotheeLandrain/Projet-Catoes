namespace WindowsFormsApplication1.frm
{
    partial class frmEspeceAfficher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEspeceAfficher));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxEspece = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 79);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxEspece
            // 
            this.comboBoxEspece.FormattingEnabled = true;
            this.comboBoxEspece.Location = new System.Drawing.Point(18, 125);
            this.comboBoxEspece.Name = "comboBoxEspece";
            this.comboBoxEspece.Size = new System.Drawing.Size(252, 21);
            this.comboBoxEspece.TabIndex = 1;
            this.comboBoxEspece.SelectedIndexChanged += new System.EventHandler(this.comboBoxEspece_SelectedIndexChanged);
            // 
            // frmEspeceAfficher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.comboBoxEspece);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmEspeceAfficher";
            this.Text = "frmEspeceAfficher";
            this.Load += new System.EventHandler(this.frmEspeceAfficher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxEspece;
    }
}