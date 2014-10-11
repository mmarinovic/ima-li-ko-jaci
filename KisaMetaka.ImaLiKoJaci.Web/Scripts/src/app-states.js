imaLiJaciModul.config([
    '$stateProvider', '$locationProvider', function ($stateProvider, $locationProvider) {
    
        var imaLiJaciHome = {
            name: 'imaLiJaciHome',
            url: '/',
            controller: 'imaLiJaciHome',
            templateUrl: '/Htmltemplates/imaLiJaciHome.html'
        };

        $stateProvider.state(imaLiJaciHome);

        $locationProvider.html5Mode(true);
    }
]);