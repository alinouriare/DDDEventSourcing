using Framework.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazzar.Core.Domain.Advertisements.ValueObjects
{
    public class PictureUrl : BaseValueObject<PictureUrl>
    {
        public string Url { get; private set; }
        public static PictureUrl FromString(string value) => new PictureUrl(value);
        private PictureUrl()
        {

        }
        public PictureUrl(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("برای آدرس تصویر مقدار لازم است", nameof(value));
            }

            Url = value;
        }
        public override int ObjectGetHashCode() => Url.GetHashCode();
        public override bool ObjectIsEqual(PictureUrl otherObject) => Url == otherObject.Url;

        public static implicit operator string(PictureUrl advertismentText) => advertismentText.Url;
    }
}
