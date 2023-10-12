using System;

namespace RegEx_Validation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter password: ");
            string password = Console.ReadLine();

            Console.Write("Please enter password: ");
            string mail = Console.ReadLine();


            string resultValidMessage = RegExValidation.PasswordIsValid(password)
                && RegExValidation.EmailIsValid(mail) ? 
                "email and password is valid" : 
                "email or password is invalid";

            Console.WriteLine(resultValidMessage);

        }
    }
}
