using UnitTest.Models;
namespace UnitTest.Responsitory
{
    public class PersonResponsitory : IPersonResponsitory
    {
        private PersonDbContext _dbContext;
        public PersonResponsitory(PersonDbContext dbContext)
        {
            _dbContext = dbContext;
        }
       public List<Person> GetAll(){
           return _dbContext.Persons.ToList();
       }
       public void Create(Person per){
           _dbContext.Persons.Add(per);
       }
    }
}