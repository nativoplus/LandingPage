using LandingPage.Data;
using LandingPage.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SendGrid;

namespace LandingPage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUsController : ControllerBase
    {
        private readonly ISendGridClient _client;
        private readonly SendGridOptions _options;
        public ContactUsController(ISendGridClient sendGridClient, IOptions<SendGridOptions> options)
        {
            _client = sendGridClient;
            _options = options.Value;
        }

        [HttpPost]
        public async Task Post([FromBody] TypeformContactUsPayload payload)
        {
            if (payload?.Response?.Answers is not null)
            {
                if (payload.Response.Answers.Any())
                {
                    var answersList = payload.Response.Answers;

                    foreach (var answer in answersList)
                    {
                        if (HelperMethods.IsValidEmail(answer.Email))
                        {
                            var data = @"{
                                ""list_ids"": [
                                    " + $@"""{_options.LeadsContactsListId}""" + @"
                                ],
                                ""contacts"": [
                                    {
                                        ""email"": " + $@"""{answer.Email}""" + @"
                                    }
                                ]
                            }";

                            await _client.RequestAsync(
                                method: BaseClient.Method.PUT,
                                urlPath: "marketing/contacts",
                                requestBody: data
                            );
                        }
                    }
                }
            }
        }
    }
}
