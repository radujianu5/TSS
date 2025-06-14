using System;
using System.Linq;

namespace PasswordManager
{
    public class PasswordValidator
    {
        public string ValidatePassword(string? password)
        {
            if (string.IsNullOrEmpty(password))
                return "Parola nu poate fi goala.";

            if (password.Length < 8)
                return "Parola este prea scurta.";

            if (!password.Any(char.IsUpper))
                return "Parola trebuie sa contina cel putin o litera mare.";

            if (!password.Any(char.IsDigit))
                return "Parola trebuie sa contina cel putin o cifra.";

            if (!password.Any(ch => "!@#$%^&*".Contains(ch)))
                return "Parola trebuie sa contina cel putin un caracter special (!@#$%^&*).";

            return "Parola este valida.";
        }
    }
}
