using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Aspen Roberts
namespace _P__JSON___Pokemon
{
    class PokeAPI
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<PokeResult> results { get; set; }

    }

    public class PokeResult
    {
        public string name { get; set; }

        public string url { get; set; }

        public override string ToString()
        {
            return name;
        }

    }

    public class ResultObject
    {
        public int width { get; set; }
        public int height { get; set; }
        public string name { get; set; }
        public string image { get; set; }

    }
}

