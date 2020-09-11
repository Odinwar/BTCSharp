using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai50
{
    class ManagerQuestion
    {
        List<Question> questions;
        public const string ID_QUESTION = "id";
        public const string MAX_TIME = "maxTime";
        public const string CONTENT_QUESTION = "content";

        public ManagerQuestion() 
        {
            questions = new List<Question>();
        }
        public ManagerQuestion(List<Question> questions) 
        {
            this.questions = new List<Question>();
        }
        public void showAll()
        {
            if (questions.Count == 0) Console.WriteLine("List Rong");
            else
            {
                Console.WriteLine("List Cau hoi: ");
                foreach (var temp in questions) Console.WriteLine(temp.ToString());
            }
        }
        public dynamic search(string value,string type = null) 
        {
            switch (type) 
            {
                case ID_QUESTION:
                    return questions.Where(x => value.Contains(x.id.ToString())).ToList();
                case MAX_TIME:
                    return questions.Where(x => value.Contains(x.maxTime.ToString())).ToList();
                case CONTENT_QUESTION:
                    return questions.Where(x => value.Contains(x.content)).ToList();
                default:
                    return questions.Where(x => value.Contains(x.id.ToString()) ||
                                                value.Contains(x.content) ||
                                                value.Contains(x.answers.ToString()) ||
                                                value.Contains(x.rightAnswer) ||
                                                value.Contains(x.maxTime.ToString())).ToList();
            }            
        }
        public bool add(Question question)
        {
            try {
                questions.Add(question);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool add(List<Question> questions)
        {
            foreach (var temp in questions)
                if (!add(temp)) return false;
            return true;
        }
        public bool edit(Question question)
        {
            var temp = questions.Where(x => x.id == question.id).FirstOrDefault();
            if (temp == null) return false;
            temp.content = question.content;
            temp.answers = question.answers;
            temp.rightAnswer = question.rightAnswer;
            temp.maxTime = question.maxTime;
            return true;
        }
        public bool remove(Question question)
        {
            var temp = questions.Where(x => x.id == question.id).FirstOrDefault();
            if (temp == null) return false;
            questions.Remove(temp);
            return true;
        }
        public bool remove(int id) 
        {
            var temp = questions.Where(x => x.id == id).FirstOrDefault();
            if (temp == null) return false;
            questions.Remove(temp);
            return true;
        }
        public bool remove(List<Question> questions) 
        {
            foreach (var temp in questions)
                if (!remove(temp)) return false;
            return true;
        }
        public void seedData()
        {
            List<string> answer = new List<string>();
            answer.Add("answer1");
            answer.Add("answer2");
            answer.Add("answer3");
            questions.Add(new Question("Content Question", answer, "answer3", 120));
            questions.Add(new Question("Content Question", answer, "answer3", 120));
            questions.Add(new Question("Content Question", answer, "answer3", 120));
            questions.Add(new Question("Content Question", answer, "answer3", 120));
            questions.Add(new Question("Content Question", answer, "answer3", 120));
        }

    }
}
