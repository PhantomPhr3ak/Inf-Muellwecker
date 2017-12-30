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
        private int[] id = new int[] { }; 
        private DateTime[] datum = new DateTime[] { };
        private int[] farbID = new int[] {};
        private int letzterEintrag;


        //Grundfunktionen 
        public void lesen()
        {
            string line;
            letzterEintrag = 0;
            string lineID = null;
            string lineFarbe = null;
            string lineDatum = null;

            //Daten abrufen
            StreamReader reader = new StreamReader(@"C:\müllweckerSpeicher.txt");
            for (int i = 0; (line = reader.ReadLine()) != null; i++)
            {
                //Splitting the string into 3 parts (id, datum, farbe) and deleting the semicolons
                lineID = line.Substring(0, Convert.ToInt32(line.IndexOf(";"))-1);
                id[i] = Convert.ToInt32(lineID);

                line = line.Substring(Convert.ToInt32(line.IndexOf(";")), line.Length+1);

                lineDatum = line.Substring(0, Convert.ToInt32(line.IndexOf(";")) - 1);
                datum[i] = Convert.ToDateTime(lineDatum);

                line = line.Substring(Convert.ToInt32(line.IndexOf(";")), line.Length+1);

                lineFarbe = line;
                farbID[i] = Convert.ToInt32(lineFarbe);
            }
            reader.Close();
        }

        public void schreiben()
        {
            //Daten schreiben
            StreamWriter writer = new StreamWriter(@"C:\ProgramData\müllweckerSpeicher.txt");
            for (int i = 0; i < letzterEintrag; i++)
            {
                //String zusammensetzen um die Daten zeilenweise auslesen zu können
                writer.WriteLine(id[i] + ";" + datum[i] + ";" + farbID[i]);
            }
            writer.Close();
        }



        //Daten manipulieren
        public void neuerEintrag(DateTime datum, int farbe)
        {
            //Arrays anpassen
            int aktuelleID = id[letzterEintrag]+1;
            this.id[letzterEintrag + 1] = aktuelleID;
            this.datum[letzterEintrag + 1] = datum;
            this.farbID[letzterEintrag + 1] = farbe;

            //Daten speichern
            schreiben();
        }

        public void eintragLöschen(int eintragNr)
        {
            //Überschreiben der Daten innerhalb des Arrays.
            //Letzter Wert ist doppelt vorhanden. Er wird allerdings nie abgerufen, da der letzte Wert reduziert wird.
            for (int i = eintragNr; i < letzterEintrag; i++)
            {
                id[i] = id[i + 1];
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
            DateTime tomorrow = DateTime.Today;
            int[] returnValue = new int[]{};
            int j = 1;
            for (int i = 0; i <= letzterEintrag; i++)
            {
                if (datum[i] == tomorrow)
                {
                    returnValue[j] = farbID[i];
                    j++;
                }
            }
            return returnValue;
        }



        //Attribute auslesen
        public int[] getID()
        {
            return id;
        }

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
