using Business.Models;
using Business.Services;

namespace Business.Interfaces;

public interface IFileService
{
    void SaveToFile(List<User> users);
    List<User> LoadListFromFile();
}
