import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Xplore',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44384',
    redirectUri: baseUrl,
    clientId: 'Xplore_App',
    responseType: 'code',
    scope: 'offline_access Xplore',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44384',
      rootNamespace: 'Xplore',
    },
  },
} as Environment;
