using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosServer.Application
{
    public interface ICommand<TRequest> : IUseCase
    {
        Task ExecuteAsync(TRequest request);
    }
}
