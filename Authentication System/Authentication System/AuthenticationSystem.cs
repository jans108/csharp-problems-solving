using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Authentication_System;

public class Authenticator
{
    private class EyeColor
    {
        public const string Blue = "blue";
        public const string Green = "green";
        public const string Brown = "brown";
        public const string Hazel = "hazel";
        public const string Grey = "grey";
    }

    public Authenticator(Identity admin)
    {
        this.admin = admin;
    }

    private readonly Identity admin;

    private readonly IReadOnlyDictionary<string, Identity> developers
        = new ReadOnlyDictionary<string, Identity>(
            new Dictionary<string, Identity>
            {
                ["Bertrand"] = new Identity("bert@ex.ism", EyeColor.Blue),
                ["Anders"] = new Identity("anders@ex.ism", EyeColor.Brown)
            }
        );

    public Identity Admin
    {
        get { return admin; }
    }

    public IReadOnlyDictionary<string, Identity> GetDevelopers()
    {
        return developers;
    }
}

public struct Identity
{
    public string Email { get; }
    public string EyeColor { get; }

    public Identity(string email, string eyeColor)
    {
        Email = email;
        EyeColor = eyeColor;
    }
}
