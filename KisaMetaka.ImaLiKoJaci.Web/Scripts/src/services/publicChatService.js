imaLiJaciModul
    .factory('publicChatService', ['Hub', '$rootScope', 'hubListenerNames', function (Hub, $rootScope, hubListenerNames) {

    console.log("Initializing hub"); 
    var hub = new Hub('publicChat', {
        
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
        methods: ['sendAnswer'],
        errorHandler: function (error) {
            console.log(error);
        }
    });

    return {
        sendAnswer: function(answer) {
            hub.sendAnswer("Id", answer);
        }
    };
}]);