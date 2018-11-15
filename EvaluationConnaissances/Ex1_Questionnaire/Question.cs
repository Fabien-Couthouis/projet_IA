using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex1_Questionnaire
{
    public class Question
    {
        public static XElement xdoc = XElement.Load("..\\..\\questions.xml");
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public List<string> Answers { get; set; }
        public string GoodAnswer { get; set; }
        public Image Image { get; set; }
        public bool HasImage { get; set; }
        public string Explanation { get; set; }
        public int Points { get; set; }

        //public Question(int id, string questionText, List<string> answers, string goodAnswer)
        //{
        //    Id = id;
        //    Image = image;
        //    HasImage = false;
        //    QuestionText = questionText;
        //    Answers = answers;
        //    GoodAnswer = goodAnswer;

        //}
        public Question(int id)
        {
            Id = id;
            CreateQuestion(id);
        }

        private void CreateQuestion(int id)
        {
            //Lecture du xml
            var items = from item in xdoc.Descendants("Question")
                        where item.Attribute("Id").Value == id.ToString()
                        select new
                        {
                            QuestionText = item.Element("QuestionText").Value,
                            ImageName = item.Element("ImageName").Value,
                            Answers = item.Descendants("Answers").Descendants().Select(x => x.Value).ToList(),
                            GoodAnswer = item.Element("GoodAnswer").Value,
                            Explanation = item.Element("Explanation").Value,
                            Points = item.Element("Points").Value
                        };

            //On entre les valeurs dans la question
            foreach (var item in items)
            {
                this.QuestionText = item.QuestionText;
                this.Answers = item.Answers;
                this.GoodAnswer = item.GoodAnswer;
                this.Explanation = item.Explanation;
                this.Points = Convert.ToInt32(item.Points);
                if (item.ImageName != "")
                {
                    HasImage = true;
                    Image = Image.FromFile("..//..//images//" + item.ImageName);
                }
                else
                    HasImage = false;
            }

            return;
        }


    }
}
