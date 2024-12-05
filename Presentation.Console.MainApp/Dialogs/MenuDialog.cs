using Business.Models;


List<User> users = new List<User>();
bool running = true;

while (running)
{
    Console.Clear();
    Console.WriteLine("Choose an alternative then press enter:");
    Console.WriteLine("1. Add new user:");
    Console.WriteLine("2. View all users:");
    Console.WriteLine("3. Exit program:");

    string choice = Console.ReadLine()!;

    switch (choice)

    {
        case "1":

            User user = new();
            user.Id = Guid.NewGuid();

            do
            {
                Console.Write("Enter your first name: ");
                user.FirstName = Console.ReadLine()!;

                if (string.IsNullOrEmpty(user.FirstName))
                {
                    Console.WriteLine("You have to enter a first name.");
                    Console.ReadKey();

                }
            }
            while (string.IsNullOrEmpty(user.FirstName));


            do
            {
                Console.Write("Eneter your last name: ");
                user.LastName = Console.ReadLine()!;

                if (string.IsNullOrEmpty(user.LastName))
                {
                    Console.WriteLine("You have to enter a last name.");
                    Console.ReadKey();

                }
            }
            while (string.IsNullOrEmpty(user.LastName));


            do
            {
                Console.Write("Eneter your e-mail: ");
                user.Email = Console.ReadLine()!;

                if (string.IsNullOrEmpty(user.Email))
                {
                    Console.WriteLine("You have to enter a e-mail.");
                    Console.ReadKey();

                }
            }
            while (string.IsNullOrEmpty(user.Email));


            do
            {
                Console.Write("Eneter your phonenumber: ");
                user.PhoneNumber = Console.ReadLine()!;

                if (string.IsNullOrEmpty(user.PhoneNumber))
                {
                    Console.WriteLine("You have to enter a phonenumber.");
                    Console.ReadKey();

                }
            }
            while (string.IsNullOrEmpty(user.PhoneNumber));


            do
            {
                Console.Write("Eneter your streetname: ");
                user.StreetName = Console.ReadLine()!;

                if (string.IsNullOrEmpty(user.StreetName))
                {
                    Console.WriteLine("You have to enter a streetname.");
                    Console.ReadKey();

                }
            }
            while (string.IsNullOrEmpty(user.StreetName));


            do
            {
                Console.Write("Eneter your postcode: ");
                user.PostCode = Console.ReadLine()!;

                if (string.IsNullOrEmpty(user.PostCode))
                {
                    Console.WriteLine("You have to enter a postcode.");
                    Console.ReadKey();

                }
            }
            while (string.IsNullOrEmpty(user.PostCode));


            do
            {
                Console.Write("Eneter your city: ");
                user.City = Console.ReadLine()!;

                if (string.IsNullOrEmpty(user.City))
                {
                    Console.WriteLine("You have to enter a city.");
                    Console.ReadKey();

                }
            }

            while (string.IsNullOrEmpty(user.City));

            users.Add(user);

            Console.WriteLine("Användaren har lagts till!");
            Console.ReadKey();
            break;

        case "2":

            if (users.Count == 0)
            {
                Console.WriteLine("No users to show.");
            }
            else
            {
                Console.WriteLine("Registerd users:");
                foreach (var u in users)
                {
                    Console.WriteLine($"{"Id:",-15}{u.Id}");
                    Console.WriteLine($"{"Fullname:",-15}{u.FullName}");
                    Console.WriteLine($"{"E-mail:",-15}{u.Email}");
                    Console.WriteLine($"{"Phonenumber:",-15}{u.PhoneNumber}");
                    Console.WriteLine($"{"Streetname:",-15} {u.StreetName}");
                    Console.WriteLine($"{"Postcode:",-15}{u.PostCode}");
                    Console.WriteLine($"{"City:",-15} {u.City}");
                    Console.WriteLine("");
                }
            }
            Console.ReadKey();
            break;

        case "3":

            running = false;
            Console.WriteLine("Exits");
            break;

        default:
            Console.WriteLine("Invalid election, try again");
            Console.ReadKey();
            break;
    }
}

