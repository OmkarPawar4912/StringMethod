using System;
using System.Collections.Generic;
using System.Text;

namespace StringMethod
{
    class ExceptionsHandling
    {
        public void division(int num1, int num2)
        {
            try
            {
                int result = num1 / num2;
            }
            catch (Exception)
            {
                Console.WriteLine("Exception caught: Cannot divide by zero. Please try again.");
            }
        }
        public void MultipleException()
        {
            try
            {
                int num = 0;
                int result = 100 / num;

                Console.WriteLine("100 / {0} = {1}", num, result);
            }
            catch (InvalidOperationException ex)
            {
                Console.Write("Invalid operation. Please try again.");
            }
            catch (FormatException ex)
            {
                Console.Write("Not a valid format. Please try again.");
            }
            catch (DivideByZeroException ex)
            {
                Console.Write("Cannot divide by zero. Please try again.");
            }
            catch (Exception ex)
            {
                Console.Write("Error occurred! Please try again.");
            }
            Console.WriteLine();
        }
        public void FinallyException()
        {
            try
            {
                int num = 0;
                int result = 100 / num;

                Console.WriteLine("100 / {0} = {1}", num, result);
            }
            catch (InvalidOperationException ex)
            {
                Console.Write("Invalid operation. Please try again.");
            }
            catch (FormatException ex)
            {
                Console.Write("Not a valid format. Please try again.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero. Please try again.");
            }
            catch (Exception ex)
            {
                Console.Write("Error occurred! Please try again.");
            }
            finally
            {
                Console.WriteLine();
                Console.Write("finally Block is Excuted...");
                Console.WriteLine();
            }           
        }
    }
}