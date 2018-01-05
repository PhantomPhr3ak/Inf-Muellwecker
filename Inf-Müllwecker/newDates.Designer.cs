namespace Inf_Müllwecker
{
    partial class newDates
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.btnHinzufügen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(52, 82);
            this.dateTimePicker.MinDate = new System.DateTime(2017, 12, 29, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(303, 26);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.Value = new System.DateTime(2017, 12, 29, 22, 59, 25, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Neuen Termin hinzufügen";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(63, 123);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 24);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Blau";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(63, 157);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 24);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Braun";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(168, 123);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(69, 24);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Gelb";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(168, 157);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(61, 24);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Rot";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(284, 123);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(71, 24);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.Text = "Grau";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // btnHinzufügen
            // 
            this.btnHinzufügen.BackColor = System.Drawing.Color.White;
            this.btnHinzufügen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHinzufügen.Location = new System.Drawing.Point(52, 197);
            this.btnHinzufügen.Name = "btnHinzufügen";
            this.btnHinzufügen.Size = new System.Drawing.Size(303, 51);
            this.btnHinzufügen.TabIndex = 7;
            this.btnHinzufügen.Text = "Hinzufügen";
            this.btnHinzufügen.UseVisualStyleBackColor = false;
            this.btnHinzufügen.Click += new System.EventHandler(this.btnHinzufügen_Click);
            // 
            // newDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(414, 275);
            this.Controls.Add(this.btnHinzufügen);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "newDates";
            this.Text = "Müllwecker - Neue Daten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button btnHinzufügen;
    }
}