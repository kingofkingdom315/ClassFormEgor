namespace ClassFormEgor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtxb = new System.Windows.Forms.RichTextBox();
            this.Add_lenght_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_lenght_txt = new System.Windows.Forms.TextBox();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.Add_full_mass_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Add_elm_but = new System.Windows.Forms.Button();
            this.Add_elm_txt = new System.Windows.Forms.TextBox();
            this.Prod2_but = new System.Windows.Forms.Button();
            this.Prod3_but = new System.Windows.Forms.Button();
            this.Add_full_mass_but = new System.Windows.Forms.Button();
            this.Prod2_txt = new System.Windows.Forms.TextBox();
            this.Prod1_but = new System.Windows.Forms.Button();
            this.Clear_but = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxb
            // 
            this.rtxb.Location = new System.Drawing.Point(381, 12);
            this.rtxb.Name = "rtxb";
            this.rtxb.Size = new System.Drawing.Size(201, 432);
            this.rtxb.TabIndex = 0;
            this.rtxb.Text = "";
            // 
            // Add_lenght_but
            // 
            this.Add_lenght_but.Location = new System.Drawing.Point(12, 71);
            this.Add_lenght_but.Name = "Add_lenght_but";
            this.Add_lenght_but.Size = new System.Drawing.Size(115, 50);
            this.Add_lenght_but.TabIndex = 1;
            this.Add_lenght_but.Text = "Ввести";
            this.Add_lenght_but.UseVisualStyleBackColor = true;
            this.Add_lenght_but.Click += new System.EventHandler(this.Add_lenght_but_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Размер массива:";
            // 
            // Add_lenght_txt
            // 
            this.Add_lenght_txt.Location = new System.Drawing.Point(12, 43);
            this.Add_lenght_txt.Name = "Add_lenght_txt";
            this.Add_lenght_txt.Size = new System.Drawing.Size(125, 22);
            this.Add_lenght_txt.TabIndex = 3;
            this.Add_lenght_txt.Text = "4";
            // 
            // cmb
            // 
            this.cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb.FormattingEnabled = true;
            this.cmb.Location = new System.Drawing.Point(174, 172);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(52, 24);
            this.cmb.TabIndex = 4;
            // 
            // Add_full_mass_txt
            // 
            this.Add_full_mass_txt.Location = new System.Drawing.Point(174, 43);
            this.Add_full_mass_txt.Name = "Add_full_mass_txt";
            this.Add_full_mass_txt.Size = new System.Drawing.Size(152, 22);
            this.Add_full_mass_txt.TabIndex = 5;
            this.Add_full_mass_txt.Text = "2,3:4,5:1,6:2,7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ведите весь массив:\r\n(элементы вводить через \':\') ";
            // 
            // Add_elm_but
            // 
            this.Add_elm_but.Enabled = false;
            this.Add_elm_but.Location = new System.Drawing.Point(12, 172);
            this.Add_elm_but.Name = "Add_elm_but";
            this.Add_elm_but.Size = new System.Drawing.Size(115, 50);
            this.Add_elm_but.TabIndex = 7;
            this.Add_elm_but.Text = "Ввести";
            this.Add_elm_but.UseVisualStyleBackColor = true;
            this.Add_elm_but.Click += new System.EventHandler(this.Add_elm_but_Click);
            // 
            // Add_elm_txt
            // 
            this.Add_elm_txt.Location = new System.Drawing.Point(12, 144);
            this.Add_elm_txt.Name = "Add_elm_txt";
            this.Add_elm_txt.ReadOnly = true;
            this.Add_elm_txt.Size = new System.Drawing.Size(125, 22);
            this.Add_elm_txt.TabIndex = 8;
            // 
            // Prod2_but
            // 
            this.Prod2_but.Enabled = false;
            this.Prod2_but.Location = new System.Drawing.Point(12, 290);
            this.Prod2_but.Name = "Prod2_but";
            this.Prod2_but.Size = new System.Drawing.Size(115, 50);
            this.Prod2_but.TabIndex = 9;
            this.Prod2_but.Text = "Перемножить";
            this.Prod2_but.UseVisualStyleBackColor = true;
            this.Prod2_but.Click += new System.EventHandler(this.Prod2_but_Click);
            // 
            // Prod3_but
            // 
            this.Prod3_but.Enabled = false;
            this.Prod3_but.Location = new System.Drawing.Point(174, 202);
            this.Prod3_but.Name = "Prod3_but";
            this.Prod3_but.Size = new System.Drawing.Size(115, 50);
            this.Prod3_but.TabIndex = 10;
            this.Prod3_but.Text = "Перемножить";
            this.Prod3_but.UseVisualStyleBackColor = true;
            this.Prod3_but.Click += new System.EventHandler(this.Prod3_but_Click);
            // 
            // Add_full_mass_but
            // 
            this.Add_full_mass_but.Location = new System.Drawing.Point(174, 71);
            this.Add_full_mass_but.Name = "Add_full_mass_but";
            this.Add_full_mass_but.Size = new System.Drawing.Size(115, 50);
            this.Add_full_mass_but.TabIndex = 11;
            this.Add_full_mass_but.Text = "Ввести";
            this.Add_full_mass_but.UseVisualStyleBackColor = true;
            this.Add_full_mass_but.Click += new System.EventHandler(this.Aff_full_mass_but_Click);
            // 
            // Prod2_txt
            // 
            this.Prod2_txt.Location = new System.Drawing.Point(12, 262);
            this.Prod2_txt.Name = "Prod2_txt";
            this.Prod2_txt.ReadOnly = true;
            this.Prod2_txt.Size = new System.Drawing.Size(125, 22);
            this.Prod2_txt.TabIndex = 12;
            // 
            // Prod1_but
            // 
            this.Prod1_but.Enabled = false;
            this.Prod1_but.Location = new System.Drawing.Point(12, 364);
            this.Prod1_but.Name = "Prod1_but";
            this.Prod1_but.Size = new System.Drawing.Size(115, 50);
            this.Prod1_but.TabIndex = 13;
            this.Prod1_but.Text = "Перемножить всё";
            this.Prod1_but.UseVisualStyleBackColor = true;
            this.Prod1_but.Click += new System.EventHandler(this.Prod1_but_Click);
            // 
            // Clear_but
            // 
            this.Clear_but.Location = new System.Drawing.Point(260, 388);
            this.Clear_but.Name = "Clear_but";
            this.Clear_but.Size = new System.Drawing.Size(115, 50);
            this.Clear_but.TabIndex = 14;
            this.Clear_but.Text = "Очистить";
            this.Clear_but.UseVisualStyleBackColor = true;
            this.Clear_but.Click += new System.EventHandler(this.Clear_but_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "элемент:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 34);
            this.label4.TabIndex = 16;
            this.label4.Text = "Произвидение \r\nэлеметов кратных:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 34);
            this.label5.TabIndex = 17;
            this.label5.Text = "Произвидение \r\nэлеметов до:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Clear_but);
            this.Controls.Add(this.Prod1_but);
            this.Controls.Add(this.Prod2_txt);
            this.Controls.Add(this.Add_full_mass_but);
            this.Controls.Add(this.Prod3_but);
            this.Controls.Add(this.Prod2_but);
            this.Controls.Add(this.Add_elm_txt);
            this.Controls.Add(this.Add_elm_but);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Add_full_mass_txt);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.Add_lenght_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add_lenght_but);
            this.Controls.Add(this.rtxb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxb;
        private System.Windows.Forms.Button Add_lenght_but;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Add_lenght_txt;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.TextBox Add_full_mass_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add_elm_but;
        private System.Windows.Forms.TextBox Add_elm_txt;
        private System.Windows.Forms.Button Prod2_but;
        private System.Windows.Forms.Button Prod3_but;
        private System.Windows.Forms.Button Add_full_mass_but;
        private System.Windows.Forms.TextBox Prod2_txt;
        private System.Windows.Forms.Button Prod1_but;
        private System.Windows.Forms.Button Clear_but;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

