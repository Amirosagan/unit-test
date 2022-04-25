using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using totest;

namespace tester
{
    internal class Fakerepo : IDatarepo 
    {
        List<Wight> wights;


        public Fakerepo()
        {
            wights = new List<Wight>() {
                new Wight { heght = 190,sex = 'm' },
                new Wight { heght = 150,sex = 'g' },
                new Wight { heght = 160,sex = 'g' },
                new Wight { heght = 172,sex = 'm' }
            };

        }

        public List<Wight> GetWights()
        {
            return wights;
        }
    }
}
