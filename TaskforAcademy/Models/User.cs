using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskforAcademy.Models
{
    internal class User
    {
        public string UserName;
        string _password;
        private bool _isSignedIn;
        public string Products;


        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value.Length >= 8 && value.Length <= 20)
                {
                    _password = value;
                }
            }
        }
        public bool IsSignedIn 
        {
            get
            {
                return _isSignedIn;
            }
            set
            {
                if (CheckPassword(value) == true)
                {
                    _isSignedIn = true;
                }
            }
        }
        

        public (string,bool) CheckPassword(string text)
        {
            if (HasDigit(text) == true && HasLower(text) == true && HasUpper(text) ==true)
            {
                return ("Sifrenizi dogru daxil etmisiniz",true);
            }
            else
            {
                return ("Sifrenizi sehv daxil etmisiniz",false);
            }
        }
        public bool HasDigit(string text)
        {
            bool result = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    result = true;
                }
            }
            return result;

        }
        public bool HasLower(string text)
        {
            bool result = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLower(text[i]))
                {
                    result = true;
                }
            }
            return result;

        }
        public bool HasUpper(string text)
        {
            bool result = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                {
                    result = true;
                }
            }
            return result;
        }


        public User(string username, string password,string products,string password)
        {
            UserName = username;
            _password = password;
            Products = products;
        }

        
    }

}
