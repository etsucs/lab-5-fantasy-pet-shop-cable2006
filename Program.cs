using System;
using System.Linq;

namespace FantasyPetStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Pet instancing
            Pet famyGuy = new("Peter", "Griffin", 1200, 12.90m, "Flight and spectral fire breath");
            Pet louie = new("Louie", "Rat", int.MaxValue, decimal.MaxValue, "Rides on your head and mind controls you");
            Pet hankie = new("Hanky", "Dachshund but awesomesauce", 2, 3.50m, "Fatass dog that can eat anything");
            Pet missingno = new();
            // Describing the pets
            Console.WriteLine(Pet.describePet(famyGuy));
            Console.WriteLine(Pet.describePet(louie));
            Console.WriteLine(Pet.describePet(hankie));
            Console.WriteLine(Pet.describePet(missingno));
            // Pet discounts @ 50% off
            Console.WriteLine(Pet.discountPrice(famyGuy, .5m));
            Console.WriteLine(Pet.discountPrice(louie, .5m));
            Console.WriteLine(Pet.discountPrice(hankie, .5m));
            Console.WriteLine(Pet.discountPrice(missingno, .5m));
            // Magic!!!
            Console.WriteLine(Pet.performMagic(famyGuy));
            Console.WriteLine(Pet.performMagic(louie));
            Console.WriteLine(Pet.performMagic(hankie));
            Console.WriteLine(Pet.performMagic(missingno));
            // Add the pets to the shop
            PetShop.addPet(famyGuy);
            PetShop.addPet(louie);
            PetShop.addPet(hankie);
            PetShop.addPet(missingno);
            // And list all the pets.
            PetShop.listPets();
        }
    }
}