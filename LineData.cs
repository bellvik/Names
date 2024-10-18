using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Names
{
    public class LineData
    {
        public string Title{ get; }
        public Dictionary<int,int> Count{ get; }
        public LineData(string title, Dictionary<int, int> count)
        { 
            Title = title;
            Count = count;
        }
    }
}
