using PosServer.DataAccess;
using PosServer.Domain;
using PosServer.Application;
using Serilog;
using System.Diagnostics;
using System.Text.Json;

namespace PosServer.Implementation
{
    public class UseCaseHandler
    {
        //private IApplicationUser _user;
        //private IUseCaseLogger _useCaseLogger;
        //private IExceptionLogger _exceptonLogger;
        private readonly PosServerDbContext _context;
        public UseCaseHandler(
            //IApplicationUser user,
            //IExceptionLogger exceptionLogger,
            //IUseCaseLogger useCaseLogger,
            PosServerDbContext context)
        {
            //this._user = user;
            //this._exceptonLogger = exceptionLogger;
            //this._useCaseLogger = useCaseLogger;
            this._context = context;
        }

        public async Task HandleCommandAsync<TRequest>(ICommand<TRequest> command, TRequest data)
        {
            try
            {
                HandleLoggingAndAuthorization(command, data);

                var stopwatch = new Stopwatch();
                stopwatch.Start();

                await command.ExecuteAsync(data);

                stopwatch.Stop();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<TResponse> HandleQueryAsync<TRequest, TResponse>(IQuery<TRequest, TResponse> query, TRequest data)
        {
            try
            {
                HandleLoggingAndAuthorization(query, data);

                var stopwatch = new Stopwatch();
                stopwatch.Start();

                var response = await query.ExecuteAsync(data);

                stopwatch.Stop();

                return response;
            }
            catch (Exception e)
            {
                Log.Error("Greska unutar UseCase handlera - '{exceptionMessage}' ", e.Message);
                throw;
            }
        }

        public void HandleLoggingAndAuthorization<TRequest>(IUseCase useCase, TRequest data)
        {
            //var isAuthorized = _user.UseCaseIds.Contains(useCase.Id);

            //Log.Information("UseCase: " + useCase.Name + " Data: " + JsonSerializer.Serialize(data));

            //if (!isAuthorized)
            //{
            //    throw new UnauthorizedAccessException($"Nemate privilegiju da izvrsite komandu: '{useCase.Name}'");
            //}

            //AuditLog log = new AuditLog
            //{
            //    UserId = _user.Id,
            //    UseCaseId = useCase.Id,
            //    Time = DateTime.UtcNow,
            //    IsAuthorized = isAuthorized,
            //};

            //_context.AuditLogs.Add(log);

            //_context.SaveChanges();
        }
    }
}
