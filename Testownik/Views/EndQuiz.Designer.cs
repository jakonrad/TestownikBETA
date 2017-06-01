namespace Testownik.Views
{
    partial class EndQuiz
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Total_pts = new System.Windows.Forms.Label();
            this.Max_pts = new System.Windows.Forms.Label();
            this.Ok_button = new System.Windows.Forms.Button();
            this.Return_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zdobyłeś";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "punktów na";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "możliwych";
            // 
            // Total_pts
            // 
            this.Total_pts.AutoSize = true;
            this.Total_pts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Total_pts.Location = new System.Drawing.Point(64, 36);
            this.Total_pts.Name = "Total_pts";
            this.Total_pts.Size = new System.Drawing.Size(51, 16);
            this.Total_pts.TabIndex = 3;
            this.Total_pts.Text = "label4";
            // 
            // Max_pts
            // 
            this.Max_pts.AutoSize = true;
            this.Max_pts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Max_pts.Location = new System.Drawing.Point(190, 36);
            this.Max_pts.Name = "Max_pts";
            this.Max_pts.Size = new System.Drawing.Size(51, 16);
            this.Max_pts.TabIndex = 4;
            this.Max_pts.Text = "label5";
            // 
            // Ok_button
            // 
            this.Ok_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ok_button.Location = new System.Drawing.Point(10, 79);
            this.Ok_button.Name = "Ok_button";
            this.Ok_button.Size = new System.Drawing.Size(105, 65);
            this.Ok_button.TabIndex = 5;
            this.Ok_button.Text = "OK";
            this.Ok_button.UseVisualStyleBackColor = true;
            this.Ok_button.Click += new System.EventHandler(this.Ok_button_Click);
            // 
            // Return_button
            // 
            this.Return_button.Location = new System.Drawing.Point(215, 79);
            this.Return_button.Name = "Return_button";
            this.Return_button.Size = new System.Drawing.Size(105, 65);
            this.Return_button.TabIndex = 6;
            this.Return_button.Text = "Wróć do menu głównego";
            this.Return_button.UseVisualStyleBackColor = true;
            this.Return_button.Click += new System.EventHandler(this.Return_button_Click);
            // 
            // EndQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 170);
            this.Controls.Add(this.Return_button);
            this.Controls.Add(this.Ok_button);
            this.Controls.Add(this.Max_pts);
            this.Controls.Add(this.Total_pts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EndQuiz";
            this.Text = "EndQuiz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EndQuiz_FormClosed);
            this.Load += new System.EventHandler(this.EndQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Total_pts;
        private System.Windows.Forms.Label Max_pts;
        private System.Windows.Forms.Button Ok_button;
        private System.Windows.Forms.Button Return_button;
    }
}