using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazzar.Core.Domain.Advertisements.Commands
{
    public class UpdatePrice
    {
        public Guid Id { get; set; }
        public long Price { get; set; }
    }
}
