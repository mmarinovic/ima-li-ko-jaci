imaLiJaciModul
    .factory('publicChatService', ['Hub', function (Hub) {
    console.log("Init");
    var hub = new Hub('publicChat', {
        
        listeners: {
            ShowNewQuestion: Function,
            ShowCorrectAnswer: Function,
            ShowAnswer: Function
        },
        methods: ['SendAnswer']
    });

    return {
        setListeners: function (showNewQuestion, showCorrectAnswer, showAnswer) {

            hub.listeners.ShowNewQuestion = showNewQuestion;
            hub.listeners.ShowCorrectAnswer = showCorrectAnswer;
            hub.listeners.ShowAnswer = showAnswer;
        },
        sendAnswer: function(answer) {

            hub.SendAnswer(answer);
        }
    };
}]);