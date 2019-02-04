namespace Ksu.Cis300.TravelingSalesperson
{
    partial class UserInterface
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
            this.uxOpenButton = new System.Windows.Forms.Button();
            this.uxTourLabel = new System.Windows.Forms.Label();
            this.uxTour = new System.Windows.Forms.TextBox();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // uxOpenButton
            // 
            this.uxOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOpenButton.Location = new System.Drawing.Point(12, 24);
            this.uxOpenButton.Name = "uxOpenButton";
            this.uxOpenButton.Size = new System.Drawing.Size(256, 47);
            this.uxOpenButton.TabIndex = 0;
            this.uxOpenButton.Text = "Load Graph";
            this.uxOpenButton.UseVisualStyleBackColor = true;
            this.uxOpenButton.Click += new System.EventHandler(this.uxOpenButton_Click);
            // 
            // uxTourLabel
            // 
            this.uxTourLabel.AutoSize = true;
            this.uxTourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTourLabel.Location = new System.Drawing.Point(12, 74);
            this.uxTourLabel.Name = "uxTourLabel";
            this.uxTourLabel.Size = new System.Drawing.Size(59, 25);
            this.uxTourLabel.TabIndex = 1;
            this.uxTourLabel.Text = "Tour:";
            // 
            // uxTour
            // 
            this.uxTour.AcceptsReturn = true;
            this.uxTour.Location = new System.Drawing.Point(14, 106);
            this.uxTour.Multiline = true;
            this.uxTour.Name = "uxTour";
            this.uxTour.ReadOnly = true;
            this.uxTour.Size = new System.Drawing.Size(253, 142);
            this.uxTour.TabIndex = 2;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uxTour);
            this.Controls.Add(this.uxTourLabel);
            this.Controls.Add(this.uxOpenButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "UserInterface";
            this.Text = "Traveling Salesperson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxOpenButton;
        private System.Windows.Forms.Label uxTourLabel;
        private System.Windows.Forms.TextBox uxTour;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
    }
}

