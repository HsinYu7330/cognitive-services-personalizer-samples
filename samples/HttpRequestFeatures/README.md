# About this sample
This sample extracts HTTP request features and adds them as context feature to a Rank requests that are sent to an Azure Personalizer instance.

This is a [ASP.NET Core MVC 2.1](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-2.1) solution. When run, it displays a single page with a **Send Request** button on the top bar. When clicked, a Rank request is sent to your Personalizer instance with HTTP information gathered from the featurizer as part of the context features. The entire Rank request body is displayed, as well as the response returned by the instance.

# To try this sample

## Prerequisites

- [.NET Core 2.1](https://dotnet.microsoft.com/download/dotnet-core/2.1)
- [Visual Studio 2019](https://visualstudio.microsoft.com/vs/), or [.NET Core CLI](https://docs.microsoft.com/en-us/dotnet/core/tools/)

## Set up the sample
- Clone the Azure Personalizer Samples repo.

    ```bash
    git clone https://github.com/Azure-Samples/cognitive-services-personalizer-samples.git
    ```

- Navigate to _samples/HttpRequestFeatures_.

- Open `HttpRequestFeatures.sln`.

## Set up Azure Personalizer Service

- Create a Personalizer instance in the Azure portal.

- In the Azure portal, find the `ServiceEndpoint` and `PersonalizerApiKey` in the Quick start tab.
  Fill in the `ServiceEndoint` in appsettings.json.
  Configure the `PersonalizerApiKey` as an [app secrets](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets) in one of the following ways:

    > If you are using the .NET Core CLI, you can use the `dotnet user-secrets set "PersonalizerApiKey" "<API Key>"` command.
    > If you are using Visual Studio, you can right-click the project and select the **Manage User Secrets** menu option to configure the Personalizer keys. By doing this, Visual Studio will open a `secrets.json` file where you can add the keys as follows:

```JSON
{
  "PersonalizerApiKey": "<your personalizer key here>",
}
```

## Run the sample

Build and run HttpRequestFeaturesExample. Press **F5** if using Visual Studio, or `dotnet build` then `dotnet run` if using .NET Core CLI. Through the UI, you will be able to send a Rank request and see the http request features extracted from your environment, as well as the response.
