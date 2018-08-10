// This file can be replaced during build by using the `fileReplacements` array.
// `ng build ---prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

export const environment = {
  production: false,
  server_url: 'http://localhost:29878',
  firebase: {
    apiKey: 'AIzaSyDkG6cWbERooMWbAn9sRBbYiRkXm81WP8U',
    authDomain: 'watcherapp-2984b.firebaseapp.com',
    databaseURL: 'https://watcherapp-2984b.firebaseio.com',
    projectId: 'watcherapp-2984b',
    storageBucket: 'watcherapp-2984b.appspot.com',
    messagingSenderId: '772299845034'
  }
};

/*
 * In development mode, to ignore zone related error stack frames such as
 * `zone.run`, `zoneDelegate.invokeTask` for easier debugging, you can
 * import the following file, but please comment it out in production mode
 * because it will have performance impact when throw error
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.
