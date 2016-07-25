using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckSkills.Domain.Models
{
    public class Question
    {
        private Dictionary<string, Answer> list;

        public Question()
        {
            list = new Dictionary<string, Answer>();
        }

        public int ID { get; private set; }
        public string Text { get; set; }
        public List<Answer> List { get { return list.Values.ToList(); } }

        public void AddAnswer(string text, bool right)
        {
            if (!list.ContainsKey(text))
            {
                list.Add(text, new Answer(this) { Text = text, Right = right });
            }
        }
    }
}
