using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0va_E_Learning_App
{
    public class item
    {
        public int ID;
        public string Stem;
        public string correct_answer;
        public string correct_option = "";
        public string chosen_answer = "";
        public string Distractor1;
        public string Distractor2;
        public string Distractor3;
        public Boolean Is_scored;
    }
    class itembanks
    {
        public int ID;
        public int duration_in_seconds;
        public int passing_score;
        public bool Randomize;
        public bool report_results;
        public item[] ib = new item[10];
    }
}
