using Business.Models;
using System.Collections.Generic;

namespace Business.Services;

    public class UserService
    {

    private List<User> _users = [];
    private readonly FileService _fileService = new(); 
   
        public void Add(User user)
        {
        
        _users.Add(user);
        _fileService.SaveListToFile(_users);

        
        }

        public IEnumerable<User> GetAll()
        {
          _users = _fileService.LoadListFromFile();
          return _users;
        }

    public List<User> GetAllUsers()
    {
        _users = _fileService.LoadListFromFile();
        return _users;
    }

    public IEnumerable<User> GetUsers()
    {
        throw new NotImplementedException();
    }
}

