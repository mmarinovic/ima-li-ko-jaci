imaLiJaciModul
    .controller('editProfile', ['$scope', 'userRepository', '$currentUser', function ($scope, userRepository, $currentUser) {

        $scope.user = angular.copy($currentUser);

        $scope.save = function(user) {
            
            userRepository.update(user)
            .then(function() {

                window.location = '/';
            });
        }
}]);