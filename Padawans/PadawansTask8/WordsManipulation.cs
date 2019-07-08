using System.Text;
using System;

namespace PadawansTask8
{
    public static class WordsManipulation
    {
        public static void RemoveDuplicateWords(ref string text)
        {
            // put your code here
            // throw new NotImplementedException();
            if (text == null)
                throw new ArgumentNullException();
            if (text.Length == 0 || text == " ")
                throw new ArgumentException();

            string[] words = text.Split(new[] { '.', ',', '!', '?', '-', ':', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            System.Collections.Generic.List<string> lst = new System.Collections.Generic.List<string>();
            for (int i = 0; i < words.Length; i++)
            { 
                if (lst.Contains(words[i]))
                    continue;
                else
                    lst.Add(words[i]);
            }

            for (int i = 0; i < lst.Count; i++)
            {
                int firstIdx = text.IndexOf(lst[i]);
                int lastIdx = text.LastIndexOf(lst[i]);
                // Beware!!!!!!!!
                if ((((firstIdx + lst[i].Length) == text.Length) || (".,!?-:; ".IndexOf(text[firstIdx + lst[i].Length]) != -1)) 
                  && (((lastIdx + lst[i].Length) == text.Length) || (".,!?-:; ".IndexOf(text[lastIdx + lst[i].Length]) != -1)))
                {
                    while (firstIdx != lastIdx)
                    {
                        text = text.Remove(lastIdx, lst[i].Length);
                        lastIdx = text.LastIndexOf(lst[i]);
                    }
                }
            }
        }
    }
}