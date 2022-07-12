using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalExamScreen
{
    [Serializable]

    internal class CQuestion
    {
        //Attributes

        string information = "";
        string[] options = new string[4];
        int correct = 0;
        int selected = -1;

        //Constructos

        public CQuestion()
        {

        }

        public CQuestion( string information, string[] options, int answer)
        {
            this.information = information;
            this.options = options;
            correct = answer;
        }

        //I'll prepare this constructor for the ResultViewer

        public CQuestion(string information, string[] options, int answer, int selected)
        {
            this.information = information;
            this.options = options;
            correct = answer;
            this.selected = selected;
        }

        //Props

        public string Information { get => information; set => information = value; }
        public string[] Options { get => options; set => options = value; }
        public int Correct { get => correct; set => correct = value; }
        public int Selected { get => selected; set => selected = value; }
    }
}
