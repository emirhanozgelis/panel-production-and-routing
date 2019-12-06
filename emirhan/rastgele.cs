using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emirhan
{
    class rastgele
    {
        public static int SayiUret(int min, int max)
        {
            if (rastgelee == null)
                rastgelee = new Random();

            return rastgelee.Next(min,max);
        }

        private static Random rastgelee;
    }
}
