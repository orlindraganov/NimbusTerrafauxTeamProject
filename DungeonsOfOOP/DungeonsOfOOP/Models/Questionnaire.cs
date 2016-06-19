using System.Xml;

namespace DungeonsOfOOP.Models
{
    public static class Questionnaire
    {
        private const string QuestionsFileName = "./../../DataStorage/Questions.xml";
        private const string QuestionTagName = "question";

        public static XmlNodeList GetQuestions()
        {
            var reader = new XmlDocument();
            reader.Load(QuestionsFileName);
            XmlNodeList questions = reader.GetElementsByTagName(QuestionTagName);
            return questions;
        }
    }
}
