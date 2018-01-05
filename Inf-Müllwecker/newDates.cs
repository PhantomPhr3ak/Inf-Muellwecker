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
    public partial class newDates : Form
    {
        /* Farbe ID's:
         * 1 = Blau
         * 2 = Braun
         * 3 = Gelb
         * 4 = Rot
         * 5 = Grau
         */


        //Attribute
        Boolean[] mülltonne = new Boolean[] {false, false , false , false , false };
        Müllwecker müllwecker = new Müllwecker();

        public newDates()
        {
            InitializeComponent();
            //müllwecker.lesen();

            dateTimePicker.Value.ToLocalTime();
        }

        private void btnHinzufügen_Click(object sender, EventArgs e)
        {
            DateTime datum = dateTimePicker.Value;

            mülltonne[0] = checkBox1.Checked;
            mülltonne[1] = checkBox2.Checked;
            mülltonne[2] = checkBox3.Checked;
            mülltonne[3] = checkBox4.Checked;
            mülltonne[4] = checkBox5.Checked;

            müllwecker.neuerEintrag(datum, mülltonne);
        }
    }
}
