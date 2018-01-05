using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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


        //Attribute
        public DateTime[] datum = new DateTime[10000];
        private string[] datumStrings = new string[10000];
        public int[] farbID = new int[10000];
        public int letzterEintrag;


        //Grundfunktionen 
        public void lesen()
        {
            string line;
            letzterEintrag = -1;

            //Daten abrufen
            FileStream fs = new FileStream("müllweckerSpeicher.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);


            while(reader.Peek() != -1)
            {
                line = reader.ReadLine();

                letzterEintrag++;

                //Splitting the string into 2 parts (datum, farbe) and deleting the semicolons
                datumStrings[letzterEintrag] = line.Substring(0,line.IndexOf(";") - 1);
                
                farbID[letzterEintrag] = Convert.ToInt32(line.Substring(line.IndexOf(";")+1));
            }


            reader.Close();
            fs.Close();

            for (int i = 0; i <= letzterEintrag; i++)
            {
                datum[i] = Convert.ToDateTime(datumStrings[i]);
            }
        }

        public void schreiben() 
        {
            try
            {
                //Daten schreiben
                StreamWriter writer = new StreamWriter("müllweckerSpeicher.txt");
                for (int i = 0; i < letzterEintrag; i++)
                {
                    if (DateTime.Compare(datum[i], DateTime.Today) >= 0)
                    {
                        //String zusammensetzen um die Daten im nachhinein zeilenweise auslesen zu können
                        writer.WriteLine(datum[i].ToString() + ";" + farbID[i]);
                    }
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
        public void neuerEintrag(DateTime datum, Boolean[] farbe)
        {
            //Arrays anpassen

            lesen();

            int anzahlTrue = 0;
            for (int i = 0; i < 5; i++)
            {
                if (farbe[i])
                {
                    anzahlTrue++;
                }
            }

            if (anzahlTrue <= 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (farbe[0] == true)
                    {
                        this.datum[letzterEintrag + 1] = datum;
                        this.farbID[letzterEintrag + 1] = 1;
                        farbe[0] = false;
                        letzterEintrag++;
                    }
                    else if (farbe[1] == true)
                    {
                        this.datum[letzterEintrag + 1] = datum;
                        this.farbID[letzterEintrag + 1] = 2;
                        farbe[1] = false;
                        letzterEintrag++;
                    }
                    else if (farbe[2] == true)
                    {
                        this.datum[letzterEintrag + 1] = datum;
                        this.farbID[letzterEintrag + 1] = 3;
                        farbe[2] = false;
                        letzterEintrag++;
                    }
                    else if (farbe[3] == true)
                    {
                        this.datum[letzterEintrag + 1] = datum;
                        this.farbID[letzterEintrag + 1] = 4;
                        farbe[3] = false;
                        letzterEintrag++;
                    }
                    else if (farbe[4] == true)
                    {
                        this.datum[letzterEintrag + 1] = datum;
                        this.farbID[letzterEintrag + 1] = 5;
                        farbe[4] = false;
                        letzterEintrag++;
                    }

                }
                //Daten speichern
                schreiben();
            }
            else
            {
                MessageBox.Show("Bitte nicht mehr als 2 Mülltonnen für einen Tag auswählen", "Fehler", MessageBoxButtons.OK);
            }
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
            string tomorrow = DateTime.Today.AddDays(1).ToShortDateString();
            int[] returnValue = new int[2]{0,0};
            int j = 0;
            for (int i = 0; i <= letzterEintrag; i++)
            {
                if (datum != null && datum[i].ToShortDateString() == tomorrow && farbID[i] != 0)
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
