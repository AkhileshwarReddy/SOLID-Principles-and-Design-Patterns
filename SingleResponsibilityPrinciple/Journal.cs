using System;
using System.Collections.Generic;

namespace SingleResponsibilityPrinciple
{
    public class Journal
    {
        private readonly List<string> entries = new List<string>();

        public static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count;
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }
    }
}
