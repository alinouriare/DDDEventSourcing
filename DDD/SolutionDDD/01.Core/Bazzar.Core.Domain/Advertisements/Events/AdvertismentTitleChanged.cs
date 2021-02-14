﻿using Framework.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazzar.Core.Domain.Advertisements.Events
{
    public class AdvertismentTitleChanged : IEvent
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
    }
}
