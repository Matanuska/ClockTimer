namespace ClockTimer
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Digital-7", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 119);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Set to Alaska Timezone";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "HH:mm:ss",
            "HH:mm:s",
            "HH:mm",
            "HH:m:ss",
            "HH:m:s",
            "HH:m",
            "HH:ss",
            "HH:s",
            "HH",
            "H:mm:ss",
            "H:mm:s",
            "H:mm",
            "H:m:ss",
            "H:m:s",
            "H:m",
            "H:ss",
            "H:s",
            "hh:mm:ss tt",
            "hh:mm:ss t",
            "hh:mm:ss",
            "hh:mm:s tt",
            "hh:mm:s t",
            "hh:mm:s",
            "hh:mm tt",
            "hh:mm t",
            "hh:mm",
            "hh:m:ss tt",
            "hh:m:ss t",
            "hh:m:ss",
            "hh:m:s tt",
            "hh:m:s t",
            "hh:m:s",
            "hh:m tt",
            "hh:m t",
            "hh:m",
            "hh:ss tt",
            "hh:ss t",
            "hh:ss",
            "hh:s tt",
            "hh:s t",
            "hh:s",
            "hh tt",
            "hh t",
            "hh",
            "h:mm:ss tt",
            "h:mm:ss t",
            "h:mm:ss",
            "h:mm:s tt",
            "h:mm:s t",
            "h:mm:s",
            "h:mm tt",
            "h:mm t",
            "h:mm",
            "h:m:ss tt",
            "h:m:ss t",
            "h:m:ss",
            "h:m:s tt",
            "h:m:s t",
            "h:m:s",
            "h:m tt",
            "h:m t",
            "h:m",
            "h:ss tt",
            "h:ss t",
            "h:ss",
            "h:s tt",
            "h:s t",
            "h:s",
            "h tt",
            "h t",
            "mm:ss tt",
            "mm:ss t",
            "mm:ss",
            "mm:s tt",
            "mm:s t",
            "mm:s",
            "mm tt",
            "mm t",
            "mm",
            "m:ss tt",
            "m:ss t",
            "m:ss",
            "m:s tt",
            "m:s t",
            "m:s",
            "m tt",
            "m t",
            "ss tt",
            "ss t",
            "ss",
            "s tt",
            "s t"});
            this.comboBox1.Location = new System.Drawing.Point(26, 171);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(255, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 209);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

