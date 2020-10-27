import { Config } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'MotelManagement',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44321',
    redirectUri: baseUrl,
    clientId: 'MotelManagement_App',
    responseType: 'code',
    scope: 'offline_access MotelManagement',
  },
  apis: {
    default: {
      url: 'https://localhost:44360',
      rootNamespace: 'MotelManagement',
    },
  },
} as Config.Environment;
