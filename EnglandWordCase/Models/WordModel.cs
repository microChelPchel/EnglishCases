using System;

namespace EnglandWordCase.Models
{
    [Serializable]
    internal class WordModel
    {
        private string name;
        private string value;

        public WordModel() { }


        public WordModel(string name, string value)
        { 
            this.name = name;
            this.value = value;
        }

        public string Name
        {
            get { return name; }
            set { name = value.ToLower().Trim(' ').ToLowerInvariant(); }
        }


        public string Value
        {
            get { return value; }
            set { this.value = value.ToLower().Trim(' ').ToLowerInvariant(); }

        }
    }
}
