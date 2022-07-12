using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalExamScreen
{
    [Serializable]

    internal class CExam
    {
        //Attributes

        string examType = "";
        string teacherName = "";
        string creationDate = "";

        //We'll use this attribute for exam encrypt

        string examAccessKey = "";

        //We'll save a "CQuestion List" to save the exercises's list

        List<CQuestion> questions = new List<CQuestion>();

        //Constructor(s)

        public CExam(string teacherName)
        {
            this.teacherName = teacherName;
        }

        //Props

        public string ExamType { get => examType; set => examType = value; }
        public string TeacherName { get => teacherName; set => teacherName = value; }
        public string CreationDate { get => creationDate; set => creationDate = value; }
        public string ExamAccessKey { get => examAccessKey; set => examAccessKey = value; }
        public List<CQuestion> Questions { get => questions; set => questions = value; }
    }
}
