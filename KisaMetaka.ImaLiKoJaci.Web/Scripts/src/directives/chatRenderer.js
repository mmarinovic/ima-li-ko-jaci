imaLiJaciModul
    .directive('chatRenderer', function() {

        return {
            
            restrict: 'E',
            scope: {},
            templateUrl: '/HtmlTemplates/chatRenderer.html',

            controller: ['$scope', 'publicChatService', function ($scope, publicChatService) {

                $scope.messages = [];

                function showNewQuestion(question) {
                    $scope.messages.push(question);
                };

                function showCorrectAnswer(correctAnswer) {
                    $scope.messages.push(correctAnswer);
                };

                function sendAnswer(answer) {
                    $scope.messages.push(answer);
                };

                publicChatService.setListeners(showNewQuestion, showCorrectAnswer, sendAnswer);
            }]
        }
    });