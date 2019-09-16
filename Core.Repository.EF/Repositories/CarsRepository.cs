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
    public class CarsRepository : RepositoryBase<Car, int>, ICarsRepository
    {
        public CarsRepository(GalleryContext ctx) : base(ctx)
        {

        }
    }
}
