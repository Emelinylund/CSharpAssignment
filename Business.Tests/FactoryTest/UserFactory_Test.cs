
using Business.Factories;
using Business.Models;   
using Xunit;

namespace Business.Tests.Factories;

public class UserFactory_Test
{
    [Fact]
    public void Create_ShouldReturnNewUser()
    {
        
        var user = UserFactory.Create(); 

        
        Assert.NotNull(user);             
        Assert.IsType<User>(user);        
        
    }

    
}

