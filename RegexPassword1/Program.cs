using System.ComponentModel.DataAnnotations;

namespace RegexPassword1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           PasswordCharacters passwordCharacters = new PasswordCharacters();
            passwordCharacters.Password();
        }
    }
}