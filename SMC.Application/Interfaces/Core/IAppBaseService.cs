using SMC.Application.ViewModel.Core;
using System.Collections.Generic;

namespace SMC.Application.Interfaces.Core
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