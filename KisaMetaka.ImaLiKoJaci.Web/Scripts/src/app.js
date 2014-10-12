var imaLiJaciModul = angular.module('imaLiJaciModul', ['ui.router', 'SignalR', 'ngResource', 'mediaPlayer', 'ngAnimate']);

imaLiJaciModul.config(
    ['$provide', function ($provide) {

        $provide.constant('$currentUser', !!imaLiJaciModul.currentUser.Id ? imaLiJaciModul.currentUser : null);
  }
]);