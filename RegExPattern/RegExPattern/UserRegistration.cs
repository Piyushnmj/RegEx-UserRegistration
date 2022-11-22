using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegExPattern
{
    public class UserRegistration
    {
        public void FirstName()
        {
            Console.Write("\nEnter First Name: ");
            string firstName = Console.ReadLine();
            var regex = new Regex(@"^[A-Z]{1}[a-z]{2,}$");
            bool matchRes = regex.IsMatch(firstName);
            if (matchRes == true)
            {
                Console.WriteLine($"{firstName} is valid");
            }
            else
            {
                Console.WriteLine($"{firstName} is invalid. Please enter a valid First Name. First word must be capital and Name must contain minimum 3 letters.");
                FirstName();
            }
        }
    }
}
