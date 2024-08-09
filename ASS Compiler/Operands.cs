using System.Linq.Expressions;

namespace AssCompiler
{
    class Operand
    {
        public string name = "name";
        public Func<double, double, double> function;
        public Operand(string name, Func<double, double, double> function)
        {
            this.name = name;
            this.function = function;
        }
    }
    class Operands
    {
        static Func<double, double, double> add = (left,right) => left + right;
        Operand[] operands = {
            new Operand("+=", add)
        };
        public Operand FindOperand(string input)
        {
            foreach(var i in operands)
            {
                try
                {
                    if(i.name==input)
                    {
                        return i;
                    }
                }
                catch(Exception e)
                {

                }
            }
            return null;
        }
    }
}