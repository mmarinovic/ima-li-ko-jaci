imaLiJaciModul
    .directive('chatRenderer', function() {

        return {
            
            restrict: 'E',
            scope: {},
            templateUrl: '/HtmlTemplates/chatRenderer.html',

            controller: ['$scope', function($scope) {

                $scope.message = "renderer";
            }]
        }
    });