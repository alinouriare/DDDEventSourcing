using Bazzar.Core.Domain.Advertisements.Commands;
using Bazzar.Core.Domain.Advertisements.Data;
using Bazzar.Core.Domain.Advertisements.Entities;
using Bazzar.Core.Domain.Advertisements.ValueObjects;
using Framework.Domain.ApplicationServices;
using Framework.Domain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazzar.Core.ApplicationServices.Advertisements.CommandHandlers
{
    public class CreateHandler : ICommandHandler<Create>
    {
        private readonly IAdvertisementsRepository advertisementsRepository;
        private readonly IUnitOfWork unitOfWork;
        //private readonly IEventSource eventSource;

        public CreateHandler(IAdvertisementsRepository advertisementsRepository, IUnitOfWork unitOfWork)
        {
            this.advertisementsRepository = advertisementsRepository;
            this.unitOfWork = unitOfWork;
            //this.eventSource = eventSource;

        }

        public void Handle(Create command)
        {
            if (advertisementsRepository.Exists(command.Id))
                throw new InvalidOperationException($"قبلا آگهی با شناسه {command.Id} ثبت شده است.");
            var advertisement = new Advertisment(command.Id
                , new UserId(command.OwnerId));
            advertisementsRepository.Add(advertisement);
            unitOfWork.Commit();
          //  var events = advertisement.GetEvents();
        //eventSource.Save("Advertisement", command.Id.ToString(), events);

        }
    }
}
