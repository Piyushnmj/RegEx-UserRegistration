namespace RegExPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expressions");
            Console.WriteLine("\n==========User Registration Form==========");

            UserRegistration objUser = new UserRegistration();
            objUser.FirstName();
            objUser.LastName();
            objUser.Email();
            objUser.PhoneNumber();
        }
    }
}