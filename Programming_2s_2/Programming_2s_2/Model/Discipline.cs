using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_2s_2.Model
{
    public class Discipline
    {
        private string nameDiscipline;
        private string score;
        private string nameTeacher;
        private string surnameTeacher;

        public Discipline() { }

        public Discipline(string nameDiscipline, string score, string nameTeacher, string surnameTeacher)
        {
            this.nameDiscipline = nameDiscipline;
            this.score = score;
            this.nameTeacher = nameTeacher;
            this.surnameTeacher = surnameTeacher;
        }

        public string getNameDiscipline() { return nameDiscipline; }
        public string getScore() { return score; }
        public string getNameTeacher() { return nameTeacher; }
        public string getSurnameTeacher() {return surnameTeacher; }

        public void setNameDiscipline(string nameDiscipline) { this.nameDiscipline = nameDiscipline;  }

        public void setScore(string score) { this.score = score; }

        public void setNameTeacher(string nameTeacher) { this.nameTeacher = nameTeacher; }

        public void setSurnameTeacher( string surnameTeacher) { this.surnameTeacher= surnameTeacher; }
    }
}
