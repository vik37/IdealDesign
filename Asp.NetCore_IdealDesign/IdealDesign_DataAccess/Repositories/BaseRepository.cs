using System;
using System.Collections.Generic;
using System.Text;

namespace IdealDesign_DataAccess.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly IdDesignDbContext _db;
        public BaseRepository(IdDesignDbContext db)
        {
            _db = db;
        }
    }
}
