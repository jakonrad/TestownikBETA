namespace Testownik
{
    partial class StartPage
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
            this.Add_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Resolve_button = new System.Windows.Forms.Button();
            this.Browse_button = new System.Windows.Forms.Button();
            this.Quit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_button
            // 
            this.Add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Add_button.Location = new System.Drawing.Point(76, 87);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(305, 40);
            this.Add_button.TabIndex = 0;
            this.Add_button.Text = "Stwórz nowy test";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Witaj w programie Testownik!";
            // 
            // Resolve_button
            // 
            this.Resolve_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Resolve_button.Location = new System.Drawing.Point(76, 156);
            this.Resolve_button.Name = "Resolve_button";
            this.Resolve_button.Size = new System.Drawing.Size(305, 40);
            this.Resolve_button.TabIndex = 2;
            this.Resolve_button.Text = "Rozwiąż test";
            this.Resolve_button.UseVisualStyleBackColor = true;
            // 
            // Browse_button
            // 
            this.Browse_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Browse_button.Location = new System.Drawing.Point(76, 227);
            this.Browse_button.Name = "Browse_button";
            this.Browse_button.Size = new System.Drawing.Size(305, 40);
            this.Browse_button.TabIndex = 3;
            this.Browse_button.Text = "Przeglądaj";
            this.Browse_button.UseVisualStyleBackColor = true;
            // 
            // Quit_button
            // 
            this.Quit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Quit_button.Location = new System.Drawing.Point(76, 355);
            this.Quit_button.Name = "Quit_button";
            this.Quit_button.Size = new System.Drawing.Size(305, 40);
            this.Quit_button.TabIndex = 4;
            this.Quit_button.Text = "Wyjście";
            this.Quit_button.UseVisualStyleBackColor = true;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 455);
            this.Controls.Add(this.Quit_button);
            this.Controls.Add(this.Browse_button);
            this.Controls.Add(this.Resolve_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add_button);
            this.Name = "StartPage";
            this.Text = "Testownik";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Resolve_button;
        private System.Windows.Forms.Button Browse_button;
        private System.Windows.Forms.Button Quit_button;
    }
}

