using MVC_Homework.DearFriend;
using MVC_Homework.Models;

namespace MVC_Homework.IService
{
    public class DearFriendService : IServiceDearFriend
    {
        public List<Pets> DearFriendPetsList {  get; set; }
        public List<PetsDog> DearFriendPetsDogList { get; set; }
        public List<PetsCat> DearFriendPetsCatList { get; set; }
        public List<DearFriendCat> DearFriendCatList { get; set; }
        public List<DearFriendDog> DearFriendDogList { get; set; }

        public DearFriendService()
        {
            DearFriendPetsList = new List<Pets>();
            DearFriendPetsDogList = new List<PetsDog>();
            DearFriendPetsCatList = new List<PetsCat>();
            DearFriendCatList = new List<DearFriendCat>();
            DearFriendDogList = new List<DearFriendDog>();
            GenerateProduct(4);
        }

        void GenerateProduct(int number)
        {
            Random r = new Random();
            var pets = DearFriendCat.Name.Count;
            int I = 0;
            for (int i = 0; i < number; i++)
            {
                if ( I == pets) { I = 0; }
                DearFriendPetsDogList.Add(new PetsDog
                {
                    Name = DearFriendDog.Name[I],
                    Img = DearFriendDog.Img[I],
                    Description = DearFriendDog.Description[I],
                    Overview = DearFriendDog.Overview[I],
                    Character = DearFriendDog.Character[I]
                });
                I++;
            }
            for (int i = 0; i < number; i++)
            {
                if (I == pets) { I = 0; }
                DearFriendPetsCatList.Add(new PetsCat
                {
                    Name = DearFriendCat.Name[I],
                    Img = DearFriendCat.Img[I],
                    Description = DearFriendCat.Description[I],
                    Overview = DearFriendCat.Overview[I],
                    Character = DearFriendCat.Character[I]
                });
                I++;
            }
        }

        public void AddPets(Pets pet)
        {
            DearFriendPetsList.Add(pet);
        }

        public void AddCat(DearFriendCat pet)
        {
            DearFriendCatList.Add(pet);
        }

        public void AddDog(DearFriendDog pet)
        {
            DearFriendDogList.Add(pet);
        }

        public void AddPetsCat(PetsCat pet)
        {
            DearFriendPetsCatList.Add(pet);
        }

        public void AddPetsDog(PetsDog pet)
        {
            DearFriendPetsDogList.Add(pet);
        }

        public List<Pets> GetPets()
        {
            return DearFriendPetsList;
        }

        public List<PetsCat> GetPetsCat()
        {
            return DearFriendPetsCatList;
        }

        public List<PetsDog> GetPetsDog()
        {
            return DearFriendPetsDogList;
        }
    }
}
