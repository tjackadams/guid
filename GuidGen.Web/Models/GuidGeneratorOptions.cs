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

        public bool Uppercase { get; set; }
        public bool Brackets { get; set; }
        public bool Hyphens { get; set;  }
    }
}