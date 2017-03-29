namespace Testownik
{
    partial class NameOfQuiz
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
            this.Name_of_quiz_textbox = new System.Windows.Forms.TextBox();
            this.Ok_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Name_of_quiz_textbox
            // 
            this.Name_of_quiz_textbox.Location = new System.Drawing.Point(16, 47);
            this.Name_of_quiz_textbox.Name = "Name_of_quiz_textbox";
            this.Name_of_quiz_textbox.Size = new System.Drawing.Size(349, 20);
            this.Name_of_quiz_textbox.TabIndex = 0;
            // 
            // Ok_button
            // 
            this.Ok_button.Location = new System.Drawing.Point(231, 97);
            this.Ok_button.Name = "Ok_button";
            this.Ok_button.Size = new System.Drawing.Size(134, 55);
            this.Ok_button.TabIndex = 1;
            this.Ok_button.Text = "OK";
            this.Ok_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wpisz nazwę swojego nowego testu:";
            // 
            // Name_of_quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 164);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ok_button);
            this.Controls.Add(this.Name_of_quiz_textbox);
            this.Name = "Name_of_quiz";
            this.Text = "Wpisz nazwę testu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_of_quiz_textbox;
        private System.Windows.Forms.Button Ok_button;
        private System.Windows.Forms.Label label1;
    }
}