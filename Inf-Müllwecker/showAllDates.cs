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
        }

        //Attribute
        Müllwecker müllwecker = new Müllwecker();

        private void refresh_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Listbox leeren
            lstAbholzeiten.Items.Clear();

            müllwecker.lesen();
            string zeile;

            for (int i = 0; i < müllwecker.letzterEintrag; i++)
            {
                zeile = müllwecker.datum[i].ToLongDateString() + "    " + müllwecker.farbID[i].ToString();
                lstAbholzeiten.Items.Add(zeile);
            }
        }
    }
}
