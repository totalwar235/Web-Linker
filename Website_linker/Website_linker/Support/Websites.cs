using System;
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
            return Text + "\n\t"; //+ Text;
        }
    }

    class Websites
    {
        
            public static List<LinkItem> Find(string file,string URL)
            {
                List<LinkItem> list = new List<LinkItem>();

                // 1.
                // Find all matches in file.
                MatchCollection m1 = Regex.Matches(file, @"(<a.*?>.*?</a>)",RegexOptions.Singleline);

                // 2.
                // Loop over each match.
                foreach (Match m in m1)
                {
                    string value = m.Groups[1].Value;
                    LinkItem i = new LinkItem();

                    // 3.
                    // Get href attribute.
                    Match m2 = Regex.Match(value, @"href=\""(.*?)\""",RegexOptions.Singleline);
                    if (m2.Success)
                    {
                        i.Href = m2.Groups[1].Value;
                    }

                    // 4.
                    // Remove inner tags from text.
                    string t = Regex.Replace(value, @"\s*<.*?>\s*", "", RegexOptions.Singleline);

                    if (i.Href.Length > 0)
                    {
                        if (i.Href[0] == '/')
                        {
                            int count = 0;
                            int j = 0;
                            for (j = 0; j < i.Href.Length; j++)
                            {
                                if ('/' == i.Href[j])
                                {
                                    count++;
                                }
                            }

                            for (j = URL.Length-1; j >= 0; j--)
                            {
                                if (count != 0)
                                {
                                    if (URL[j] == '/')
                                    {
                                        count++;
                                        URL.Remove(URL.Length - 1);
                                    }
                                    URL.Remove(URL.Length - 1);
                                }
                            }
                            t = URL + i.Href;
                            i.Text = t;
                        }//forms links for internal links
                        else
                        {
                            i.Text = i.Href;
                        }   //prints external links
                    }   
                    
                    list.Add(i);
                }

                return list;
            }   //end of list

    }
}
