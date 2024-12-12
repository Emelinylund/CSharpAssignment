using Business.Interfaces;
using Business.Models;
using Business.Services;

public class MenuService 
{
    private readonly UserService _userService;

    public MenuService(UserService userService)
    {
        _userService = userService; 
    }

    public void RunMenu()
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            ShowMenuOptions();

            string choice = Console.ReadLine()!;
            switch (choice)
            {
                case "1":
                    CreateUserDialog();
                    break;

                case "2":
                    ViewAllUsersDialog();
                    break;

                case "3":
                    running = false;
                    Console.WriteLine("Exiting program...");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Invalid option, try again.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    private void ShowMenuOptions()
    {
        Console.WriteLine("####### MAIN MENU #######");
        Console.WriteLine("1. Add new user:");
        Console.WriteLine("2. View all users:");
        Console.WriteLine("3. Exit program:");
        Console.Write("Select option: ");
    }

    private void CreateUserDialog()
    {
        User user = new()
        {
            FirstName = GetUserInput("Enter your first name: "),
            LastName = GetUserInput("Enter your last name: "),
            Email = GetUserInput("Enter your e-mail: "),
            PhoneNumber = GetUserInput("Enter your phonenumber: "),
            StreetName = GetUserInput("Enter your streetname: "),
            PostCode = GetUserInput("Enter your postcode: "),
            City = GetUserInput("Enter your city: ")
        };

        _userService.Add(user);
        Console.WriteLine("User has been added!");
        
    }

    private void ViewAllUsersDialog()
    {
        Console.Clear();
        List<User> users = _userService.GetAllUsers();

        if (users.Count == 0)
        {
            Console.WriteLine("No users to show.");
        }
        else
        {
            Console.WriteLine("Registered users:");
            foreach (var u in users)
            {
                Console.WriteLine($"{"Id:",-15}{u.Id}");
                Console.WriteLine($"{"Fullname:",-15}{u.FullName}");
                Console.WriteLine($"{"E-mail:",-15}{u.Email}");
                Console.WriteLine($"{"Phonenumber:",-15}{u.PhoneNumber}");
                Console.WriteLine($"{"Streetname:",-15} {u.StreetName}");
                Console.WriteLine($"{"Postcode:",-15}{u.PostCode}");
                Console.WriteLine($"{"City:",-15} {u.City}");
                Console.WriteLine();
            }
        }
        Console.ReadKey();
    }

    private string GetUserInput(string prompt)
    {
        string input;
        do
        {
            Console.Write(prompt);
            input = Console.ReadLine()!;
            if (!InputValidator.IsValidInput(input, out string errorMessage))
            {
                Console.WriteLine($"Error: {errorMessage}");
                continue;
            }

            // Generated with chat GTP
            input = InputValidator.ToLowerCase(input);

            break;

        } while (true);

        return input;
    }
}

