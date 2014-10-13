imaLiJaciModul.controller('imaLiJaciPublic', ['$scope', 'hubListenerNames', function ($scope, hubListenerNames) {
    
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