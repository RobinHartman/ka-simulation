namespace KA_simulation
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
            this.Label_Simulation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_Simulation
            // 
            this.Label_Simulation.AutoSize = true;
            this.Label_Simulation.Location = new System.Drawing.Point(12, 9);
            this.Label_Simulation.Name = "Label_Simulation";
            this.Label_Simulation.Size = new System.Drawing.Size(72, 13);
            this.Label_Simulation.TabIndex = 0;
            this.Label_Simulation.Text = "KA Simulation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Label_Simulation);
            this.Name = "Form1";
            this.Text = "KA Simulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Simulation;
    }
}

