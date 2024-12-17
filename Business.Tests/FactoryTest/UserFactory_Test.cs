
using Business.Factories; // Se till att detta namespace är importerat
using Business.Models;    // För att få tillgång till User-klassen
using Xunit;

namespace Business.Tests.Factories;

public class UserFactory_Test
{
    [Fact]
    public void Create_ShouldReturnNewUser()
    {
        // Arrange
        
        
        // Act
        var user = UserFactory.Create(); // Anropa den statiska Create-metoden från UserFactory

        // Assert
        Assert.NotNull(user);             // Kontrollera att objektet inte är null
        Assert.IsType<User>(user);        // Kontrollera att objektet är av typen User
        
    }

    
}

