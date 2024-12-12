/*using Business.Models;
using Business.Factories;
using System;

namespace Business.Tester.Factories
{
    public class UserFactoryTester
    {
        public static bool Create_ShouldReturnNewUser()
        {
            // Act
            var user = UserFactory.Create();

            // Kontrollera att objektet inte är null och är av rätt typ
            if (user == null || user.GetType() != typeof(User))
            {
                Console.WriteLine("Test failed: UserFactory.Create() returned null or wrong type.");
                return false;
            }

            // Kontrollera att egenskaperna har rätt standardvärden
            if (user.FirstName != null || user.LastName != null || user.Email != null ||
                user.PhoneNumber != null || user.StreetName != null || user.PostCode != null ||
                user.City != null)
            {
                Console.WriteLine("Test failed: UserFactory.Create() returned a User object with unexpected values.");
                return false;
            }

            Console.WriteLine("Test passed: UserFactory.Create() returned a valid User object with default values.");
            return true;
        }

        public static void Main(string[] args)
        {
            bool result = Create_ShouldReturnNewUser();

            if (result)
            {
                Console.WriteLine("All tests passed.");
            }
            else
            {
                Console.WriteLine("Some tests failed.");
            }
        }
    }
}*/



