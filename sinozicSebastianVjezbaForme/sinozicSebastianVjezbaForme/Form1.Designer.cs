
namespace sinozicSebastianVjezbaForme
{
    partial class Form1
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
            this.listBoxStudenti = new System.Windows.Forms.ListBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonObrisiStudenta = new System.Windows.Forms.Button();
            this.buttonObrisiSve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxStudenti
            // 
            this.listBoxStudenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBoxStudenti.FormattingEnabled = true;
            this.listBoxStudenti.ItemHeight = 16;
            this.listBoxStudenti.Location = new System.Drawing.Point(12, 49);
            this.listBoxStudenti.Name = "listBoxStudenti";
            this.listBoxStudenti.Size = new System.Drawing.Size(467, 276);
            this.listBoxStudenti.TabIndex = 0;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(89)))), ((int)(((byte)(198)))));
            this.buttonDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDodaj.ForeColor = System.Drawing.Color.White;
            this.buttonDodaj.Location = new System.Drawing.Point(498, 49);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(174, 39);
            this.buttonDodaj.TabIndex = 1;
            this.buttonDodaj.Text = "Dodaj novog studenta";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonObrisiStudenta
            // 
            this.buttonObrisiStudenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(89)))), ((int)(((byte)(198)))));
            this.buttonObrisiStudenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonObrisiStudenta.ForeColor = System.Drawing.Color.White;
            this.buttonObrisiStudenta.Location = new System.Drawing.Point(498, 108);
            this.buttonObrisiStudenta.Name = "buttonObrisiStudenta";
            this.buttonObrisiStudenta.Size = new System.Drawing.Size(174, 39);
            this.buttonObrisiStudenta.TabIndex = 2;
            this.buttonObrisiStudenta.Text = "Obriši studenta";
            this.buttonObrisiStudenta.UseVisualStyleBackColor = false;
            this.buttonObrisiStudenta.Click += new System.EventHandler(this.buttonObrisiStudenta_Click);
            // 
            // buttonObrisiSve
            // 
            this.buttonObrisiSve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(89)))), ((int)(((byte)(198)))));
            this.buttonObrisiSve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonObrisiSve.ForeColor = System.Drawing.Color.White;
            this.buttonObrisiSve.Location = new System.Drawing.Point(498, 286);
            this.buttonObrisiSve.Name = "buttonObrisiSve";
            this.buttonObrisiSve.Size = new System.Drawing.Size(174, 39);
            this.buttonObrisiSve.TabIndex = 3;
            this.buttonObrisiSve.Text = "Obriši sve studente";
            this.buttonObrisiSve.UseVisualStyleBackColor = false;
            this.buttonObrisiSve.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(113)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(693, 355);
            this.Controls.Add(this.buttonObrisiSve);
            this.Controls.Add(this.buttonObrisiStudenta);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.listBoxStudenti);
            this.Name = "Form1";
            this.Text = "FormStudenti";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxStudenti;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonObrisiStudenta;
        private System.Windows.Forms.Button buttonObrisiSve;
    }
}

