using Bazzar.Core.Domain.Advertisements.Dtoes;
using Bazzar.Core.Domain.Advertisements.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazzar.Core.Domain.Advertisements.Data
{
    public interface IAdvertisementQueryService
    {
        AdvertisementDetail Query(GetActiveAdvertisement query);
        AdvertisementSummary Query(GetActiveAdvertisementList query);
        AdvertisementSummary Query(GetAdvertisementForSpecificSeller query);
    }
}
