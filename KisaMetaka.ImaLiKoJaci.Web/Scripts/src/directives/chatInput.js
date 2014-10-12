imaLiJaciModul
    .directive('chatInput', function () {

        return {
            
            restrict: 'E',
            scope: {},
            templateUrl: '/HtmlTemplates/chatInput.html',

            controller: ['$scope', 'chatRepository', '$currentUser', function ($scope, chatRepository, $currentUser) {

                $scope.isUserSignedIn = !!$currentUser;

                $scope.sendAnswer = function(answer) {
                    chatRepository.sendAnswer(answer);
                    $scope.answer = "";
                };
            }]
        };
    });