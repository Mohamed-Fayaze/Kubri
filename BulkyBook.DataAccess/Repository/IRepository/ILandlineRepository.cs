using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface ILandlineRepository : IRepositoryAsync<Landline>
    {
        Task UpsertAsync(IEnumerable<Landline> Landlines, int AddressId);
    }

}
