using Business.Models;

namespace Business.Interfaces;

public interface IUserService
{
    void CreateNewUser (List<User> userList);
    void ViewAllUsers (List<User> userList);

}

//bool CreateContact(User contact);
   // IEnumerable<User> GettAllUsers();