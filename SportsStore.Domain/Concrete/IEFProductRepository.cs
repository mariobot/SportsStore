using SportsStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.Domain.Concrete
{
    public interface IEFProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
