using System.Text;

namespace Lab8
{
    public static class Lab8
    {
        public static string PrettifyList(string s)
        {
            char[] whiteSpace = new char[] {'\f', '\n', '\r', '\t', '\v', '\u2000' };
            if (s == null)
            {
                return null;
            }
            s = s.Trim(whiteSpace);
            s = s.Trim();
            if (s == "")
            {
                return null;
            }
            foreach (var element in whiteSpace)
            {
                s = s.Replace(element.ToString(), string.Empty);
            }
            StringBuilder builder = new StringBuilder(2048);
            string[] tokenLevel1 = s.Split('|');
            for (int i = 0; i < tokenLevel1.Length; i++)
            {
                string[] tokenLevel2 = tokenLevel1[i].Split('_');
                tokenLevel1[i] = tokenLevel2[0];
                builder.AppendLine((i + 1) + ") " + tokenLevel1[i]);
                for (int j = 1; j < tokenLevel2.Length; j++)
                {
                    string[] tokenLevel3 = tokenLevel2[j].Split('/');
                    tokenLevel2[j] = tokenLevel3[0];
                    char alphabetIndex = (char)('a' - 1 + j);
                    builder.AppendLine("    " + alphabetIndex + ") " + tokenLevel2[j]);
                    for (int k = 1; k < tokenLevel3.Length; k++)
                    {
                        builder.AppendLine("        " + "- " + tokenLevel3[k]);
                    }
                }
            }
            string result = builder.ToString();
            return result;
        }
    }
}
