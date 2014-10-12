imaLiJaciModul.config([
    '$stateProvider', '$locationProvider', function ($stateProvider, $locationProvider) {
    
        var imaLiJaciPublic = {
            name: 'imaLiJaciPublic',
            url: '/',
            controller: 'imaLiJaciPublic',
            templateUrl: '/Htmltemplates/imaLiJaciPublic.html'
        };

        var imaLiJaciTutorial= {
            name: 'imaLiJaciTutorial',
            url: '/tutorial',
            templateUrl: '/Htmltemplates/imaLiJaciTutorial.html'
        };

        $stateProvider.state(imaLiJaciPublic)
                      .state(imaLiJaciTutorial);

        $locationProvider.html5Mode(true);
    }
]);