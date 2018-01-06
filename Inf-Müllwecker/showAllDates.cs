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
    public partial class showAllDates : Form
    {
        public showAllDates()
        {
            InitializeComponent();
            müllwecker.lesen();

            //Listbox leeren
            lstAbholzeiten.Items.Clear();

            string zeile;

            //Daten in ListBox schreiben
            for (int i = 0; i < müllwecker.letzterEintrag; i++)
            {
                zeile = müllwecker.datum[i].ToLongDateString() + "    " + müllwecker.farbID[i].ToString();
                lstAbholzeiten.Items.Add(zeile);
            }

            lstAbholzeiten.SelectedIndex = 0;
        }

        //Attribute
        Müllwecker müllwecker = new Müllwecker();


        private void button1_Click(object sender, EventArgs e)
        {
            //Listbox leeren
            lstAbholzeiten.Items.Clear();

            //Daten laden
            müllwecker.lesen();
            string zeile;

            //Daten in ListBox schreiben
            for (int i = 0; i < müllwecker.letzterEintrag; i++)
            {
                zeile = müllwecker.datum[i].ToLongDateString() + "    " + müllwecker.farbID[i].ToString();
                lstAbholzeiten.Items.Add(zeile);
            }

            lstAbholzeiten.SelectedIndex = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            müllwecker.eintragLöschen(lstAbholzeiten.SelectedIndex);

            //Listbox leeren
            lstAbholzeiten.Items.Clear();

            //Daten laden
            müllwecker.lesen();
            string zeile;

            //Daten in ListBox schreiben
            for (int i = 0; i < müllwecker.letzterEintrag; i++)
            {
                zeile = müllwecker.datum[i].ToLongDateString() + "    " + müllwecker.farbID[i].ToString();
                lstAbholzeiten.Items.Add(zeile);
            }

            lstAbholzeiten.SelectedIndex = 0;
        }
    }
}
