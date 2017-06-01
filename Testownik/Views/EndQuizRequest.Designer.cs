namespace Testownik.Views
{
    partial class EndQuizRequest
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
            this.Yes_button = new System.Windows.Forms.Button();
            this.No_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(26, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Czy na pewno chcesz zakończyć test?";
            // 
            // Yes_button
            // 
            this.Yes_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Yes_button.Location = new System.Drawing.Point(31, 145);
            this.Yes_button.Name = "Yes_button";
            this.Yes_button.Size = new System.Drawing.Size(133, 76);
            this.Yes_button.TabIndex = 1;
            this.Yes_button.Text = "Tak";
            this.Yes_button.UseVisualStyleBackColor = true;
            this.Yes_button.Click += new System.EventHandler(this.Yes_button_Click);
            // 
            // No_button
            // 
            this.No_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.No_button.Location = new System.Drawing.Point(284, 145);
            this.No_button.Name = "No_button";
            this.No_button.Size = new System.Drawing.Size(133, 76);
            this.No_button.TabIndex = 2;
            this.No_button.Text = "Nie";
            this.No_button.UseVisualStyleBackColor = true;
            this.No_button.Click += new System.EventHandler(this.No_button_Click);
            // 
            // EndQuizRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 259);
            this.Controls.Add(this.No_button);
            this.Controls.Add(this.Yes_button);
            this.Controls.Add(this.label1);
            this.Name = "EndQuizRequest";
            this.Text = "EndQuizRequest";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EndQuizRequest_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Yes_button;
        private System.Windows.Forms.Button No_button;
    }
}