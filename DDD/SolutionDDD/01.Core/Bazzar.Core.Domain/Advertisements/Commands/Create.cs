﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazzar.Core.Domain.Advertisements.Commands
{
    public class Create
    {
        public Guid Id { get; set; }
        public Guid OwnerId { get; set; }
    }
}
