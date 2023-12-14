using MVC_Homework.DearFriend;
using MVC_Homework.Models;

namespace MVC_Homework.IService
{
    public interface IServiceDearFriend
    {
        List<Pets> GetPets();
        List<PetsCat> GetPetsCat();
        List<PetsDog> GetPetsDog();
        Pets SearchProduct(int id);
        void AddPets(Pets pet);
        void DeletePets(int id);
        void UpdatePets(Pets pets);
    }
}