using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calculator
    {
        public Calculator()
        {

        }
        public Calculator(double x,double y,char op)
        {
            
            switch (op)
            {
                case '+':
                    Console.WriteLine(Add(x, y));
                    break;
                case '-':
                    Console.WriteLine(Sub(x, y));
                    break;
                case '*':
                    Console.WriteLine(Mul(x, y));
                    break;
                case '/':
                    Console.WriteLine(Div(x, y));
                    break;
            }
        }
        public double Add(double x, double y)
        {
            if(((x==Double.MaxValue)&&(y>0))||((y== Double.MaxValue)&&(x>0))||((x == Double.MinValue) &&(y == Double.MinValue)))
            {
                throw new System.OverflowException("overflow exception");
            }
            if ((x+y > Double.MaxValue) || (x-y < Double.MinValue))
            {
                throw new System.OverflowException("overflow exception");
            }
            return x+y;
        }
        public double Sub(double x, double y)
        {
            if ((x == Double.MaxValue) && (y ==Double.MinValue) || (y == Double.MaxValue) && (x ==Double.MinValue))
            {
                throw new System.OverflowException("overflow exception");
            }
            return x - y;
        }
        public double Mul(double x, double y)
        {
           if((x*y>Double.MaxValue)||(x * y < Double.MinValue))
            {
                throw new System.OverflowException("overflow exception");
            }
            return x * y;
        }
        public double Div(double x, double y)
        {
            if (y==0)
            {
                throw new System.DivideByZeroException("DivideByZeroException");
            }
            if ((x / y > Double.MaxValue) || (x / y < Double.MinValue))
            {
                throw new System.OverflowException("overflow exception");
            }
            return x / y;
        }
       
        public static void Main(String[] args)
        {
            String val;
            Console.Write("Enter integer: ");
            val = Console.ReadLine();
            double num1 = Convert.ToDouble(val);
            Console.Write("Enter integer: ");
            val = Console.ReadLine();
            double num2 = Convert.ToDouble(val);
            Console.Write("Enter operation: ");
            val = Console.ReadLine();
            char a = Convert.ToChar(val);
            Calculator c = new Calculator(num1, num2, a);

            Console.ReadKey();
        }
    }
}
