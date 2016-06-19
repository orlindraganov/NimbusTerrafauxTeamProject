//NOT FULLY READY YET, PLS DON'T TOUCH EXCEPT AFTER PHONE COORD 0899 998 056


namespace DungeonsOfOOP.Models
{
    using System;
    using System.Text;
    using System.Xml;

    public static class Quiz
    {
        public static bool AskQuestion(int questionIndex, XmlNodeList questions)
        {
            questionIndex = NormaliseQuestionIndex(questionIndex, questions);
            int correctAnswer = WriteQuestion(questions[questionIndex]);
            bool isValidAnswer = false;
            while (!isValidAnswer)
            {
                try
                {
                    return CheckAnswer(correctAnswer, questions[questionIndex].ChildNodes.Count);
                }
                catch (ArgumentException invalidInput)
                {
                    Console.WriteLine(invalidInput.Message);
                }
            }
            //inaccessible due try-catch in while but incompilable without:
            return false;
        }

        //Orlin: Access modifiers?
        private static int NormaliseQuestionIndex(int questionIndex, XmlNodeList questions)
        {
            var maxIndex = questions.Count - 1;
            if (questionIndex > maxIndex)
            {
                questionIndex = questionIndex % maxIndex;
            }
            return questionIndex;
        }

        private static int WriteQuestion(XmlNode question)
        {
            //Writes question + answers on console, returns correct answer index (1 based)
            var toPrint = new StringBuilder();
            var correctAnswer = -1;
            toPrint.Append("Question: ");
            toPrint.Append(question.Attributes["text"].Value);
            toPrint.Append("\n\r");
            for (int i = 0; i < question.ChildNodes.Count; i++)
            {
                toPrint.Append(i + 1);
                toPrint.Append(") ");
                toPrint.Append(question.ChildNodes[i].Attributes["text"].Value);
                toPrint.Append("\n\r");
                if (question.ChildNodes[i].Attributes["correct"].Value == "true")
                {
                    correctAnswer = i + 1;
                }
            }
            toPrint.Append("Please enter just the number of the answer you think is correct!");
            Console.WriteLine(toPrint.ToString());
            return correctAnswer;
        }

        private static bool CheckAnswer(int correctAnswer, int answersCount)
        {
            var givenAnswer = -1;
            var userInput = Console.ReadLine();
            if (userInput.ToLower() == "gosho")
            {
                throw new ArgumentException($"Alas! How can {userInput} be an illegal input? Quis custodiet ipsos custodes?");
            }
            bool isInt = int.TryParse(userInput, out givenAnswer);
            if (!isInt || givenAnswer > answersCount || givenAnswer < 1)
            {
                throw new ArgumentException("Invalid input.");
            }
            if (givenAnswer == correctAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
