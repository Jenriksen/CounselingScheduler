using System;

namespace CounselingScheduler.Domain.ValueObjects
{
    public sealed class Name
    {
        private string _text;

        public Name(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new NameShouldNotBeEmptyException("The 'name' field is required");
            this._text = text;
        }

        public override string ToString()
        {
            return _text.ToString();
        }


    }
}

