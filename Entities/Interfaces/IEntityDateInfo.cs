using System;

namespace LibraryWebApi.Entities.Interfaces
{
    public interface IEntityDateInfo
    {
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
