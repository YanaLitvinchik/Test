using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    [Serializable]
    class Questions
    {
        public string Question { get; set; }
        public List<string> Answers { get; set; }
        public int Key { get; set; }

        public Questions(string q, int key, params string[]an)
        {
            this.Question = q;
            this.Key = key;
            this.Answers = new List<string>(an);
        }

    }
}
