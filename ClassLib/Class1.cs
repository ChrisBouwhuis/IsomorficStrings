namespace ClassLib
{
    public class Checker
    {
        public bool IsIsometric(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            Dictionary<char, char> mapS = new Dictionary<char, char>();
            Dictionary<char, char> mapT = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!mapS.ContainsKey(s[i]))
                {
                    mapS.Add(s[i], t[i]);
                }
                else if (mapS[s[i]] != t[i])
                {
                    return false;
                }

                if (!mapT.ContainsKey(t[i]))
                {
                    mapT.Add(t[i], s[i]);
                }
                else if (mapT[t[i]] != s[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
