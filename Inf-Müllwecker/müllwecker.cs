using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private int[] id = new int[] { }; 
        private DateTime[] datum = new DateTime[] { };
        private int[] farbID = new int[] {};



        //Grundfunktionen 
        void lesen()
        {
            
        }

        void schreiben()
        {
            
        }



        //Daten manipulieren
        void neuerEintrag()
        {
            
        }

        void eintragLöschen()
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
