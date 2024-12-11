using Business.Services;

class Program
{
    static void Main(string[] args)
    {
        
        var userService = new UserService();

        
        var menuService = new MenuService(userService);

        
        menuService.RunMenu();
    }
}

