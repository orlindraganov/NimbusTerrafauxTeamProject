namespace DungeonsOfOOP.Models
{
    using System.Collections.Generic;

    using Common;

    public class Question
    {
        private string questionText;
        private IDictionary<Answer, bool> answers;

        public Question(string questionText, IDictionary<Answer, bool> answers)
        {
            this.QuestionText = questionText;
            this.Answers = answers;
        }

        public string QuestionText
        {
            get
            {
                return this.questionText;
            }

            private set
            {
                Validator.ValidateStringIsNotNullOrEmpty(value, "QuestionText");
                this.questionText = value;
            }
        }

        public IDictionary<Answer, bool> Answers
        {
            get
            {
                return new Dictionary<Answer, bool>(this.answers);
            }
            private set
            {
                Validator.ValidateIsNotNull(value, "Answers");
                foreach (var answer in value)
                {
                    Validator.ValidateIsNotNull(answer, "Answer key value pair");
                    Validator.ValidateIsNotNull(answer.Key, "Answer");
                }

                this.answers = value;
            }
        }
    }
}
