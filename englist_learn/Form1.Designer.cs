namespace englist_learn
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
            this.listbox_group = new System.Windows.Forms.ListBox();
            this.checkbox_random = new System.Windows.Forms.CheckBox();
            this.checkbox_tr_en = new System.Windows.Forms.CheckBox();
            this.textbox_answer = new System.Windows.Forms.TextBox();
            this.label_word = new System.Windows.Forms.Label();
            this.button_showanswer = new System.Windows.Forms.Button();
            this.label_showedanswer = new System.Windows.Forms.Label();
            this.label_count = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelWrong = new System.Windows.Forms.Label();
            this.labellastwronganswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listbox_group
            // 
            this.listbox_group.Dock = System.Windows.Forms.DockStyle.Left;
            this.listbox_group.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listbox_group.FormattingEnabled = true;
            this.listbox_group.ItemHeight = 23;
            this.listbox_group.Location = new System.Drawing.Point(0, 0);
            this.listbox_group.Name = "listbox_group";
            this.listbox_group.ScrollAlwaysVisible = true;
            this.listbox_group.Size = new System.Drawing.Size(218, 419);
            this.listbox_group.TabIndex = 0;
            this.listbox_group.SelectedIndexChanged += new System.EventHandler(this.listbox_group_SelectedIndexChanged);
            // 
            // checkbox_random
            // 
            this.checkbox_random.AutoSize = true;
            this.checkbox_random.Checked = true;
            this.checkbox_random.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_random.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkbox_random.Location = new System.Drawing.Point(554, 18);
            this.checkbox_random.Name = "checkbox_random";
            this.checkbox_random.Size = new System.Drawing.Size(105, 26);
            this.checkbox_random.TabIndex = 1;
            this.checkbox_random.Text = "Rastgele";
            this.checkbox_random.UseVisualStyleBackColor = true;
            this.checkbox_random.CheckedChanged += new System.EventHandler(this.checkbox_random_CheckedChanged);
            // 
            // checkbox_tr_en
            // 
            this.checkbox_tr_en.AutoSize = true;
            this.checkbox_tr_en.Font = new System.Drawing.Font("Gill Sans MT", 14.25F);
            this.checkbox_tr_en.Location = new System.Drawing.Point(437, 16);
            this.checkbox_tr_en.Name = "checkbox_tr_en";
            this.checkbox_tr_en.Size = new System.Drawing.Size(83, 31);
            this.checkbox_tr_en.TabIndex = 2;
            this.checkbox_tr_en.Text = "TR/EN";
            this.checkbox_tr_en.UseVisualStyleBackColor = true;
            this.checkbox_tr_en.CheckedChanged += new System.EventHandler(this.checkbox_tr_en_CheckedChanged);
            // 
            // textbox_answer
            // 
            this.textbox_answer.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textbox_answer.Font = new System.Drawing.Font("Gill Sans MT", 18F);
            this.textbox_answer.Location = new System.Drawing.Point(221, 179);
            this.textbox_answer.Margin = new System.Windows.Forms.Padding(0);
            this.textbox_answer.MinimumSize = new System.Drawing.Size(250, 40);
            this.textbox_answer.Name = "textbox_answer";
            this.textbox_answer.Size = new System.Drawing.Size(434, 40);
            this.textbox_answer.TabIndex = 3;
            this.textbox_answer.Text = "cevabınız";
            this.textbox_answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_answer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_answer_KeyDown);
            this.textbox_answer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textbox_answer_KeyUp);
            // 
            // label_word
            // 
            this.label_word.AutoSize = true;
            this.label_word.Font = new System.Drawing.Font("Gill Sans MT", 25F);
            this.label_word.Location = new System.Drawing.Point(221, 132);
            this.label_word.Name = "label_word";
            this.label_word.Size = new System.Drawing.Size(41, 47);
            this.label_word.TabIndex = 4;
            this.label_word.Text = "...";
            // 
            // button_showanswer
            // 
            this.button_showanswer.Font = new System.Drawing.Font("Gill Sans MT", 13F);
            this.button_showanswer.Location = new System.Drawing.Point(221, 222);
            this.button_showanswer.Name = "button_showanswer";
            this.button_showanswer.Size = new System.Drawing.Size(283, 50);
            this.button_showanswer.TabIndex = 5;
            this.button_showanswer.Text = "Cevabı Göster";
            this.button_showanswer.UseVisualStyleBackColor = true;
            this.button_showanswer.Click += new System.EventHandler(this.button_showanswer_Click);
            // 
            // label_showedanswer
            // 
            this.label_showedanswer.AutoSize = true;
            this.label_showedanswer.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_showedanswer.Location = new System.Drawing.Point(224, 275);
            this.label_showedanswer.Name = "label_showedanswer";
            this.label_showedanswer.Size = new System.Drawing.Size(91, 27);
            this.label_showedanswer.TabIndex = 6;
            this.label_showedanswer.Text = "Answer";
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_count.Location = new System.Drawing.Point(510, 233);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(45, 27);
            this.label_count.TabIndex = 7;
            this.label_count.Text = "0/0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Gill Sans MT", 13F);
            this.button1.Location = new System.Drawing.Point(224, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelWrong
            // 
            this.labelWrong.AutoSize = true;
            this.labelWrong.Font = new System.Drawing.Font("Gill Sans MT", 15F);
            this.labelWrong.ForeColor = System.Drawing.Color.Maroon;
            this.labelWrong.Location = new System.Drawing.Point(224, 51);
            this.labelWrong.Name = "labelWrong";
            this.labelWrong.Size = new System.Drawing.Size(169, 29);
            this.labelWrong.TabIndex = 9;
            this.labelWrong.Text = "AÇILAN CEVAP: 0";
            // 
            // labellastwronganswer
            // 
            this.labellastwronganswer.AutoSize = true;
            this.labellastwronganswer.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellastwronganswer.ForeColor = System.Drawing.Color.Maroon;
            this.labellastwronganswer.Location = new System.Drawing.Point(224, 80);
            this.labellastwronganswer.Name = "labellastwronganswer";
            this.labellastwronganswer.Size = new System.Drawing.Size(273, 29);
            this.labellastwronganswer.TabIndex = 10;
            this.labellastwronganswer.Text = "SON İŞLEM AÇILAN CEVAP: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 419);
            this.Controls.Add(this.labellastwronganswer);
            this.Controls.Add(this.labelWrong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.label_showedanswer);
            this.Controls.Add(this.button_showanswer);
            this.Controls.Add(this.label_word);
            this.Controls.Add(this.textbox_answer);
            this.Controls.Add(this.checkbox_tr_en);
            this.Controls.Add(this.checkbox_random);
            this.Controls.Add(this.listbox_group);
            this.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listbox_group;
        private System.Windows.Forms.CheckBox checkbox_random;
        private System.Windows.Forms.CheckBox checkbox_tr_en;
        private System.Windows.Forms.TextBox textbox_answer;
        private System.Windows.Forms.Label label_word;
        private System.Windows.Forms.Button button_showanswer;
        private System.Windows.Forms.Label label_showedanswer;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelWrong;
        private System.Windows.Forms.Label labellastwronganswer;
    }
}

