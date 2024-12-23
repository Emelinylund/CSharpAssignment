﻿using Business.Models;
using System.Text.Json;
using System.Diagnostics;
using Business.Interfaces;


namespace Business.Services;
public class FileService : IFileService 
{

    private readonly string _directoryPath;
    private readonly string _filePath;
    private readonly JsonSerializerOptions _jsonSerializerOptions;

    public FileService(string directoryPath = "Data", string fileName = "list.json")
    {
        _directoryPath = directoryPath;
        _filePath = Path.Combine(_directoryPath, fileName);
        _jsonSerializerOptions = new JsonSerializerOptions { WriteIndented = true };


    }

    public string GetContentFromFile()
    {
        if (File.Exists(_filePath))
            return File.ReadAllText(_filePath);

        return null!;
    }
    public void SaveListToFile(List<User> list)
    {
        try
        {
            if(!Directory.Exists(_directoryPath))
            Directory.CreateDirectory(_directoryPath);

            var json = JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true});
            File.WriteAllText(_filePath, json);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }
    }

    public List<User> LoadListFromFile()
    {
        try
        {
            if (!File.Exists(_filePath))
                return [];
            
            var json = File.ReadAllText(_filePath);
            var list = JsonSerializer.Deserialize<List<User>>(json, _jsonSerializerOptions);
            return list ?? [];
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return [];
        }
    }

    public void SaveToFile(List<User> users)
    {
        throw new NotImplementedException();
    }
}
    

