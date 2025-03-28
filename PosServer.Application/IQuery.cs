using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosServer.Application
{
    public interface IQuery<TRequest, TResponse> : IUseCase
    {
        Task<TResponse> ExecuteAsync(TRequest request);
    }
}
