imaLiJaciModul
    .factory('publicChatHub', ['Hub', '$rootScope', 'hubListenerNames', '$timeout', function (Hub, $rootScope, hubListenerNames, $timeout) {

    return new Hub('publicChat', {
        
        listeners: {
            ShowNewQuestion: function (question) {
                $rootScope.$broadcast(hubListenerNames.showNewQuestion, question);
                $rootScope.$apply();
            },
            ShowCorrectAnswer: function(correctAnswer) {
                
                $rootScope.$broadcast(hubListenerNames.showCorrectAnswer, correctAnswer);
                $rootScope.$apply();
            },
            ShowAnswer: function (answer) {
                
                $rootScope.$broadcast(hubListenerNames.showAnswer, answer);
                $rootScope.$apply();
            }
        },
        errorHandler: function (error) {
            console.log(error);
        }
    });
}]);