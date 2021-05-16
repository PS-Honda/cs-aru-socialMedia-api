using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSARU.SocialMedia.Web.API.Model.Response
{
    public class TimelineModel
    {
        public List<PostResponseModel> TimelineItem { get; set; }
        public uint ToltalTimelineNumber { get; set; }
    }
    public class PostResponseModel : PostModel
    {
        public Guid PostId { get; set; }
    }
}
