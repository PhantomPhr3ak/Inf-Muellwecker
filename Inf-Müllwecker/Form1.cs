using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
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

        private Müllwecker müllwecker = new Müllwecker();

        private void mainWindow_Load(object sender, EventArgs e)
        {
            //Daten laden
            müllwecker.lesen();

            //Aktuelle Werte anzeigen
            aktualisieren();

            warntonAus.Checked = false;
        }

        private void aktualisieren()
        {
            müllwecker.lesen();

            //Alle Farben unsichtbar machen
            pb_rot.Visible = false;
            pb_blau.Visible = false;
            pb_braun.Visible = false;
            pb_gelb.Visible = false;
            pb_grau.Visible = false;

            lblDate.Text = DateTime.Today.AddDays(1).ToLongDateString();

            int[] rFarbenMorgen;
            rFarbenMorgen = müllwecker.getFarbenMorgen();
            
            for (int i = 0; i <= 1; i++)
            {
                switch (rFarbenMorgen[i])
                {
                    case 0:
                        break;
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

        private void btnNewDates_Click(object sender, EventArgs e)
        {
            newDates neueDaten = new newDates();
            neueDaten.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showAllDates alleDaten = new showAllDates();
            alleDaten.Show();
        }

        private void warnton_Tick(object sender, EventArgs e)
        {
            //Überprüfen, ob es heute überhaupt Mülltonnen rauszustellen gibt und ob der Ton deaktiviert wurde
            if (müllwecker.getFarbenMorgen()[0] != 0 && warntonAus.Checked == false)
            {
                //Vier Töne mit jeweils 2 Sekunden Zeitabstand
                for (int i = 0; i < 4; i++)
                {
                    SystemSounds.Beep.Play();
                    Thread.Sleep(2000);
                }
            }
        }
    }
}
