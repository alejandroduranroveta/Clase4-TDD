using System.Text.RegularExpressions;

namespace Clase_4;

public class PasswordValidator
{
    public bool validatePassword(string password)
    {
        if (password.Length < 6 || password.Length > 12)
        {
            return false;
        }

        if (!Regex.IsMatch(password, @"\d"))
        {
            return false;
        }

        if (!Regex.IsMatch(password, @"[A-Z]"))
        {
            return false;
        }

        return true;

    }
}