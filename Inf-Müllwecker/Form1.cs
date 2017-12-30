using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inf_Müllwecker
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        /* Farbe ID's:
         * 1 = Blau
         * 2 = Braun
         * 3 = Gelb
         * 4 = Rot
         * 5 = Grau
         */

        Müllwecker müllwecker = new Müllwecker();

        private void mainWindow_Load(object sender, EventArgs e)
        {
            //Alle Farben unsichtbar machen
            pb_rot.Visible = false;
            pb_blau.Visible = false;
            pb_braun.Visible = false;
            pb_gelb.Visible = false;
            pb_grau.Visible = false;

            //Aktuelle Werte anzeigen
            aktualisieren();
        }

        private void aktualisieren()
        {
            lblDate.Text = DateTime.Today.ToLongDateString();

            int[] rFarbenMorgen = müllwecker.getFarbenMorgen();


            for (int i = 1; i <= 2; i++)
            {
                switch (rFarbenMorgen[i])
                {
                    case 1:
                        pb_blau.Visible = true;
                        break;
                    case 2:
                        pb_braun.Visible = true;
                        break;
                    case 3:
                        pb_gelb.Visible = true;
                        break;
                    case 4:
                        pb_rot.Visible = true;
                        break;
                    case 5:
                        pb_grau.Visible = true;
                        break;
                }
            }
        }

        private void refresh_Tick(object sender, EventArgs e)
        {
            aktualisieren();
        }
    }
}
