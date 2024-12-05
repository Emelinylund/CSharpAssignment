using System.Diagnostics;
using System.Text.Json;

namespace Business.Services;

    public class ContactService
    {
    private readonly FileService _fileService = new FileService();
    private List<User> _contactList = [];

    //Skapar en user
    public void CreateContact(User user)
    {
        user.Id = _contactList.Count > 0 ? _contactList[^1].Id + 1 : 1;

        _contactList.Add(user);

        var json = JsonSerializer.Serialize(_contactList);

        _fileService.SaveContentToFile(json);
    }

    public IEnumerable<User> GetAllUsers()
    {
        var json = _fileService.GetHashCode();

        if (!string.IsNullOrEmpty(json))
        {

            try
            {
                _contactList = JsonSerializer.Deserialize<List<User>>(json) ?? [];
            }
            catch 
            {
                _contactList = [];
            }
           
        }

       return_userList;
    }
    
    }

