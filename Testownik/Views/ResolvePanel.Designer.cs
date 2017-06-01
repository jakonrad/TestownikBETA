namespace Testownik.Views
{
    partial class ResolvePanel
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Number_of_question = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Amount_of_question = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Name_of_quiz_label = new System.Windows.Forms.Label();
            this.Question_name_label = new System.Windows.Forms.Label();
            this.A_button = new System.Windows.Forms.Button();
            this.B_button = new System.Windows.Forms.Button();
            this.C_button = new System.Windows.Forms.Button();
            this.D_button = new System.Windows.Forms.Button();
            this.Next_question_button = new System.Windows.Forms.Button();
            this.choose_question_flowlayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.Time_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.End_quiz_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Czas trwania:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pytanie:";
            // 
            // Number_of_question
            // 
            this.Number_of_question.AutoSize = true;
            this.Number_of_question.Location = new System.Drawing.Point(282, 13);
            this.Number_of_question.Name = "Number_of_question";
            this.Number_of_question.Size = new System.Drawing.Size(13, 13);
            this.Number_of_question.TabIndex = 2;
            this.Number_of_question.Text = "n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "/";
            // 
            // Amount_of_question
            // 
            this.Amount_of_question.AutoSize = true;
            this.Amount_of_question.Location = new System.Drawing.Point(320, 13);
            this.Amount_of_question.Name = "Amount_of_question";
            this.Amount_of_question.Size = new System.Drawing.Size(10, 13);
            this.Amount_of_question.TabIndex = 4;
            this.Amount_of_question.Text = "t";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nazwa testu:";
            // 
            // Name_of_quiz_label
            // 
            this.Name_of_quiz_label.AutoSize = true;
            this.Name_of_quiz_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name_of_quiz_label.Location = new System.Drawing.Point(571, 13);
            this.Name_of_quiz_label.Name = "Name_of_quiz_label";
            this.Name_of_quiz_label.Size = new System.Drawing.Size(33, 16);
            this.Name_of_quiz_label.TabIndex = 6;
            this.Name_of_quiz_label.Text = "test";
            // 
            // Question_name_label
            // 
            this.Question_name_label.AutoSize = true;
            this.Question_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Question_name_label.Location = new System.Drawing.Point(12, 54);
            this.Question_name_label.Name = "Question_name_label";
            this.Question_name_label.Size = new System.Drawing.Size(155, 25);
            this.Question_name_label.TabIndex = 7;
            this.Question_name_label.Text = "Treść pytania";
            // 
            // A_button
            // 
            this.A_button.Location = new System.Drawing.Point(17, 121);
            this.A_button.Name = "A_button";
            this.A_button.Size = new System.Drawing.Size(278, 100);
            this.A_button.TabIndex = 8;
            this.A_button.Text = "button1";
            this.A_button.UseVisualStyleBackColor = true;
            this.A_button.Click += new System.EventHandler(this.A_button_Click);
            // 
            // B_button
            // 
            this.B_button.Location = new System.Drawing.Point(328, 121);
            this.B_button.Name = "B_button";
            this.B_button.Size = new System.Drawing.Size(278, 100);
            this.B_button.TabIndex = 9;
            this.B_button.Text = "button2";
            this.B_button.UseVisualStyleBackColor = true;
            this.B_button.Click += new System.EventHandler(this.B_button_Click);
            // 
            // C_button
            // 
            this.C_button.Location = new System.Drawing.Point(17, 236);
            this.C_button.Name = "C_button";
            this.C_button.Size = new System.Drawing.Size(278, 100);
            this.C_button.TabIndex = 10;
            this.C_button.Text = "button3";
            this.C_button.UseVisualStyleBackColor = true;
            this.C_button.Click += new System.EventHandler(this.C_button_Click);
            // 
            // D_button
            // 
            this.D_button.Location = new System.Drawing.Point(328, 236);
            this.D_button.Name = "D_button";
            this.D_button.Size = new System.Drawing.Size(278, 100);
            this.D_button.TabIndex = 11;
            this.D_button.Text = "button4";
            this.D_button.UseVisualStyleBackColor = true;
            this.D_button.Click += new System.EventHandler(this.D_button_Click);
            // 
            // Next_question_button
            // 
            this.Next_question_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Next_question_button.Location = new System.Drawing.Point(639, 368);
            this.Next_question_button.Name = "Next_question_button";
            this.Next_question_button.Size = new System.Drawing.Size(132, 82);
            this.Next_question_button.TabIndex = 12;
            this.Next_question_button.Text = "Kolejne pytanie";
            this.Next_question_button.UseVisualStyleBackColor = true;
            this.Next_question_button.Click += new System.EventHandler(this.Next_question_button_Click);
            // 
            // choose_question_flowlayoutPanel
            // 
            this.choose_question_flowlayoutPanel.Location = new System.Drawing.Point(16, 368);
            this.choose_question_flowlayoutPanel.Name = "choose_question_flowlayoutPanel";
            this.choose_question_flowlayoutPanel.Size = new System.Drawing.Size(590, 82);
            this.choose_question_flowlayoutPanel.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Szybka nawigacja po pytaniach:";
            // 
            // Time_label
            // 
            this.Time_label.AutoSize = true;
            this.Time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Time_label.Location = new System.Drawing.Point(90, 13);
            this.Time_label.Name = "Time_label";
            this.Time_label.Size = new System.Drawing.Size(51, 16);
            this.Time_label.TabIndex = 15;
            this.Time_label.Text = "label3";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // End_quiz_button
            // 
            this.End_quiz_button.Location = new System.Drawing.Point(639, 320);
            this.End_quiz_button.Name = "End_quiz_button";
            this.End_quiz_button.Size = new System.Drawing.Size(132, 45);
            this.End_quiz_button.TabIndex = 16;
            this.End_quiz_button.Text = "Zakończ test";
            this.End_quiz_button.UseVisualStyleBackColor = true;
            this.End_quiz_button.Click += new System.EventHandler(this.End_quiz_button_Click);
            // 
            // ResolvePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 462);
            this.Controls.Add(this.End_quiz_button);
            this.Controls.Add(this.Time_label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.choose_question_flowlayoutPanel);
            this.Controls.Add(this.Next_question_button);
            this.Controls.Add(this.D_button);
            this.Controls.Add(this.C_button);
            this.Controls.Add(this.B_button);
            this.Controls.Add(this.A_button);
            this.Controls.Add(this.Question_name_label);
            this.Controls.Add(this.Name_of_quiz_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Amount_of_question);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Number_of_question);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ResolvePanel";
            this.Text = "ResolvePanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResolvePanel_FormClosed);
            this.Load += new System.EventHandler(this.ResolvePanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Number_of_question;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Amount_of_question;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Name_of_quiz_label;
        private System.Windows.Forms.Label Question_name_label;
        private System.Windows.Forms.Button A_button;
        private System.Windows.Forms.Button B_button;
        private System.Windows.Forms.Button C_button;
        private System.Windows.Forms.Button D_button;
        private System.Windows.Forms.Button Next_question_button;
        private System.Windows.Forms.FlowLayoutPanel choose_question_flowlayoutPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Time_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button End_quiz_button;
    }
}