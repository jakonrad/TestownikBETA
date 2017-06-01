namespace Testownik.Views
{
    partial class GetQuiz
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
            this.Choose_quiz_combobox = new System.Windows.Forms.ComboBox();
            this.Start_quiz_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz test który chcesz rozwiązać:";
            // 
            // Choose_quiz_combobox
            // 
            this.Choose_quiz_combobox.FormattingEnabled = true;
            this.Choose_quiz_combobox.Location = new System.Drawing.Point(38, 51);
            this.Choose_quiz_combobox.Name = "Choose_quiz_combobox";
            this.Choose_quiz_combobox.Size = new System.Drawing.Size(363, 21);
            this.Choose_quiz_combobox.TabIndex = 1;
            this.Choose_quiz_combobox.SelectedIndexChanged += new System.EventHandler(this.Choose_quiz_combobox_SelectedIndexChanged);
            // 
            // Start_quiz_button
            // 
            this.Start_quiz_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Start_quiz_button.Location = new System.Drawing.Point(273, 114);
            this.Start_quiz_button.Name = "Start_quiz_button";
            this.Start_quiz_button.Size = new System.Drawing.Size(128, 81);
            this.Start_quiz_button.TabIndex = 2;
            this.Start_quiz_button.Text = "Rozpocznij test!";
            this.Start_quiz_button.UseVisualStyleBackColor = true;
            this.Start_quiz_button.Click += new System.EventHandler(this.Start_quiz_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Back_button.Location = new System.Drawing.Point(38, 114);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(128, 81);
            this.Back_button.TabIndex = 3;
            this.Back_button.Text = "Wróć";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // GetQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 258);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Start_quiz_button);
            this.Controls.Add(this.Choose_quiz_combobox);
            this.Controls.Add(this.label1);
            this.Name = "GetQuiz";
            this.Text = "GetQuiz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GetQuiz_FormClosed);
            this.Load += new System.EventHandler(this.GetQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Choose_quiz_combobox;
        private System.Windows.Forms.Button Start_quiz_button;
        private System.Windows.Forms.Button Back_button;
    }
}