using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyPetStore
{
    public class Pet
    {
        public string PetName { get; set; }
        public string PetType { get; set; }
        public int PetAge { get; set; }
        public decimal PetPrice { get; set; }
        public string PetPower { get; set; }

        public Pet()
        {
            PetName = string.Empty;
            PetType = string.Empty;
            PetAge = 0;
            PetPrice = 0;
            PetPower = string.Empty;
        }

        public Pet(string petName, string petType, int petAge, decimal petPrice, string petPower)
        {
            PetName = petName;
            PetType = petType;
            PetAge = petAge;
            PetPrice = petPrice;
            PetPower = petPower;
        }

        public static string describePet(Pet pet)
        {
            return $"Your pet, {pet.PetName}, is a {pet.PetType}. They are {pet.PetAge} years old. A description of its magical power follows: \"{pet.PetPower}\"";
        }
        public static string discountPrice(Pet pet, decimal percent)
        {
            return (pet.PetPrice * percent).ToString("C2");
        }
        public static string performMagic(Pet pet)
        {
            return $"Your pet, {pet.PetName}, wonderfully performs its magical act of {pet.PetPower.ToLower()}!";
        }
    }
}
