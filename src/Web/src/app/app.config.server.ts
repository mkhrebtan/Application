import { ApplicationConfig, mergeApplicationConfig } from '@angular/core';
import { provideServerRendering, withRoutes } from '@angular/ssr';
import { appConfig } from './app.config';
import { serverRoutes } from './app.routes.server';
import { SsrCookieService } from 'ngx-cookie-service-ssr';

const serverConfig: ApplicationConfig = {
  providers: [
    provideServerRendering(withRoutes(serverRoutes)),
    { provide: 'COOKIE_SERVICE', useClass: SsrCookieService },
  ],
};

export const config = mergeApplicationConfig(appConfig, serverConfig);
