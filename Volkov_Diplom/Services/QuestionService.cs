using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volkov_Diplom.Models;

namespace Volkov_Diplom.Services
{
    static class QuestionService
    {

        public static void addQuestion(string answer)
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                Question question = new Question(answer);

                context.Questions.Add(question);
                context.SaveChanges();

            };

        }


        public static List<Question> getQuestions()
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                List<Question> questions = context.Questions.ToList() as List<Question>;

                return questions;
            }

        }

        public static void editBodyQuestions(int id, string name, string answer, string answer1, string answer2, string answer3)
        {
            using (ApplicationContext context = new ApplicationContext())
            {

                Question question = context.Questions.Find(id);
                question.name = name;
                question.answer = answer;
                question.boxAnswer = answer1;
                question.boxAnswer2 = answer2;
                question.boxAnswer3 = answer3;

                if (question != null)
                {
                    context.Questions.Update(question);

                    context.SaveChanges();
                }
                else
                {
                    System.Windows.MessageBox.Show("Не найден вопрос");
                }

            };

        }
    }
}
