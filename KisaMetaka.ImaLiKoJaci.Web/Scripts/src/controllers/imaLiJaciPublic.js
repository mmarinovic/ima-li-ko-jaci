imaLiJaciModul.controller('imaLiJaciPublic', ['$scope', 'publicChatHub', 'hubListenerNames', function ($scope, publicChatHub, hubListenerNames) {
    
    $scope.$on(hubListenerNames.showCorrectAnswer, function(e, correctAnswer) {

        console.log(correctAnswer);
    });
}]);