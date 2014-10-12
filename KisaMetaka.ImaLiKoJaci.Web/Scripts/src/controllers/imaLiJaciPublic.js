imaLiJaciModul.controller('imaLiJaciPublic', ['$scope', 'publicChatHub', 'hubListenerNames', function ($scope, publicChatHub, hubListenerNames) {

    $scope.message = "Ima li tko jaci?";

    function Song(url, fromSecond, toSecond) {
        this.url = url;
        this.fromSecond = fromSecond;
        this.toSecond = toSecond;
        this.type = 'audio/mpeg';
    }

    $scope.$on(hubListenerNames.sendMessage, function (e, message) {

        if (message.Type === 2) {
            $scope.song = new Song(message.SongUrl, message.FromSecond, message.ToSecond);
        }
    });
}]);