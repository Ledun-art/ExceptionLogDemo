using System;

namespace HandleException
{
    public class Exceptions : Program
    {
        public Exceptions()
        {
            HandleException(() =>
            {
                ExampleMethod();
            });
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine("Example Exception Message :" + " " + exception.Message);
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (ArithmeticException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (ArrayTypeMismatchException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (InvalidCastException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (StackOverflowException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (OutOfMemoryException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}