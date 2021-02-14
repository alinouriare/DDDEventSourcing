using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazzar.Core.Domain.Advertisements.Queries
{
    public class GetAdvertisementForSpecificSeller
    {
        public Guid OwneruserId { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
