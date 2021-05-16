using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSARU.SocialMedia.Web.API.Model.Response
{
    public class ProfileModel
    {
        public string UserName { get; set; }
        public string ImageProfile { get; set; }
    }
    public class ProfileResponseModel : ProfileModel
    {
        public Guid ProfileId { get; set; }
    }
}
