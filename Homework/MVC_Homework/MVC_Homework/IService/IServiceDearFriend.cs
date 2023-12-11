using MVC_Homework.DearFriend;
using MVC_Homework.Models;

namespace MVC_Homework.IService
{
    public interface IServiceDearFriend
    {
        List<Pets> GetPets();
        List<PetsCat> GetPetsCat();
        List<PetsDog> GetPetsDog();
        void AddPets(Pets pet);
        void AddPetsCat(PetsCat pet);
        void AddPetsDog(PetsDog pet);
        void AddCat(DearFriendCat pet);
        void AddDog(DearFriendDog pet);
    }
}