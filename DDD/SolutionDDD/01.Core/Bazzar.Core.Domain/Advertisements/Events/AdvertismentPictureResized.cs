﻿using Framework.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazzar.Core.Domain.Advertisements.Events
{
   public class AdvertismentPictureResized:IEvent
    {
        public Guid PictureId { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }
}
