namespace TotoGUI
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbEredmeny = new System.Windows.Forms.TextBox();
            this.cbKarakterSzam = new System.Windows.Forms.CheckBox();
            this.btnMentes = new System.Windows.Forms.Button();
            this.cbHelytelenKarakter = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kérem a forduló eredményeit [1, 2, X]:";
            // 
            // tbEredmeny
            // 
            this.tbEredmeny.Location = new System.Drawing.Point(24, 56);
            this.tbEredmeny.Name = "tbEredmeny";
            this.tbEredmeny.Size = new System.Drawing.Size(358, 22);
            this.tbEredmeny.TabIndex = 1;
            this.tbEredmeny.Text = "12X12X12X12X12";
            this.tbEredmeny.TextChanged += new System.EventHandler(this.TbEredmeny_TextChanged);
            // 
            // cbKarakterSzam
            // 
            this.cbKarakterSzam.AutoSize = true;
            this.cbKarakterSzam.Enabled = false;
            this.cbKarakterSzam.Location = new System.Drawing.Point(24, 108);
            this.cbKarakterSzam.Name = "cbKarakterSzam";
            this.cbKarakterSzam.Size = new System.Drawing.Size(252, 21);
            this.cbKarakterSzam.TabIndex = 2;
            this.cbKarakterSzam.Text = "Nem megfelelő a karakterek száma";
            this.cbKarakterSzam.UseVisualStyleBackColor = true;
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(24, 185);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(182, 32);
            this.btnMentes.TabIndex = 3;
            this.btnMentes.Text = "Eredmények mentése";
            this.btnMentes.UseVisualStyleBackColor = true;
            // 
            // cbHelytelenKarakter
            // 
            this.cbHelytelenKarakter.AutoSize = true;
            this.cbHelytelenKarakter.Enabled = false;
            this.cbHelytelenKarakter.Location = new System.Drawing.Point(24, 145);
            this.cbHelytelenKarakter.Name = "cbHelytelenKarakter";
            this.cbHelytelenKarakter.Size = new System.Drawing.Size(270, 21);
            this.cbHelytelenKarakter.TabIndex = 2;
            this.cbHelytelenKarakter.Text = "Helytelen karakter az eredményekben";
            this.cbHelytelenKarakter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 239);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.cbHelytelenKarakter);
            this.Controls.Add(this.cbKarakterSzam);
            this.Controls.Add(this.tbEredmeny);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Totó eredmény ellenőrző";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEredmeny;
        private System.Windows.Forms.CheckBox cbKarakterSzam;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.CheckBox cbHelytelenKarakter;
    }
}