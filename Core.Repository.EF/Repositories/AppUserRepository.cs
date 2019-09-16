using Core.Infrastructure.Domain;
using Core.Model.Models;
using Core.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository.EF.Repositories
{
    public class AppUserRepository : RepositoryBase<AppUser, int>, IAppUserRepository
    {
        public AppUserRepository(GalleryContext ctx) : base(ctx)
        {

        }
    }
}
