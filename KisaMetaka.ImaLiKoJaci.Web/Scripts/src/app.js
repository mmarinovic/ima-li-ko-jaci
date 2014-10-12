var imaLiJaciModul = angular.module('imaLiJaciModul', ['ui.router', 'SignalR', 'ngResource', 'mediaPlayer', 'luegg.directives']);

imaLiJaciModul.config(
    ['$provide', function ($provide) {

        $provide.constant('$currentUser', !!imaLiJaciModul.currentUser.Id ? imaLiJaciModul.currentUser : null);
  }
]);