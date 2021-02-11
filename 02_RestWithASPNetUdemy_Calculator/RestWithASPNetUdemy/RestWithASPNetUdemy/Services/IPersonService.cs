using System.Collections.Generic;

namespace RestWithASPNetUdemy.Services
{
    public interface IPersonService
    {
        IPersonService Create(IPersonService person);
        IPersonService FindByID(long id);
        IPersonService Update(IPersonService person);
        void Delete(long id);
        List<IPersonService> FindAll();
    }
}
