using RestWithASPNetUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNetUdemy.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindByID(long id);
        Person Update(Person person);
        void Delete(long id);
        List<Person> FindAll();
    }
}
