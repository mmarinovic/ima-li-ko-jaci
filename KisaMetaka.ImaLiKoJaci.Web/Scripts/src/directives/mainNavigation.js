imaLiJaciModul
    .directive('mainNavigation', function() {
        return {
        restrict: 'E',
        scope: {},
        templateUrl: '/HtmlTemplates/mainNavigation.html',

        controller: [
            '$scope', '$currentUser', function($scope, $currentUser) {

                $scope.isUserSignedIn = !!$currentUser;
            }
        ]
    }
});