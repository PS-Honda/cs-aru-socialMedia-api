using CSARU.SocialMedia.Web.API.Model.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSARU.SocialMedia.Web.API.Controllers.Api.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ExampleSocialMediaController : Controller
    {
        public ExampleSocialMediaController()
        {
        }
        [HttpGet("RequestAccessToken/{StudentId}")]
        public async Task<ResponseModel<string>> GetAccessToken(string StudentId)
        {
            var response = new ResponseModel<string>();
            try
            {

                if (string.IsNullOrEmpty(StudentId))
                {
                    response = new ResponseModel<string>
                    {
                        Message = "Required StudentId.",
                        Data = null,
                        Status = 400,
                    };
                }
                else
                {
                    // TODO : IF register return error extisting.
                    // TODO : ELSE register this StudentId and return access token.
                    await Task.Run(() =>
                    {
                        response = new ResponseModel<string>
                        {
                            Data = string.Empty,
                            Message = "success",
                            Status = 200
                        };
                    });
                }
            }
            catch (Exception e)
            {
                response = new ResponseModel<string>
                {
                    Message = e.Message,
                    Data = null,
                    Status = 500,
                };
            }
            return response;
        }
        [HttpGet("GET/Profile")]
        public async Task<ResponseModel<ProfileResponseModel>> GetProfile()
        {
            var response = new ResponseModel<ProfileResponseModel>();
            try
            {
                Request.Headers.TryGetValue("AccessKey", out StringValues AccessKey);
                if (string.IsNullOrWhiteSpace(AccessKey))
                {
                    response = new ResponseModel<ProfileResponseModel>
                    {
                        Message = "Required AccessKey in header.",
                        Data = null,
                        Status = 400,
                    };
                }
                else
                {
                    // TODO : get owner profile
                    await Task.Run(() =>
                    {
                        response = new ResponseModel<ProfileResponseModel>
                        {
                            Data = new ProfileResponseModel
                            {
                                ImageProfile = string.Empty,
                                ProfileId = Guid.Empty,
                                UserName = string.Empty
                            },
                            Message = "success",
                            Status = 200
                        };
                    });
                }
            }
            catch (Exception e)
            {
                response = new ResponseModel<ProfileResponseModel>
                {
                    Data = null,
                    Message = e.Message,
                    Status = 500
                };
            }
            return response;
        }
        [HttpGet("GET/Profile/{UserId}")]
        public async Task<ResponseModel<ProfileResponseModel>> GetProfile(Guid? UserId = null)
        {
            var response = new ResponseModel<ProfileResponseModel>();
            try
            {
                Request.Headers.TryGetValue("AccessKey", out StringValues AccessKey);
                if (string.IsNullOrWhiteSpace(AccessKey))
                {
                    response = new ResponseModel<ProfileResponseModel>
                    {
                        Data = null,
                        Message = "Required AccessKey in header.",
                        Status = 400
                    };
                }
                else
                {
                    if (UserId == null || UserId == Guid.Empty)
                    {
                        // TODO : get owner profile
                    }
                    else
                    {
                        // TODO : get from UsreId profile
                        await Task.Run(() =>
                        {
                            response = new ResponseModel<ProfileResponseModel>
                            {
                                Data = new ProfileResponseModel
                                {
                                    ImageProfile = string.Empty,
                                    ProfileId = Guid.Empty,
                                    UserName = string.Empty
                                },
                                Message = "success",
                                Status = 200
                            };
                        });
                    }
                }
            }
            catch (Exception e)
            {
                response = new ResponseModel<ProfileResponseModel>
                {
                    Data = null,
                    Message = e.Message,
                    Status = 500
                };
            }
            return response;
        }
        [HttpPost("POST/Profile")]
        public async Task<ResponseModel<bool>> CreateOrUpdateProfile([FromForm] ProfileModel Payload)
        {
            var response = new ResponseModel<bool>();
            try
            {
                Request.Headers.TryGetValue("AccessKey", out StringValues AccessKey);
                if (string.IsNullOrWhiteSpace(AccessKey))
                {
                    response = new ResponseModel<bool>
                    {
                        Data = false,
                        Message = "Required AccessKey in header.",
                        Status = 400
                    };
                }
                else
                {
                    // TODO : check user from accessKey
                    // TODO : IF equal update profile
                    // TODO : ELSE return error access deny.
                    await Task.Run(() =>
                   {
                       response = new ResponseModel<bool>
                       {
                           Data = true,
                           Message = "success",
                           Status = 200
                       };
                   });
                }
            }
            catch (Exception e)
            {
                response = new ResponseModel<bool>
                {
                    Data = false,
                    Message = e.Message,
                    Status = 500
                };
            }
            return response;
        }
        [HttpGet("GET/Timeline/{Page}/{PerPage}")]
        public async Task<ResponseModel<TimelineModel>> GetTimelime(uint Page = 0, uint PerPage = 10)
        {
            var response = new ResponseModel<TimelineModel>();
            try
            {
                Request.Headers.TryGetValue("AccessKey", out StringValues AccessKey);
                if (string.IsNullOrWhiteSpace(AccessKey))
                {
                    response = new ResponseModel<TimelineModel>
                    {
                        Data = null,
                        Message = "Required AccessKey in header.",
                        Status = 400
                    };
                }
                else
                {
                    // TODO : get timeline item and total item number
                    await Task.Run(() =>
                    {
                        response = new ResponseModel<TimelineModel>
                        {
                            Data = new TimelineModel
                            {
                                TimelineItem = new List<PostResponseModel>(),
                                ToltalTimelineNumber = 0
                            },
                            Message = "success",
                            Status = 200
                        };
                    });
                }
            }
            catch (Exception e)
            {
                response = new ResponseModel<TimelineModel>
                {
                    Data = null,
                    Message = e.Message,
                    Status = 500
                };
            }
            return response;
        }
        [HttpPost("POST/CreatePost")]
        public async Task<ResponseModel<bool>> CreatePost([FromBody] PostModel Payload)
        {
            var response = new ResponseModel<bool>();
            try
            {
                Request.Headers.TryGetValue("AccessKey", out StringValues AccessKey);
                if (string.IsNullOrWhiteSpace(AccessKey))
                {
                    response = new ResponseModel<bool>
                    {
                        Data = false,
                        Message = "Required AccessKey in header.",
                        Status = 400
                    };
                }
                else
                {
                    // TODO : create post with accesskey userId
                    await Task.Run(() =>
                    {
                        response = new ResponseModel<bool>
                        {
                            Data = true,
                            Message = "success",
                            Status = 200
                        };
                    });
                }
            }
            catch (Exception e)
            {
                response = new ResponseModel<bool>
                {
                    Data = false,
                    Message = e.Message,
                    Status = 500
                };
            }
            return response;
        }
    }
}
