﻿using System.Collections.Specialized;

namespace Business.Models;

public class User
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string StreetName { get; set; } = null!;

    public string PostCode { get; set; } = null!;

    public string City { get; set; } = null!;

    public string FullName => $"{FirstName} {LastName}";
}
 