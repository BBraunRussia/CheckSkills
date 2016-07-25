using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckSkills.Domain.Models;

namespace CheckSkills.UnitTests
{
    [TestClass]
    public class QuestionTest
    {
        [TestMethod]
        public void Can_Create_New_Question()
        {
            Question question = new Question { Text = "Сколько будет 2*2?" };
            question.AddAnswer(text: "1", right: false);
            question.AddAnswer(text: "2", right: false);
            question.AddAnswer(text: "3", right: false);
            question.AddAnswer(text: "4", right: true);
            question.AddAnswer(text: "1", right: false);

            Assert.AreEqual(4, question.List.Count);
            Assert.AreEqual(true, question.List[3].Right);
        }
    }
}
