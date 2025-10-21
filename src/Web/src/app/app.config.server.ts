import { ApplicationConfig, mergeApplicationConfig } from '@angular/core';
import { provideServerRendering, withRoutes } from '@angular/ssr';
import { appConfig } from './app.config';
import { serverRoutes } from './app.routes.server';
import { SsrCookieService } from 'ngx-cookie-service-ssr';
import { provideRouter, withViewTransitions } from '@angular/router';
import { routes } from './app.routes';

const serverConfig: ApplicationConfig = {
  providers: [
    provideServerRendering(withRoutes(serverRoutes)),
    { provide: 'COOKIE_SERVICE', useClass: SsrCookieService },
    provideRouter(routes, withViewTransitions()),
  ],
};

export const config = mergeApplicationConfig(appConfig, serverConfig);
