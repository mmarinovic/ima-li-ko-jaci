imaLiJaciModul.config([
    '$stateProvider', '$locationProvider', function ($stateProvider, $locationProvider) {
    
        var imaLiJaciPublic = {
            name: 'imaLiJaciPublic',
            url: '/',
            controller: 'imaLiJaciPublic',
            templateUrl: '/Htmltemplates/imaLiJaciPublic.html'
        };

        $stateProvider.state(imaLiJaciPublic);

        $locationProvider.html5Mode(true);
    }
]);