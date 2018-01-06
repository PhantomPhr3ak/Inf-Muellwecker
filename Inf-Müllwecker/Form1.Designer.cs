namespace Inf_Müllwecker
{
    partial class mainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnNewDates = new System.Windows.Forms.Button();
            this.pb_blau = new System.Windows.Forms.PictureBox();
            this.pb_braun = new System.Windows.Forms.PictureBox();
            this.pb_gelb = new System.Windows.Forms.PictureBox();
            this.pb_rot = new System.Windows.Forms.PictureBox();
            this.pb_grau = new System.Windows.Forms.PictureBox();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.warnton = new System.Windows.Forms.Timer(this.components);
            this.warntonAus = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_blau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_braun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gelb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_grau)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewDates
            // 
            this.btnNewDates.BackColor = System.Drawing.Color.White;
            this.btnNewDates.Location = new System.Drawing.Point(183, 275);
            this.btnNewDates.Name = "btnNewDates";
            this.btnNewDates.Size = new System.Drawing.Size(218, 59);
            this.btnNewDates.TabIndex = 0;
            this.btnNewDates.Text = "Neue Daten hinzufügen";
            this.btnNewDates.UseVisualStyleBackColor = false;
            this.btnNewDates.Click += new System.EventHandler(this.btnNewDates_Click);
            // 
            // pb_blau
            // 
            this.pb_blau.BackgroundImage = global::Inf_Müllwecker.Properties.Resources.blau;
            this.pb_blau.Location = new System.Drawing.Point(28, 38);
            this.pb_blau.Name = "pb_blau";
            this.pb_blau.Size = new System.Drawing.Size(114, 129);
            this.pb_blau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_blau.TabIndex = 1;
            this.pb_blau.TabStop = false;
            // 
            // pb_braun
            // 
            this.pb_braun.BackgroundImage = global::Inf_Müllwecker.Properties.Resources.braun;
            this.pb_braun.Location = new System.Drawing.Point(183, 38);
            this.pb_braun.Name = "pb_braun";
            this.pb_braun.Size = new System.Drawing.Size(114, 129);
            this.pb_braun.TabIndex = 2;
            this.pb_braun.TabStop = false;
            // 
            // pb_gelb
            // 
            this.pb_gelb.BackgroundImage = global::Inf_Müllwecker.Properties.Resources.gelb;
            this.pb_gelb.Location = new System.Drawing.Point(349, 38);
            this.pb_gelb.Name = "pb_gelb";
            this.pb_gelb.Size = new System.Drawing.Size(114, 129);
            this.pb_gelb.TabIndex = 3;
            this.pb_gelb.TabStop = false;
            // 
            // pb_rot
            // 
            this.pb_rot.BackgroundImage = global::Inf_Müllwecker.Properties.Resources.rot;
            this.pb_rot.Location = new System.Drawing.Point(521, 38);
            this.pb_rot.Name = "pb_rot";
            this.pb_rot.Size = new System.Drawing.Size(114, 129);
            this.pb_rot.TabIndex = 4;
            this.pb_rot.TabStop = false;
            // 
            // pb_grau
            // 
            this.pb_grau.BackgroundImage = global::Inf_Müllwecker.Properties.Resources.schwarz;
            this.pb_grau.Location = new System.Drawing.Point(698, 38);
            this.pb_grau.Name = "pb_grau";
            this.pb_grau.Size = new System.Drawing.Size(114, 129);
            this.pb_grau.TabIndex = 5;
            this.pb_grau.TabStop = false;
            // 
            // refresh
            // 
            this.refresh.Enabled = true;
            this.refresh.Tick += new System.EventHandler(this.refresh_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(417, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Alle Daten zeigen";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(362, 210);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 24);
            this.lblDate.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Morgen:";
            // 
            // warnton
            // 
            this.warnton.Enabled = true;
            this.warnton.Interval = 12000000;
            this.warnton.Tick += new System.EventHandler(this.warnton_Tick);
            // 
            // warntonAus
            // 
            this.warntonAus.AutoSize = true;
            this.warntonAus.Location = new System.Drawing.Point(12, 352);
            this.warntonAus.Name = "warntonAus";
            this.warntonAus.Size = new System.Drawing.Size(185, 24);
            this.warntonAus.TabIndex = 9;
            this.warntonAus.Text = "Warnton deaktivieren";
            this.warntonAus.UseVisualStyleBackColor = true;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(840, 388);
            this.Controls.Add(this.warntonAus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pb_grau);
            this.Controls.Add(this.pb_rot);
            this.Controls.Add(this.pb_gelb);
            this.Controls.Add(this.pb_braun);
            this.Controls.Add(this.pb_blau);
            this.Controls.Add(this.btnNewDates);
            this.Name = "mainWindow";
            this.Text = "Müllwecker";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_blau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_braun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gelb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_grau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewDates;
        private System.Windows.Forms.PictureBox pb_blau;
        private System.Windows.Forms.PictureBox pb_braun;
        private System.Windows.Forms.PictureBox pb_gelb;
        private System.Windows.Forms.PictureBox pb_rot;
        private System.Windows.Forms.PictureBox pb_grau;
        private System.Windows.Forms.Timer refresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer warnton;
        private System.Windows.Forms.CheckBox warntonAus;
    }
}

