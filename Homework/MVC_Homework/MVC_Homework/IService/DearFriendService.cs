using MVC_Homework.DearFriend;
using MVC_Homework.Models;

namespace MVC_Homework.IService
{
    public class DearFriendService : IServiceDearFriend
    {
        public List<Pets> PetsList { get; set; }
        public List<PetsDog> DearFriendPetsDogList { get; set; }
        public List<PetsCat> DearFriendPetsCatList { get; set; }
        public List<DearFriendPets> DearFriendPetsList { get; set; }
        public List<DearFriendDog> DearFriendDogList { get; set; }
        public List<DearFriendCat> DearFriendCatList { get; set; }

        public DearFriendService()
        {
            PetsList = new List<Pets>();
            DearFriendPetsDogList = new List<PetsDog>();
            DearFriendPetsCatList = new List<PetsCat>();
            DearFriendPetsList = new List<DearFriendPets>();
            DearFriendDogList = new List<DearFriendDog>();
            DearFriendCatList = new List<DearFriendCat>();
            var pets1 = DearFriendCat.Name.Count;
            var pets2 = DearFriendPets.Name.Count;
            GenerateProduct(pets1, pets2);
        }

        void GenerateProduct(int number1,int number2)
        {
            for (int i = 0; i < number1; i++)
            {
                DearFriendPetsDogList.Add(new PetsDog
                {
                    Name = DearFriendDog.Name[i],
                    Img = DearFriendDog.Img[i],
                    Description = DearFriendDog.Description[i],
                    Overview = DearFriendDog.Overview[i],
                    Character = DearFriendDog.Character[i]
                });
                DearFriendPetsCatList.Add(new PetsCat
                {
                    Name = DearFriendCat.Name[i],
                    Img = DearFriendCat.Img[i],
                    Description = DearFriendCat.Description[i],
                    Overview = DearFriendCat.Overview[i],
                    Character = DearFriendCat.Character[i]
                });
            }
            for (int i = 0; i < number2; i++)
            {
                PetsList.Add(new Pets
                {
                    Id = i + 1,
                    Name = DearFriendPets.Name[i],
                    Img = DearFriendPets.Img[i],
                });
            }
        }

        public List<Pets> GetPets()
        {
            return PetsList;
        }

        public List<PetsCat> GetPetsCat()
        {
            return DearFriendPetsCatList;
        }

        public List<PetsDog> GetPetsDog()
        {
            return DearFriendPetsDogList;
        }

        public void AddPets(Pets pet)
        {
            PetsList.Add(pet);
        }

        public Pets SearchProduct(int id)
        {
            return PetsList.Find(x => x.Id == id);
        }

        public void DeletePets(int id)
        {
            var resul = SearchProduct(id);
            if (resul != null) { PetsList.Remove(resul); }
        }

        public void UpdatePets(Pets pets)
        {
            var oldPets = PetsList.Find(p => p.Id == pets.Id);
            var index = PetsList.IndexOf(oldPets);
            if (index != -1)
            {
                PetsList.RemoveAt(index);
                PetsList.Insert(index, pets);
            }
        }
    }
}
