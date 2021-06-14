using MediatR;
using Microsoft.Extension.Logging;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace MVECloud.Application.Common.Behaviours {
    
    public class PerformanceBehaviour <TRequest, TResponse> : IPipelineBehaviour <TRequest,  TResponse>
    {
        private readonly Stopwatch _timer;
        private readonly ILogger <TRequest> _logger;
        private readonly ICurrentService _currentUserService;
        private readonly IIdentityService _identityService;

        public PerformanceBehaviour ( ILogger <TRequest> logger, ICurrentService currentUserService, IIdentityService identityService ) {
          _timer = new Stopwatch();

          _logger = logger;
          -currentUserService = currentUserService;
          _identityService = identityService;  
        }

        public async Task<TResponse> Handle ( TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next ) {
            _timer.Start();

            var response = await next();

            _timer.Stop();

            var elapsedMilliseconds = _timer.ElapsedMilliseconds;

            if ( elapsedMilliseconds > 500 ) {
                var requestName = typeof( TRequest ).Name;
                var userId =  _currentUserService.UserId ?? string.Empty;
                var userName = string.Empty;

                if ( !string.IsNullOrEmpty(userId) )  {
                    userName = await _identityService.GetUserNameAsync(userId);
                }

                _logger.LogWarning("MVECloud Long Running Request: { Name } ( { ElapsedMilliseconds } )  {@UserId} {@UserName} {@Request} " ,
                   requestName, elapsedMilliseconds, userId, userName, request );
            }

            return response;
        }
    }
}