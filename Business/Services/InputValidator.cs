
namespace Business.Services;

internal class InputValidator
{
    // Used chat GTP with this code 
    public static bool IsValidInput(string input, out string errorMessage)
    {
        errorMessage = string.Empty;

        if (string.IsNullOrWhiteSpace(input))
        {
            errorMessage = "Input cannot be empty or whitespace.";
            return false;
        }

        if (ContainsInvalidCharacters(input))
        {
            errorMessage = "Input contains invalid characters.";
            return false;
        }

        return true;
    }

    
    public static string ToLowerCase(string input)
    {
        return input.ToLowerInvariant();
    }

    
    private static bool ContainsInvalidCharacters(string input)
    {
        
        char[] forbiddenChars = {'#', '$', '%', '^', '&', '*', '(', ')', '!' };
        return input.IndexOfAny(forbiddenChars) != -1;
    }
}

