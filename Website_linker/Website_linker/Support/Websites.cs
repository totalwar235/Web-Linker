﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Website_linker.Support
{
    public struct LinkItem
    {
        public string Href;
        public string Text;

        public override string ToString()
        {
            return Href + "\n\t"; //+ Text;
        }
    }

    class Websites
    {
        
            public static List<LinkItem> Find(string file,string URL)
            {
                List<LinkItem> list = new List<LinkItem>();

                // 1.
                // Find all matches in file.
                MatchCollection m1 = Regex.Matches(file, @"(<a.*?>.*?</a>)",
                    RegexOptions.Singleline);

                // 2.
                // Loop over each match.
                foreach (Match m in m1)
                {
                    string value = m.Groups[1].Value;
                    LinkItem i = new LinkItem();

                    // 3.
                    // Get href attribute.
                    Match m2 = Regex.Match(value, @"href=\""(.*?)\""",
                    RegexOptions.Singleline);
                    if (m2.Success)
                    {
                        i.Href = m2.Groups[1].Value;
                    }

                    // 4.
                    // Remove inner tags from text.
                    string t = Regex.Replace(value, @"\s*<.*?>\s*", "",
                    RegexOptions.Singleline);
                    i.Text = t;

                    list.Add(i);
                }
                return list;
            }   //end of list

            private string internal_page(string URL, string HREF)
            {
                int count = 0;
                int i = 0;
                for (i = 0; i < HREF.Length; i++)
                {
                    if('/' == HREF[i])
                    {
                        count++;
                    }
                }

                for (i = URL.Length; i == 0; i-- )
                {
                    if(count != 0)
                    {
                        URL.
                    }
                }

                    return URL;
            }
    }
}
