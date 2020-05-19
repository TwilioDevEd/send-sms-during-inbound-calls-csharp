<a  href="https://www.twilio.com">
<img  src="https://static0.twilio.com/marketing/bundles/marketing/img/logos/wordmark-red.svg"  alt="Twilio"  width="250"  />
</a>

# Send an SMS during a phone call. Powered by Twilio and C#/.NET Framework

![](https://github.com/TwilioDevEd/send-sms-during-inbound-calls-csharp/workflows/NetFx/badge.svg)

> We are currently in the process of updating this sample template. If you are encountering any issues with the sample, please open an issue at [github.com/twilio-labs/code-exchange/issues](https://github.com/twilio-labs/code-exchange/issues) and we'll try to help you.

## About

Learn how to send an SMS to someone who's called your Twilio phone number while they're on the call.

This small sample application will say a short message to an inbound caller and, at the same time, send them an SMS.

[Read the full tutorial here!](https://www.twilio.com/docs/sms/tutorials/send-sms-during-phone-call-csharp)

Implementations in other languages:

| PHP | Java | Python | Ruby | Node |
| :--- | :--- | :----- | :-- | :--- |
| [Done](https://github.com/TwilioDevEd/send-sms-during-inbound-calls-php)  | [Done](https://github.com/TwilioDevEd/send-sms-during-inbound-calls-java)  | [Done](https://github.com/TwilioDevEd/send-sms-during-inbound-calls-python)  | [Done](https://github.com/TwilioDevEd/send-sms-during-inbound-calls-ruby) | [Done](https://github.com/TwilioDevEd/send-sms-during-inbound-calls-node)  |

<!--
### How it works

**TODO: Describe how it works**
-->

## Set up

### Requirements

- [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework/net472)
- A Twilio account - [sign up](https://www.twilio.com/try-twilio)
- [ngrok](https://ngrok.com)

### Twilio Account Settings

This application should give you a ready-made starting point for writing your
own application. Before we begin, we need to collect
all the config values we need to run the application:

| Config&nbsp;Value | Description                                                                                                                                                  |
| :---------------- | :----------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Account&nbsp;Sid  | Your primary Twilio account identifier - find this [in the Console](https://www.twilio.com/console).                                                         |
| Auth&nbsp;Token   | Used to authenticate - [just like the above, you'll find this here](https://www.twilio.com/console).                                                         |

### Local development

After the above requirements have been met:

1. Clone this repository and `cd` into it

```bash
git clone git@github.com:TwilioDevEd/send-sms-during-inbound-calls-csharp.git
cd send-sms-during-inbound-calls-csharp
```

2. Set your configuration variables

```bash
copy TwilioApp/Local.config.example TwilioApp/Local.config
```

See [Twilio Account Settings](#twilio-account-settings) to locate the necessary environment variables.

3. Build the solution

4. Run the application

5. Expose the application to the wider Internet using [ngrok](https://ngrok.com/).

```bash
$ ngrok http 49341 -host-header="localhost:49341"
```

Or, use [ngrok Extensions](https://marketplace.visualstudio.com/items?itemName=DavidProthero.NgrokExtensions) for Visual Studio. Select "Tools... Start ngrok Tunnel".

6. Configure Twilio to call your webhooks

You will need to configure Twilio to call your application when calls are received in your [*Twilio Number*](https://www.twilio.com/user/account/messaging/phone-numbers). The voice url should look something like this:

```
https://<your-ngrok-subdomain>.ngrok.io/answer
```

7. Make a call to your number.

That's it!

## Resources

- The CodeExchange repository can be found [here](https://github.com/twilio-labs/code-exchange/).

## Contributing

This template is open source and welcomes contributions. All contributions are subject to our [Code of Conduct](https://github.com/twilio-labs/.github/blob/master/CODE_OF_CONDUCT.md).

[Visit the project on GitHub](https://github.com/twilio-labs/sample-template-dotnet)

## License

[MIT](http://www.opensource.org/licenses/mit-license.html)

## Disclaimer

No warranty expressed or implied. Software is as is.

[twilio]: https://www.twilio.com
