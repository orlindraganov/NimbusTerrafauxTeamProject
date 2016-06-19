using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DungeonsOfOOP.Models
{
    public static class Questionnaire
    {
        private static XmlNodeList GetQuestions(string address)
        {
            var reader = new XmlDocument();
            reader.Load(address);
            XmlNodeList questions = reader.GetElementsByTagName("question");
            return questions;
        }

        public static XmlNodeList questions = GetQuestions("./../../DataStorage/Questions.xml");
    }
}
