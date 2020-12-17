using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_classes_
{
    class ClassFirst
    {
        public int FindMax(int first, int second)
        {
            int result; //Здесь хранится наибольшее число

            if (first > second)
            {
                result = first;
            }
            else
            {
                result = second;
            }

            return result;
        }

    }

}
