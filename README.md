<a href="https://www.twilio.com">
  <img src="https://static0.twilio.com/marketing/bundles/marketing/img/logos/wordmark-red.svg" alt="Twilio" width="250" />
</a>

# Send an SMS during a phone call. Powered by Twilio and C#/.NET Framework

Learn how to send an SMS to someone who's called your Twilio phone number while they're on the call.

This small sample application will say a short message to an inbound caller and, at the same time, send them an SMS.

[Read the full tutorial here!](https://www.twilio.com/docs/sms/tutorials/send-sms-during-phone-call-chsarp)


## Local Development

This project is built using the [.NET Framework](http://sinatrarb.com/) 4.6.1, and the [Twilio .NET Framework Helper Library](https://www.twilio.com/docs/libraries/csharp-dotnet).

1. First clone this repository and `cd` into it.

   ```bash
   $ git clone https://github.com/TwilioDevEd/send-sms-during-inbound-calls-csharp.git
   $ cd send-sms-during-inbound-calls-csharp
   ```

1. Open the TwilioApp/Web.config file and edit the `TwilioAccountSid` and `TwilioAutToken` with your own data:

  ```
  <appSettings>
    <add key="TwilioAccountSid" value="ACxxx" />
    <add key="TwilioAuthToken" value="xxx" />
  </appSettings>
  ```

1. Build the project in Visual Studio and run the application.

1. Expose the application to the wider Internet using [ngrok](https://ngrok.com/).

    ```bash
    $ ngrok http 49341 -host-header="localhost:49341"
    ```

1. Configure Twilio to call your webhooks

  You will need to configure Twilio to call your application when calls are
  received in your [*Twilio Number*](https://www.twilio.com/user/account/messaging/phone-numbers).
  The voice url should look something like this:

  ```
  https://<your-ngrok-subdomain>.ngrok.io/answer
  ```


## Meta

* No warranty expressed or implied. Software is as is. Diggity.
* [MIT License](http://www.opensource.org/licenses/mit-license.html)
* Lovingly crafted by Twilio Developer Education.
