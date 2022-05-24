param location string = resourceGroup().location

resource acr 'Microsoft.ContainerRegistry/registries@2021-09-01' = {
  name: 'WiredBrainCoffeeAdmin'
  location: location
  sku: {
    name: 'Basic'
  }
  properties: {
    adminUserEnabled: true
  }
}

module env 'environment.bicep' = {
  name: 'containerAppEnvironment'
  params: {
    location: location
  }
}

// create the various config pairs
var shared_config = [
  {
    name: 'ASPNETCORE_ENVIRONMENT'
    value: 'Development'
  }
  {
    name: 'APPINSIGHTS_INSTRUMENTATIONKEY'
    value: env.outputs.appInsightsInstrumentationKey
  }
  {
    name: 'APPLICATIONINSIGHTS_CONNECTION_STRING'
    value: env.outputs.appInsightsConnectionString
  }
]

module wiredAdmin 'container_app.bicep' = {
  name: 'admin'
  params: {
    name: 'admin'
    location: location
    registryPassword: acr.listCredentials().passwords[0].value
    registryUsername: acr.listCredentials().username
    containerAppEnvironmentId: env.outputs.id
    registry: acr.name
    envVars: shared_config
    externalIngress: true
  }
}
