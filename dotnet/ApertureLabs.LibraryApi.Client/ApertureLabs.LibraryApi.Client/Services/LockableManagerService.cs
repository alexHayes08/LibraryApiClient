using System;
using System.Collections.Generic;
using System.Net.Http;
using LibraryServerApi.Models.Lockable;

namespace ApertureLabs.LibraryApi.Client.Services
{
    public class LockableManagerService
    {
        #region Fields

        private readonly ApiService apiService;

        #endregion

        #region Constructor

        public LockableManagerService(ApiService apiService)
        {
            this.apiService = apiService;
        }

        #endregion

        #region Methods

        public Lockable Create(Lockable lockable)
        {
            return apiService.SendAndConvert<Lockable, Lockable>(
                HttpMethod.Post,
                new Uri("api/lockable/create", UriKind.Relative),
                lockable);
        }

        public IEnumerable<Lockable> CreateMany(IEnumerable<Lockable> lockables)
        {
            return apiService.SendAndConvert<IEnumerable<Lockable>, IEnumerable<Lockable>>(
                HttpMethod.Post,
                new Uri("api/lockable/createmany"),
                lockables);
        }

        public Lockable Update(Lockable lockable)
        {
            return apiService.SendAndConvert<Lockable, Lockable>(
                HttpMethod.Put,
                new Uri("api/lockable/update"),
                lockable);
        }

        public IEnumerable<Lockable> UpdateMany(IEnumerable<Lockable> lockables)
        {
            return apiService.SendAndConvert<IEnumerable<Lockable>, IEnumerable<Lockable>>(
                HttpMethod.Put,
                new Uri("api/lockable/updatemany"),
                lockables);
        }

        public bool Delete(string id)
        {
            return apiService.SendAndConvert<bool, string>(
                HttpMethod.Delete,
                new Uri("api/lockable/delete"),
                id);
        }

        public bool DeleteMany(IEnumerable<string> ids)
        {
            return apiService.SendAndConvert<bool, IEnumerable<string>>(
                HttpMethod.Delete,
                new Uri("api/lockable/deletemany"),
                ids);
        }

        #endregion
    }
}
