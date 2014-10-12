imaLiJaciModul
    .controller('leaderboard', ['$scope', 'userRepository', function ($scope, userRepository) {

        userRepository.getLeaderboard()
        .then(function(leaderboard) {

            $scope.leaderboard = leaderboard;
    });
}]);