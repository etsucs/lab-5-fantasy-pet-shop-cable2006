using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FantasyPetStore
{
    public class PetShop
    {
        private static List<Pet> PetList = new();
        public static void addPet(Pet pet)
        {
            PetShop.PetList.Add(pet);
            Console.WriteLine($"Your pet, {pet.PetName}, has been added to the shop!");
        }
        public static void listPets()
        {
            int i = 1;
            foreach (Pet pet in PetList)
            {
                Console.WriteLine($"Pet #{i++}. " + Pet.describePet(pet));
            }
        }
    }
}
