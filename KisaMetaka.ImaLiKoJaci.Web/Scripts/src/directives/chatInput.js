imaLiJaciModul
    .directive('chatInput', function () {

        return {
            
            restrict: 'E',
            scope: {},
            templateUrl: '/HtmlTemplates/chatInput.html',

            controller: ['$scope', 'publicChatService', function ($scope, publicChatService) {

                $scope.sendAnswer = function(answer) {

                    publicChatService.sendAnswer(answer);
                };
            }]
        }
    });