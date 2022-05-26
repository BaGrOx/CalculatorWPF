using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_ver_2._0
{
    internal class Add
    {
        private decimal result;
        public decimal AddOperation(string operation)
        {
            var elements = operation.Split('+');

            if (operation.Contains('+'))
            {
                try{result = decimal.Parse(elements[0]) + decimal.Parse(elements[1]);}
                catch (FormatException) { result = default; }

                return Math.Round(result, 6);

            }
            return Math.Round(result, 6);
        }
    }
}
