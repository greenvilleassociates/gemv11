using System;


namespace GEMAPI.Models;

public class UserCred
{
    public int Id { get; set; }

    public int UserId { get; set; }  // Foreign key linking to `User` table

    public string EncryptedPassword { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
