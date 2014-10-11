imaLiJaciModul
    .factory('publicChatHub', ['Hub', '$rootScope', 'hubListenerNames', function (Hub, $rootScope, hubListenerNames) {

    return new Hub('publicChat', {
        
        listeners: {
            ShowNewQuestion: function (question) {

                $rootScope.$broadcast(hubListenerNames.showNewQuestion, question);
            },
            ShowCorrectAnswer: function(correctAnswer) {
                
                $rootScope.$broadcast(hubListenerNames.showCorrectAnswer, correctAnswer);
            },
            ShowAnswer: function (answer) {
                
                $rootScope.$broadcast(hubListenerNames.showAnswer, answer);
            }
        },
        errorHandler: function (error) {
            console.log(error);
        }
    });
}]);