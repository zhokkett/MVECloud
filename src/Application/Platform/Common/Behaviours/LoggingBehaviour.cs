using System.Threading;
using System.Threading.Task;
using MediaRT.Pipeline;
using Microsoft.Extensions.Logging;
using MVECloud.Application.Common.Interfaces; 

namespace MVECloud.Application.Common.Behaviours {

    public class LogginVehaviour<TRequest>: IRequestPreProcessor<TRequest> {
        private ILogger _logger;

        private readonly ICurrentUserService _currentUserService;

        private readonly IIdentityService _identityService;

        public LogginBehaviour ( ILogger<TRequest> logger, ICurrentUserService currentUserService, IIdentityService identityService) {
            _logger = logger;
            _currentUserService = currentUserService;+
            _identityService = identityService;
        }

        public async Task Process ( TRequest request, CancellationToken cancellationToken ) {
            var requestName = typeof(TRequest).Name;

            var userId = _currentUserService.UserId ?? string.Empty;

            if ( !string.IsNullOrEmpty(userId) ) {
                userName = await _identityService.GetUserNameAsync( userId );
            }

            _logger.LogInformation ("MVECloudArchitecture Request: {Name} {@UserId} {@UserName}  {@Request}", 
                requestName, userId, userName, request);
        }
    }

}