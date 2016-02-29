using SGA.Application.ViewModel.Core;
using System.Collections.Generic;

namespace SGA.Application.Interfaces.Core
{
    public interface IAppBaseService<TViewModel> where TViewModel : BaseViewModel
    {
        void Add(TViewModel obj);

        TViewModel GetById(int id);

        IEnumerable<TViewModel> GetAll();

        void Update(TViewModel obj);

        void Remove(int id);

        void Dispose();
    }
}