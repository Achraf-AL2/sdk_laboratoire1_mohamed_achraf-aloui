namespace LibrairieConversionNote
{
    public class ConversionAlphabetiqueToNote
    {
        public string Transformer(string noteAlphabetique)
        {
            switch (noteAlphabetique.ToUpper())
            {
                case "A": return "LA";
                case "B": return "SI";
                case "C": return "DO";
                case "D": return "RÉ";
                case "E": return "MI";
                case "F": return "FA";
                case "G": return "SOL";
                default: return "La note n'existe pas";
            }
        }
    }

}
