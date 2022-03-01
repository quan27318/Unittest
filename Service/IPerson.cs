using UnitTest.Models;
using UnitTest.Responsitory;
namespace UnitTest.Service{
    public interface IPerson{
        public List<Person> GetAll();
        public void Create(Person per);
    }
}