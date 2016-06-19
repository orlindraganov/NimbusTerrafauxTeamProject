namespace DungeonsOfOOP.Models
{
    using Common;

    public class Answer
    {
        private string answerText;

        public Answer(string answerText)
        {
            this.AnswerText = answerText;
        }

        public string AnswerText
        {
            get
            {
                return this.answerText;
            }

            private set
            {
                Validator.ValidateStringIsNotNullOrEmpty(value, "AnswerText");
                this.answerText = value;
            }
        }
    }
}
