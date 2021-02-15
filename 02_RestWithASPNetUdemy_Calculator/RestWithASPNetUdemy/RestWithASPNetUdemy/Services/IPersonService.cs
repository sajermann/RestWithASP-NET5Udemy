using RestWithASPNetUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNetUdemy.Services
{
    public interface IPersonService
    {
        IPersonService Create(Person person);
        IPersonService FindByID(long id);
        IPersonService Update(Person person);
        void Delete(long id);
        List<IPersonService> FindAll();
    }
}
