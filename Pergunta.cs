using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_quiz
{
    class Pergunta
    {
        string _desc;
        string _altA;
        string _altB;
        string _altC;
        string _altD;

        public Pergunta(string desc, string altA, string altB, string altC, string altD)
        {
            Desc = desc;
            AltA = altA;
            AltB = altB;
            AltC = altC;
            AltD = altD;
        }
        public string Desc { get => _desc; set => _desc = value; }
        public string AltA { get => _altA; set => _altA = value; }
        public string AltB { get => _altB; set => _altB = value; }
        public string AltC { get => _altC; set => _altC = value; }
        public string AltD { get => _altD; set => _altD = value; }
    }
}
