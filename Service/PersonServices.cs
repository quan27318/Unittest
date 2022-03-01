using UnitTest.Models;
using UnitTest.Responsitory;
namespace UnitTest.Service{
    public class PersonServices : IPerson{
        private readonly IPersonResponsitory _responsitory;
        public PersonServices(IPersonResponsitory responsitory)
        {
            _responsitory = responsitory;
        }
        public List<Person> GetAll(){
            return _responsitory.GetAll();
        }
        public void Create(Person per){
            _responsitory.Create(per);
        }
    }
}