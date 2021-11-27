using System.Collections.Generic;
using System.Linq;
using RepositoryPatternWebApp.Models;

namespace RepositoryPatternWebApp.IRepositories
{
    public interface IMyModelRepository
    {
        void Add(MyModel myModel);

        void Delete(int id);

        IList<MyModel> GetList();

    }
}
