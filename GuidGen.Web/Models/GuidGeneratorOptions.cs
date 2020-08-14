namespace GuidGen.Web.Models
{
    public class GuidGeneratorOptions
    {
        public GuidGeneratorOptions()
        {
            Uppercase = true;
            Brackets = false;
            Hyphens = true;
        }

        public bool Uppercase { get; private set; }
        public bool Brackets { get; private set; }
        public bool Hyphens { get; private set;  }
        public void ToggleCase()
        {
            Uppercase = !Uppercase;
        }

        public void ToggleBrackets()
        {
            Brackets = !Brackets;
        }

        public void ToggleHyphens()
        {
            Hyphens = !Hyphens;
        }
    }
}