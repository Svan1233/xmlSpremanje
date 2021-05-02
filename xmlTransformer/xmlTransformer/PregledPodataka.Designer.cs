namespace xmlTransformer
{
    partial class PregledPodataka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PregledPodataka));
            this.btnUcitajDoc = new System.Windows.Forms.Button();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.rtbPregled = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnUcitajDoc
            // 
            this.btnUcitajDoc.Location = new System.Drawing.Point(13, 23);
            this.btnUcitajDoc.Name = "btnUcitajDoc";
            this.btnUcitajDoc.Size = new System.Drawing.Size(107, 23);
            this.btnUcitajDoc.TabIndex = 0;
            this.btnUcitajDoc.Text = "Učitaj dokument";
            this.btnUcitajDoc.UseVisualStyleBackColor = true;
            this.btnUcitajDoc.Click += new System.EventHandler(this.btnUcitajDoc_Click);
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(126, 23);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(107, 23);
            this.btnFiltriraj.TabIndex = 1;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(239, 23);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(107, 23);
            this.btnOdustani.TabIndex = 2;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // rtbPregled
            // 
            this.rtbPregled.Location = new System.Drawing.Point(13, 65);
            this.rtbPregled.Name = "rtbPregled";
            this.rtbPregled.Size = new System.Drawing.Size(333, 314);
            this.rtbPregled.TabIndex = 3;
            this.rtbPregled.Text = "";
            // 
            // PregledPodataka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 426);
            this.Controls.Add(this.rtbPregled);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.btnUcitajDoc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PregledPodataka";
            this.Text = "PregledPodataka";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUcitajDoc;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.RichTextBox rtbPregled;
    }
}