imaLiJaciModul
    .directive('connectedUsersInfo', function() {
   
        return {
            
            restrict: 'E',
            templateUrl: '/HtmlTemplates/connectedUsersInfo.html',
            scope: {},

            controller: ['$scope', 'hubListenerNames', function ($scope, hubListenerNames) {

                $scope.$on(hubListenerNames.updateConnectionsInfo, function (e, connectedUsers) {

                    $scope.connectedUsers = connectedUsers;
                });
            }]
        }
});