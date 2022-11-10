using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PasseExamen
{
    internal class Examen
    {
        private DateTime date;
        private string dure;
        private string endroit;
        private int note;
        int dureDebut;
        int dureFin;
        public Examen(DateTime date, int dureDebut,int dureFin, string endroit,int note)
        {
            this.date = date;
            this.dureDebut = dureDebut;
            this.dureFin = dureFin;
            this.endroit = endroit;
            this.note = note;
        }
        public DateTime Date  
        {
            get { return date; }   
            set { date = value; }  
        }
        public int DureDebut
        {
            get { return dureDebut; }   
            set { dureDebut = value; }  
        }
        public int DureFin
        {
            get { return dureFin; }
            set { dureFin = value; }
        }
        public int Note
        {
            get { return note; }
            set { note = value; }
        }
    }
}


