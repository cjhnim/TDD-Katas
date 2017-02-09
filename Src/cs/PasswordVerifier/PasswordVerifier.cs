using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Katas_project.PasswordVerifier
{
    
    class PasswordVerifier
    {
        private string Password;

        internal void Verify()
        {
            if (Password == null)
            {
                throw new PasswordVerifierException("password should not be null");
            }
            if (Password.Length <= 8)
            {
                throw new PasswordVerifierException("password should be larger than 8 chars");
            }
            if (!Password.Any(char.IsUpper)) //Todo: 문법이해하자
            {
                throw new PasswordVerifierException("password should have one uppercase letter at least");
            }
            if (!Password.Any(char.IsLower)) //Todo: 문법이해하자
            {
                throw new PasswordVerifierException("password should have one lowercase letter at least");
            }
            if (!Password.Any(char.IsNumber)) //Todo: 문법이해하자
            {
                throw new PasswordVerifierException("password should have one number at least");
            }
        }

        internal void InputPassword(string password)
        {
            Password = password;
        }
    }
}
