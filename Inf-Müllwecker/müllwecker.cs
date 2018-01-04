using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Inf_Müllwecker
{
    class Müllwecker
    {
        /* Farbe ID's:
         * 1 = Blau
         * 2 = Braun
         * 3 = Gelb
         * 4 = Rot
         * 5 = Grau
         */

        //letzterEintrag bezieht sich auf die ID

        //Attribute
        private DateTime[] datum = new DateTime[] {};
        private int[] farbID = new int[] { 0 };
        private int letzterEintrag;


        //Grundfunktionen 
        public void lesen()
        {
            string line;
            letzterEintrag = 0;

            //Daten abrufen
            FileStream fs = new FileStream("müllweckerSpeicher.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            
            while(reader.Peek() != -1)
            {
                line = reader.ReadLine();

                //Splitting the string into 2 parts (datum, farbe) and deleting the semicolons
                datum[letzterEintrag] = Convert.ToDateTime(line.Substring(0,line.IndexOf(";") - 1));
                
                //Datum "abschneiden"
                farbID[letzterEintrag] = Convert.ToInt32(line.Substring(line.IndexOf(";")+1, line.Length));

                letzterEintrag++;
            }
            reader.Close();
            fs.Close();
        }

        public void schreiben()
        {
            try
            {
                //Daten schreiben
                StreamWriter writer = new StreamWriter("müllweckerSpeicher.txt");
                for (int i = 0; i < letzterEintrag; i++)
                {
                    //String zusammensetzen um die Daten im nachhinein zeilenweise auslesen zu können
                    writer.WriteLine(datum[i] + ";" + farbID[i]);
                }
                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }



        //Daten manipulieren
        public void neuerEintrag(DateTime datum, int farbe)
        {
            //Arrays anpassen
            this.datum[letzterEintrag + 1] = datum;
            this.farbID[letzterEintrag + 1] = farbe;

            //Daten speichern
            schreiben();
        }

        public void eintragLöschen(int eintragNr)
        {
            //Überschreiben der Daten innerhalb des Arrays.
            //Letzter Wert ist doppelt vorhanden. Er wird allerdings nie abgerufen, da die Variable letzterWert reduziert wird.
            for (int i = eintragNr; i < letzterEintrag; i++)
            {
                datum[i] = datum[i + 1];
                farbID[i] = farbID[i + 1];
            }
            letzterEintrag--;

            //Daten speichern
            schreiben();

            //Bestätigungsnachricht
            MessageBox.Show("Eintrag erfolgreich gelöscht!", "Erfolg", MessageBoxButtons.OK);
        }

        public int[] getFarbenMorgen()
        {
            string tomorrow = DateTime.Today.AddDays(1).ToLongDateString();
            int[] returnValue = new int[]{};
            int j = 1;
            for (int i = 0; i <= letzterEintrag; i++)
            {
                if (datum != null && datum[i].ToString() == tomorrow)
                {
                    returnValue[j] = farbID[i];
                    j++;
                }
            }
            return returnValue;
        }



        //Attribute auslesen
        public DateTime[] getDatum()
        {
            return datum;
        }

        public int[] getFarbID()
        {
            return farbID;
        }
    }
}
