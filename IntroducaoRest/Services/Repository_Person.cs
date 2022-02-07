using IntroducaoRest.Model;

namespace IntroducaoRest.Services
{
    public interface IRepository_Person
    {
        PersonModel Create(PersonModel person);
        PersonModel FindById(int Id);
    }
    public class Repository_Person : IRepository_Person
    {
        public PersonModel Create(PersonModel person)
        {
            return person;
        }

        public void Delete(int Id)
        {

        }
        public PersonModel FindById(int Id)
        {
            return new PersonModel
            {
                Id = 1,
                FirtName = "Joséca Finlandia",
                LastName = "Zaszgaroia",
                Address = "Passos - MG",
                Gender = "F"
            };
        }

    }
}
