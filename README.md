# Project Name

<img src="https://developer.nexmo.com/assets/images/Vonage_Nexmo.svg" height="48px" alt="Nexmo is now known as Vonage" />

<!-- Add a paragraph about the project. What does it do? Who is it for? Is it actively supported? Your reader just clicked on a random link from another web page and has no idea what Nexmo is ... -->

## Welcome to Vonage

<!-- change "github-repo" at the end of the link to be the name of your repo, this helps us understand which projects are driving signups so we can do more stuff that developers love -->

If you're new to Vonage, you can [sign up for a Vonage account](https://dashboard.nexmo.com/sign-up?utm_source=DEV_REL&utm_medium=github&utm_campaign=receive-dlr-aspnet-core) and get some free credit to get you started.

## Prerequisites

* You'll need a Vonage API account. You can [sign up here](https://dashboard.nexmo.com/sign-up)
* You'll need the latest version of the [.NET Core 3.1 SDK](https://dotnet.microsoft.com/download/dotnet-core/3.1)
* You'll need either Visual Studio 2019, Visual Studio for Mac, or Visual Studio Code, I will be using Visual Studio Code for this Demo
* I'm going to be sending an SMS message with the [Vonage CLI](https://github.com/Nexmo/nexmo-cli). You can use that or you could even [add your own send logic to this app](https://developer.nexmo.com/messaging/sms/code-snippets/send-an-sms/dotnet)!
* Optional - I used [Ngrok](https://developer.nexmo.com/tools/ngrok) to test this demo

## Testing

We're going to going to test this with [Ngrok](https://developer.nexmo.com/tools/ngrok) to test this demo. Ngrok allows us to build a publicly accessible tunnel to our app, which is very useful when we need to expose publicly accessible http endpoints to our apps. If you are going to be testing this with IIS Express like I am, you will want to check out our [explainer on the subject](https://developer.nexmo.com/tools/ngrok#usage-with-iis-express) as there are special considerations. What this boils down to is that we need to add a `--host-header` option when we are starting up ngrok

```sh
ngrok http --region=us --host-header="localhost:51835" 51835
```

This command will result in your terminal being taken over by ngrok, it will show you a url that all requests will be forwarded from, this will be of the form `http://randomhash.ngrok.io` my random hash came up `d98024d97b04` so for the remainder of this explainer just replace that value with whatever value came up for yours.

### Configure Webhooks

The route to the the webhook in the case of the above is: `http://d98024d97b04.ngrok.io/webhooks/dlr` adjust the hash for whatever your hash is. The last thing needed before testing is to tell the Vonage SMS API where to send the messages (the URL just mentioned).

To do this, navigate to https://dashboard.nexmo.com/settings. Under Default SMS Settings, set the Delivery Receipt field to the that url, and change the HTTP Method to `POST-JSON`. Click Save Changes and we're ready to test. Navigate to your home page and go ahead and send your Vonage API Virtual number a test message. If you're not certain what your Vonage Virtual Number is, you can find it in [your dashboard under numbers](https://dashboard.nexmo.com/your-numbers).

## Getting Help

We love to hear from you so if you have questions, comments or find a bug in the project, let us know! You can either:

* Open an issue on this repository
* Tweet at us! We're [@VonageDev on Twitter](https://twitter.com/VonageDev)
* Or [join the Vonage Community Slack](https://developer.nexmo.com/community/slack)

## Further Reading

* Check out the Developer Documentation at <https://developer.nexmo.com>

<!-- add links to the api reference, other documentation, related blog posts, whatever someone who has read this far might find interesting :) -->


