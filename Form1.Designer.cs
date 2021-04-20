
namespace JavaInstaller
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.installButton = new System.Windows.Forms.Button();
            this.ask = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // installButton
            // 
            this.installButton.Enabled = false;
            this.installButton.Location = new System.Drawing.Point(100, 85);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(180, 23);
            this.installButton.TabIndex = 0;
            this.installButton.Text = "Java Installieren";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // ask
            // 
            this.ask.AutoSize = true;
            this.ask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ask.Location = new System.Drawing.Point(3, 9);
            this.ask.Name = "ask";
            this.ask.Size = new System.Drawing.Size(380, 34);
            this.ask.TabIndex = 1;
            this.ask.Text = "Möchten Sie das Java Runtime Environment installieren?\nDieses wird benötigt um di" +
    "e Stundenplan App zu benutzen.";
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.Location = new System.Drawing.Point(-30, 62);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(451, 13);
            this.line.TabIndex = 2;
            this.line.Text = "__________________________________________________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(3, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = ".";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 116);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.line);
            this.Controls.Add(this.ask);
            this.Controls.Add(this.installButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 155);
            this.MinimumSize = new System.Drawing.Size(400, 155);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JRE Installer | v1.0.0 - [JAVA v1.15]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.Label ask;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Label label1;
    }
}

