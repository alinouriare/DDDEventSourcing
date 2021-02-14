using Bazzar.Core.Domain.Advertisements.Commands;
using Bazzar.Core.Domain.Advertisements.Data;
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
    public class SetTitleHandler : ICommandHandler<SetTitle>
    {
        private readonly IAdvertisementsRepository advertisementsRepository;
        private readonly IUnitOfWork unitOfWork;

        public SetTitleHandler(IAdvertisementsRepository advertisementsRepository, IUnitOfWork unitOfWork)
        {
            this.advertisementsRepository = advertisementsRepository;
            this.unitOfWork = unitOfWork;
        }
        public void Handle(SetTitle command)
        {
            var advertisement = advertisementsRepository.Load(command.Id);
            if (advertisement ==null)
                throw new InvalidOperationException($"آگهی با شناسه {command.Id} یافت نشد.");
            advertisement.SetTitle(AdvertismentTitle.FromString(command.Title));
            unitOfWork.Commit();
        }
    }
}
