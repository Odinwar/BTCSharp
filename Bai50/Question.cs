using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Bai50
{
    public class Question
    {
        public static int id_static = 1; 
        public int id { get; set; }
        public string content { get; set; }
        public List<string> answers { get; set; }
        public string rightAnswer { get; set; }
        public int maxTime { get; set; }

        public Question() { }

        public Question(int id,string content,List<string> answers,string rightAnswers,int maxTime) 
        {
            this.id = id;
            this.content = content;
            this.answers = answers;
            this.rightAnswer = rightAnswer;
            this.maxTime = maxTime;
        }

        public Question(string content, List<string> answers, string rightAnswers, int maxTime)
        {
            this.id = id_static;
            this.content = content;
            this.answers = answers;
            this.rightAnswer = rightAnswers;
            this.maxTime = maxTime;
            id_static++;
        }

        public override string ToString()
        {
            string answer = "";
            foreach (string temp in answers) answer += temp + "\n";
            return "Id : " + id + " Content: " + content +
                    " MaxTime: " + maxTime.ToString() + " :" + "\n" +
                    answer + "\n" + "Dap an : " + rightAnswer;        
        }
    }
}
