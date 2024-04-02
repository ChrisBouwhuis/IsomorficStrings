namespace ClassLib
{
    public class Checker
    {
        public bool IsIsometric(string s, string t)
        {
            var dictionary = new Dictionary<char, char>();
            for (var i = 0; i < s.Length; i++)
            {
                if (dictionary.TryGetValue(s[i], out var currentPair))
                {
                    if (currentPair != t[i])
                    {
                        return false;
                    }
                    continue;
                }
                if (dictionary.ContainsValue(t[i]))
                {
                    return false;
                }
                dictionary.Add(s[i], t[i]);
            }
            return true;
        }
    }
}
