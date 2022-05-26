using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator_ver_2._0
{
    internal class Divide 
    {
        private decimal result;
        private string exceptionOpe = "ERROR";
        public decimal DivideOperatiom(string operation)
        {
            var elements = operation.Split('/');

            if (operation.Contains('/'))
            {
                try 
                { 
                    result = decimal.Parse(elements[0]) / decimal.Parse(elements[1]); 
                }
                catch (FormatException) { result = default; }
                catch (DivideByZeroException) { result = default; }
                return Math.Round(result, 6);

            }
            return Math.Round(result, 6);
        }

    }
}
