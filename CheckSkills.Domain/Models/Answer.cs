using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckSkills.Domain.Models
{
    public class Answer
    {
        private int idQuestion;

        public Answer(Question question)
        {
            this.idQuestion = question.ID;
        }
        
        public string Text { get; set; }
        public bool Right { get; set; }
    }
}
