using System;
using System.Configuration;
using System.Web.Mvc;
using Twilio;
using Twilio.AspNet.Mvc;
using Twilio.Exceptions;
using Twilio.Rest.Api.V2010.Account;
using Twilio.TwiML;
using Twilio.Types;


namespace TwilioApp.Controllers
{
    public class BodyData
    {
        public string From { get; set; }
        public string To { get; set; }
    }

    public class AnswerController : TwilioController
    {
        [HttpPost]
        public ActionResult Index(BodyData bodyData)
        {
            var caller = bodyData.From;
            var twilioNumber = bodyData.To;
            SendSms(caller, twilioNumber);

            var response = new VoiceResponse();
            response.Say("Thanks for calling! We just sent you a text with a clue.", voice: "Alice");
            return TwiML(response);
        }

        public void SendSms(String toNumber, String fromNumber)
        {
            var accountSid = ConfigurationManager.AppSettings["TwilioAccountSid"];
            var authToken = ConfigurationManager.AppSettings["TwilioAuthToken"];
            TwilioClient.Init(accountSid, authToken);

            try
            {
                MessageResource.Create(
                    body: "There's always money in the banana stand.",
                    from: new PhoneNumber(fromNumber),
                    to: new PhoneNumber(toNumber)
                );
            }
            catch (ApiException e)
            {
                if (e.Code == 21614)
                {
                    Console.WriteLine("Uh oh, looks like this caller can't receive SMS messages.");
                }
            }
        }
    }
}