imaLiJaciModul
    .directive('answerPlayer', function() {

        return {
            
            restrict: 'E',
            scope: {
                song: '='
            },
            templateUrl: '/HtmlTemplates/answerPlayer.html',

            controller: ['$scope', '$element', function ($scope, $element) {

                var audioElement = $element.find('audio');
                $scope.loadedmetadataHandler = null;
                $scope.volumeAnimationHandler = null;

                function resetPlayer() {
                    $scope.answerPlayer.pause();
                    $scope.answerPlayer.currentTime = 0;
                    $scope.answerPlayer.setVolume(1);
                    $scope.volumeAnimationHandler = null;
                }

                function setupPlayer(url, type) {

                    resetPlayer();
                    $scope.answerPlayer.load([{ src: url, type: type, media: '.css.media.query' }, false]);

                    setStartPosition();
                    $scope.answerPlayer.play();
                };

                $scope.$watch('answerPlayer.currentTime', function (currentTime) {

                    if ($scope.song && currentTime >= $scope.song.toSecond && !$scope.volumeAnimationHandler) {
                        $scope.volumeAnimationHandler = $(audioElement).animate({ volume: 0 }, 2000);
                    }
                });

                function setStartPosition() {

                    if (!$scope.loadedmetadataHandler) {
                        $scope.loadedmetadataHandler = $scope.answerPlayer.on('loadedmetadata', function () {

                            $scope.answerPlayer.seek($scope.song.fromSecond);
                        });
                    }
                };

                $scope.$watch('song', function(song) {

                    if (song) {
                        $scope.$watch('answerPlayer', function (answerPlayer) {

                            if (answerPlayer) {
                                setupPlayer($scope.song.url, $scope.song.type);
                            }
                        });
                    }
                });
            }]
        }
    });