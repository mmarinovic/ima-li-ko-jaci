imaLiJaciModul
    .directive('chatRenderer', function() {

        return {
            
            restrict: 'E',
            scope: {},
            templateUrl: '/HtmlTemplates/chatRenderer.html',

            controller: ['$scope', 'hubListenerNames', function ($scope, hubListenerNames) {

                $scope.messages = [];

                function sendMessage(question) {
                    $scope.messages.push(question);
                };
                 
                $scope.$on(hubListenerNames.sendMessage, function(e, message) {
                    sendMessage(message);
                });
            }]
        };
    });