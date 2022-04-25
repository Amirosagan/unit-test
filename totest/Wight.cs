using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace totest
{
    public class Wight
    {
        private IDatarepo reptory;
       public double heght { get; set; }
        
       public char sex { get; set; }

        public Wight(IDatarepo repotry)
        {
            this.reptory = repotry;
        }
        public Wight()
        {

        }

       public double getSutibleWegith()
        {
            switch (sex)
            {
                case 'm': return (heght - 100) - (heght - 150) / 4;

                case 'g': return (heght - 100) - (heght - 150) / 2; ;

                default:
                    throw new ArgumentException("this char not (m/g) please return program ");
            }
        }

        public List<double> getweghtsfromdatasourse ()
        {
            List<double> lists = new List<double>();
            
            var weights = reptory.GetWights();

            foreach (var item in weights)
            {
                lists.Add(item.getSutibleWegith());
                Console.WriteLine(item.getSutibleWegith());
            }

            return lists;
        }


    }
}
