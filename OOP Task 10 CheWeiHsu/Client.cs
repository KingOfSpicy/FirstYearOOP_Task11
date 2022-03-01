using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task_10_CheWeiHsu
{
    class Client
    {
        public Client(int id, string firstName, string familyName, string telephoneNumber, string email, string preferredType, double maxRentPossible)
        {
            Id = id;
            FirstName = firstName;
            FamilyName = familyName;
            TelephoneNumber = telephoneNumber;
            Email = email;
            PreferredType = preferredType;
            MaxRentPossible = maxRentPossible;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }
        public string PreferredType { get; set; }
        public double MaxRentPossible { get; set; }
    }
}
