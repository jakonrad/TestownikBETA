namespace Testownik
{
    partial class AddingPanel
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
            this.Name_of_quiz_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Question_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.A_textbox = new System.Windows.Forms.TextBox();
            this.B_textbox = new System.Windows.Forms.TextBox();
            this.C_textbox = new System.Windows.Forms.TextBox();
            this.D_textbox = new System.Windows.Forms.TextBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.A_checkbox = new System.Windows.Forms.CheckBox();
            this.B_checkbox = new System.Windows.Forms.CheckBox();
            this.C_checkbox = new System.Windows.Forms.CheckBox();
            this.D_checkbox = new System.Windows.Forms.CheckBox();
            this.Change_quiz_name_button = new System.Windows.Forms.Button();
            this.Change_name_of_quiz_textbox = new System.Windows.Forms.TextBox();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Return_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa testu:";
            // 
            // Name_of_quiz_label
            // 
            this.Name_of_quiz_label.AutoSize = true;
            this.Name_of_quiz_label.Location = new System.Drawing.Point(89, 13);
            this.Name_of_quiz_label.Name = "Name_of_quiz_label";
            this.Name_of_quiz_label.Size = new System.Drawing.Size(35, 13);
            this.Name_of_quiz_label.TabIndex = 1;
            this.Name_of_quiz_label.Text = "label2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(552, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 342);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pytanie:";
            // 
            // Question_textbox
            // 
            this.Question_textbox.Location = new System.Drawing.Point(67, 41);
            this.Question_textbox.Name = "Question_textbox";
            this.Question_textbox.Size = new System.Drawing.Size(393, 20);
            this.Question_textbox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Odpowiedź A:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Odpowiedź B:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Odpowiedź C:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Odpowiedź D:";
            // 
            // A_textbox
            // 
            this.A_textbox.Location = new System.Drawing.Point(148, 89);
            this.A_textbox.Name = "A_textbox";
            this.A_textbox.Size = new System.Drawing.Size(312, 20);
            this.A_textbox.TabIndex = 9;
            // 
            // B_textbox
            // 
            this.B_textbox.Location = new System.Drawing.Point(148, 143);
            this.B_textbox.Name = "B_textbox";
            this.B_textbox.Size = new System.Drawing.Size(312, 20);
            this.B_textbox.TabIndex = 10;
            // 
            // C_textbox
            // 
            this.C_textbox.Location = new System.Drawing.Point(148, 191);
            this.C_textbox.Name = "C_textbox";
            this.C_textbox.Size = new System.Drawing.Size(312, 20);
            this.C_textbox.TabIndex = 11;
            // 
            // D_textbox
            // 
            this.D_textbox.Location = new System.Drawing.Point(148, 241);
            this.D_textbox.Name = "D_textbox";
            this.D_textbox.Size = new System.Drawing.Size(312, 20);
            this.D_textbox.TabIndex = 12;
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(448, 279);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(93, 52);
            this.Add_button.TabIndex = 13;
            this.Add_button.Text = "Dodaj";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(318, 279);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(93, 52);
            this.Clear_button.TabIndex = 14;
            this.Clear_button.Text = "Wyczyść pola";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // A_checkbox
            // 
            this.A_checkbox.AutoSize = true;
            this.A_checkbox.Location = new System.Drawing.Point(466, 89);
            this.A_checkbox.Name = "A_checkbox";
            this.A_checkbox.Size = new System.Drawing.Size(82, 17);
            this.A_checkbox.TabIndex = 16;
            this.A_checkbox.Text = "Prawidłowa";
            this.A_checkbox.UseVisualStyleBackColor = true;
            // 
            // B_checkbox
            // 
            this.B_checkbox.AutoSize = true;
            this.B_checkbox.Location = new System.Drawing.Point(466, 145);
            this.B_checkbox.Name = "B_checkbox";
            this.B_checkbox.Size = new System.Drawing.Size(82, 17);
            this.B_checkbox.TabIndex = 17;
            this.B_checkbox.Text = "Prawidłowa";
            this.B_checkbox.UseVisualStyleBackColor = true;
            // 
            // C_checkbox
            // 
            this.C_checkbox.AutoSize = true;
            this.C_checkbox.Location = new System.Drawing.Point(466, 193);
            this.C_checkbox.Name = "C_checkbox";
            this.C_checkbox.Size = new System.Drawing.Size(82, 17);
            this.C_checkbox.TabIndex = 18;
            this.C_checkbox.Text = "Prawidłowa";
            this.C_checkbox.UseVisualStyleBackColor = true;
            // 
            // D_checkbox
            // 
            this.D_checkbox.AutoSize = true;
            this.D_checkbox.Location = new System.Drawing.Point(466, 243);
            this.D_checkbox.Name = "D_checkbox";
            this.D_checkbox.Size = new System.Drawing.Size(82, 17);
            this.D_checkbox.TabIndex = 19;
            this.D_checkbox.Text = "Prawidłowa";
            this.D_checkbox.UseVisualStyleBackColor = true;
            // 
            // Change_quiz_name_button
            // 
            this.Change_quiz_name_button.Location = new System.Drawing.Point(425, 6);
            this.Change_quiz_name_button.Name = "Change_quiz_name_button";
            this.Change_quiz_name_button.Size = new System.Drawing.Size(121, 26);
            this.Change_quiz_name_button.TabIndex = 20;
            this.Change_quiz_name_button.Text = "Zmień nazwę testu";
            this.Change_quiz_name_button.UseVisualStyleBackColor = true;
            this.Change_quiz_name_button.Click += new System.EventHandler(this.Change_quiz_name_button_Click);
            // 
            // Change_name_of_quiz_textbox
            // 
            this.Change_name_of_quiz_textbox.Location = new System.Drawing.Point(92, 10);
            this.Change_name_of_quiz_textbox.MaxLength = 40;
            this.Change_name_of_quiz_textbox.Name = "Change_name_of_quiz_textbox";
            this.Change_name_of_quiz_textbox.Size = new System.Drawing.Size(245, 20);
            this.Change_name_of_quiz_textbox.TabIndex = 21;
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(369, 6);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(50, 26);
            this.Cancel_button.TabIndex = 22;
            this.Cancel_button.Text = "Anuluj";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Return_button
            // 
            this.Return_button.Location = new System.Drawing.Point(4, 279);
            this.Return_button.Name = "Return_button";
            this.Return_button.Size = new System.Drawing.Size(120, 51);
            this.Return_button.TabIndex = 23;
            this.Return_button.Text = "Wróć do menu głównego";
            this.Return_button.UseVisualStyleBackColor = true;
            this.Return_button.Click += new System.EventHandler(this.Return_button_Click);
            // 
            // AddingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 343);
            this.Controls.Add(this.Return_button);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Change_name_of_quiz_textbox);
            this.Controls.Add(this.Change_quiz_name_button);
            this.Controls.Add(this.D_checkbox);
            this.Controls.Add(this.C_checkbox);
            this.Controls.Add(this.B_checkbox);
            this.Controls.Add(this.A_checkbox);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.D_textbox);
            this.Controls.Add(this.C_textbox);
            this.Controls.Add(this.B_textbox);
            this.Controls.Add(this.A_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Question_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Name_of_quiz_label);
            this.Controls.Add(this.label1);
            this.Name = "AddingPanel";
            this.Text = "Testownik";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddingPanel_FormClosed);
            this.Load += new System.EventHandler(this.AddingPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Name_of_quiz_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Question_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox A_textbox;
        private System.Windows.Forms.TextBox B_textbox;
        private System.Windows.Forms.TextBox C_textbox;
        private System.Windows.Forms.TextBox D_textbox;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.CheckBox A_checkbox;
        private System.Windows.Forms.CheckBox B_checkbox;
        private System.Windows.Forms.CheckBox C_checkbox;
        private System.Windows.Forms.CheckBox D_checkbox;
        private System.Windows.Forms.Button Change_quiz_name_button;
        private System.Windows.Forms.TextBox Change_name_of_quiz_textbox;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Return_button;
    }
}