imaLiJaciModul
    .directive('chatInput', function (publicChatHub) {

        return {
            
            restrict: 'E',
            scope: {},
            templateUrl: '/HtmlTemplates/chatInput.html',

            controller: ['$scope', 'chatRepository', function ($scope, chatRepository) {

                $scope.sendAnswer = function(answer) {
                    chatRepository.sendAnswer(answer);
                };
            }]
        };
    });