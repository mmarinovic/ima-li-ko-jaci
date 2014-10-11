imaLiJaciModul
    .directive('chatRenderer', function() {

        return {
            
            restrict: 'E',
            scope: {},
            templateUrl: '/HtmlTemplates/chatRenderer.html',

            controller: ['$scope', 'hubListenerNames', function ($scope, hubListenerNames) {

                $scope.messages = [];

                function showNewQuestion(question) {
                    $scope.messages.push(question);
                };

                function showCorrectAnswer(correctAnswer) {
                    $scope.messages.push(correctAnswer);
                };

                function showAnswer(answer) {
                    $scope.messages.push(answer);
                };
                
                $scope.$on(hubListenerNames.showNewQuestion, function(question) {
                    showNewQuestion(question);
                });

                $scope.$on(hubListenerNames.showCorrectAnswer, function (correctAnswer) {
                    showCorrectAnswer(correctAnswer);
                });

                $scope.$on(hubListenerNames.showAnswer, function (answer) {
                    showAnswer(answer);
                });
            }]
        }
    });