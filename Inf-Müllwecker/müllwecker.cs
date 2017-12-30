using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        void lesen()
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

        void schreiben()
        {
            //Daten schreiben
            StreamWriter writer = new StreamWriter(@"C:\ProgramData\müllweckerSpeicher.txt");
            for (int i = 0; i < letzterEintrag; i++)
            {
                //String zusammensetzen um die Daten Zeilenweise auslesen zu können
                writer.WriteLine(id[i] + ";" + datum[i] + ";" + farbID[i]);
            }
            writer.Close();
        }



        //Daten manipulieren
        void neuerEintrag(DateTime datum, int farbe)
        {
            //Arrays anpassen
            int aktuelleID = id[letzterEintrag]+1;
            this.id[letzterEintrag + 1] = aktuelleID;
            this.datum[letzterEintrag + 1] = datum;
            this.farbID[letzterEintrag + 1] = farbe;

            //Daten speichern
            schreiben();
        }

        void eintragLöschen(int id)
        {
            
        }



        //Attribute auslesen
        int[] getID()
        {
            return id;
        }

        DateTime[] getDatum()
        {
            return datum;
        }

        int[] getFarbID()
        {
            return farbID;
        }
    }
}
