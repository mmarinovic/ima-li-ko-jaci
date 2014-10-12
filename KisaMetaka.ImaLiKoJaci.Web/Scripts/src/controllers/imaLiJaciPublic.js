imaLiJaciModul.controller('imaLiJaciPublic', ['$scope', 'publicChatHub', 'hubListenerNames', function ($scope, publicChatHub, hubListenerNames) {

    $scope.message = "Ima li tko jaci?";

    $scope.$on(hubListenerNames.showCorrectAnswer, function(e, correctAnswer) {

        console.log(correctAnswer);
    });
}]);