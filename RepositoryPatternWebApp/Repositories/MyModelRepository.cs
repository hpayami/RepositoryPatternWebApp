using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using RepositoryPatternWebApp.IRepositories;
using RepositoryPatternWebApp.Models;

namespace RepositoryPatternWebApp.Repositories
{
    public class MyModelRepository: IMyModelRepository
    {
        private readonly List<MyModel> _myModels = new List<MyModel>();

        public void Add(MyModel myModel)
        {
            _myModels.Add(myModel);
        }

        public void Delete(int id)
        {
            foreach (var myModel in _myModels)
            {
                if (myModel.Id == id)
                    _myModels.Remove(myModel);
            }

        }

        public IList<MyModel> GetList()
        {
            return _myModels.ToList();
        }
    }
}
