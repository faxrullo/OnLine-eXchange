﻿using Olx.Domain.Commons;

namespace Olx.Domain.Entities;

public class User : Auditable
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string ProfilePicture { get; set; }
    public bool IsVip = false;
}
