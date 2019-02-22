using System;

namespace ApertureLabs.LibraryApi.Client.Models
{
    public class ApiServiceOptions
    {
        public Uri ServerUri { get; set; }

        public string Key { get; set; }

        public string OwnerToken { get; set; }
    }
}
