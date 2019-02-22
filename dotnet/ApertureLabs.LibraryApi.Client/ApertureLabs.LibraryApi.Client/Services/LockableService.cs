using System;
using System.Collections.Generic;
using System.Net.Http;
using LibraryServerApi.Models.Lockable;

namespace ApertureLabs.LibraryApi.Client.Services
{
    public class LockableService
    {
        #region Fields

        private readonly ApiService apiService;

        #endregion

        #region Constructor

        public LockableService(ApiService apiService)
        {
            this.apiService = apiService;
        }

        #endregion

        #region Methods

        public LockResponse Lock(LockRequest lockRequest)
        {
            return apiService.SendAndConvert<LockResponse, LockRequest>(
                HttpMethod.Post,
                new Uri("api/lockable/lock"),
                lockRequest);
        }

        public LockResponse RetrieveReadonly(IEnumerable<string> categories)
        {
            return apiService.SendAndConvert<LockResponse, IEnumerable<string>>(
                HttpMethod.Post,
                new Uri("api/lockable/retrievereadwrite"),
                categories);
        }

        public LockResponse RetrieveReadWrite(IEnumerable<string> categories)
        {
            return apiService.SendAndConvert<LockResponse, IEnumerable<string>>(
                HttpMethod.Post,
                new Uri("api/lockable/retrievereadwrite"),
                categories);
        }

        public UnlockResponse Unlock(UnlockRequest unlockRequest)
        {
            return apiService.SendAndConvert<UnlockResponse, UnlockRequest>(
                HttpMethod.Post,
                new Uri("api/lockable/unlock"),
                unlockRequest);
        }

        #endregion
    }
}
