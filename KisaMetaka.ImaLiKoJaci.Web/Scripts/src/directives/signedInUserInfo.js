imaLiJaciModul
    .directive('signedInUserInfo', function() {

        return {
            
            restrict: 'E',
            scope: {},
            templateUrl: '/HtmlTemplates/signedInUserInfo.html',

            controller: ['$scope', '$currentUser', function($scope, $currentUser) {

                $scope.currentUser = $currentUser;
            }]
        }
    });