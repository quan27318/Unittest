using UnitTest.Models;
namespace UnitTest.Responsitory{
    public interface IPersonResponsitory{
        public List<Person> GetAll();
        public void Create(Person per);
    }
}