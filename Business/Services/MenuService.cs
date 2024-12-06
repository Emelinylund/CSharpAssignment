using Business.Models;

namespace Business.Services;

public class MenuService
{
    private readonly UserService _contactService = new();
    private object _userService;

    public void CreateUserDialog()
    {
        Console.Clear();

        var user = new User();

        Console.Write("Enter your first name: ");
        user.FirstName = Console.ReadLine()!;

        Console.Write("Enter your last name: ");
        user.LastName = Console.ReadLine()!;

        Console.Write("Enter your e-mail: ");
        user.Email = Console.ReadLine()!;

        Console.Write("Enter your phonenumber: ");
        user.PhoneNumber = Console.ReadLine()!;

        Console.Write("Enter your streetname: ");
        user.StreetName = Console.ReadLine()!;

        Console.Write("Enter your postcode: ");
        user.PostCode = Console.ReadLine()!;

        Console.Write("Enter your city: ");
        user.City = Console.ReadLine()!;

        _userService.Add(user);
    }

    public void ViewAllUsersDialog()
    {
        Console.Clear();

        var users = _userService.GetAll();
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

        Console.ReadKey();
    }
}


