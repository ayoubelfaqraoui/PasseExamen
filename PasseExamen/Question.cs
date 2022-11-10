using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasseExamen
{
    internal class Question
    {
        string enonce;
        float note;
        public string Enonce
        {
            get { return enonce; }
            set { enonce = value; }
        }
        public int Note
        {
            get { return (int)note; }
            set { note  = value; }

        }

    }
}
