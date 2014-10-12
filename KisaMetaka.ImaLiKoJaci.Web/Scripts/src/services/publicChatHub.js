imaLiJaciModul
    .factory('publicChatHub', ['Hub', '$rootScope', 'hubListenerNames', function (Hub, $rootScope, hubListenerNames) {

    return new Hub('publicChat', {
        
        listeners: {
            showNewQuestion: function (question) {
                
                $rootScope.$broadcast(hubListenerNames.showNewQuestion, question);
                $rootScope.$apply();
            },
            showCorrectAnswer: function(correctAnswer) {
                
                $rootScope.$broadcast(hubListenerNames.showCorrectAnswer, correctAnswer);
                $rootScope.$apply();
            },
            sendAnswer: function (answer) {
                
                $rootScope.$broadcast(hubListenerNames.showAnswer, answer);
                $rootScope.$apply();
            }
        }
    });
}]);