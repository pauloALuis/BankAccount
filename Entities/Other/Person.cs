using BankAccount.Entities.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Entities
{
    class Person
    {
        public string IdPerson { get; set; }

        private string _firstName;
        private string _lastName;
        private string _birthDate;
        private Gender _typeGener;

        public Person(string idPerson, string firstName, string lastName, string birthDate, Gender typeGener)
        {
            IdPerson = idPerson;
            _firstName = firstName;
            _lastName = lastName;
            _birthDate = birthDate;
            _typeGener = typeGener;
        }

        public string FullName { 
            get { return _firstName +" "+ _lastName;  }
            set
            {   string s = value;

                string[] words = s.Split(' ');
                _firstName  = words[0];
                for (int i = 1; i < words.Length; i++)
                {
                    _lastName += " " + words[i];
                }
            }

        }

        public override string ToString()
        {
            return $"Person ({IdPerson}, {FullName}, {_birthDate}, {_typeGener})";
        }
    }
}
