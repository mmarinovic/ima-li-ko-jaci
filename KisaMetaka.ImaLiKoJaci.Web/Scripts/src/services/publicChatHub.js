imaLiJaciModul
    .factory('publicChatHub', ['Hub', '$rootScope', 'hubListenerNames', function (Hub, $rootScope, hubListenerNames) {

    return new Hub('publicChat', {
        
        listeners: {
            sendMessage: function (message) {
                
                $rootScope.$broadcast(hubListenerNames.sendMessage, message);
                $rootScope.$apply();
            }
        },
        errorHandler: function (error) {
            console.log(error);
        }
    });
}]);