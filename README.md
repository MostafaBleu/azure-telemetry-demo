# End-to-end telemetry using Azure Application Insights

This is the demo app used in my blog post [End-to-end telemetry using Azure Application Insights](https://www.mostafableu.com/blog/end-to-end-telemetry-using-azure-application-insights/)

## Prerequisites to build the app

- Dotnet Core 3.1
- Node 14.x
- Yarn or NPM

## Build and deploy the api

1. Build

from the folder `/back`

```
dotnet publish -c Release -o ./publish
```

2. Files to Deploy
   The file that needs to be deployed are in the folder `/back/publish`

## Build and deploy the front

1. Change the API base URL to point to azue `/front/nuxt.config.js`

```js
axios: {
   baseURL: '<API BASE URL>',
},
```

2. Change telemetry Key `/front/nuxt.config.js`

```js
appInsights: {
   instrumentationKey: '<InstrumentationKey>'
},
```

3. Build

from the folder `/front`

```
yarn generate
```

4. Files to Deploy
   The that needs to be deployed are in the folder `/front/dist`
