namespace Business.Services;

    public class FileService
    {
    private readonly string _directoryPath;
    private readonly string _filepath;

    public FileService(string directoryPath = "Data", string fileName = "list.json")
    {
        _directoryPath = directoryPath;
        _filepath = Path.Combine(directoryPath, fileName);
    }

    // Sparar till fil
    public void SaveContentToFile(string content)
    {
        if (!string.IsNullOrEmpty(content))
        {

            if (!Directory.Exists(_directoryPath))

                File.WriteAllText(_filepath, content);
        }
    }

    //Hämtar från filen
        Public string? GetContentFromFile()
        {
            if (File.Exists(_filepath))
                return File.ReadAllText(_filepath);

            return null;
        }
    }

