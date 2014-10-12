imaLiJaciModul
    .directive('answerPlayer', function() {

        return {
            
            restrict: 'E',
            scope: {
                url: '@',
                type: '@',
                from: '@',
                to: '@'
            },
            templateUrl: '/HtmlTemplates/answerPlayer.html',

            controller: ['$scope', '$element', function ($scope, $element) {

                var audioElement = $element.find('audio');

                function setupPlayer(url, type, from, to) {
                  
                    $scope.answerPlayer.load([{ src: url, type: type, media: '.css.media.query' }, false]);

                    if (from) {
                        setStartPosition(from);
                    };

                    if (to) {
                        stopAtPosition(to);
                    }

                    $scope.answerPlayer.play(0, false);
                };

                function stopAtPosition(stopPosition) {

                    var stopPositionInSeconds = convertToSeconds(stopPosition);
                    $scope.$watch('answerPlayer.currentTime', function(currentTime) {

                        if (currentTime >= stopPositionInSeconds) {

                            $(audioElement).animate({ volume: 0 }, 2000);
                        }
                    });
                };

                function setStartPosition(startPosition) {

                    var startPositionInSeconds = convertToSeconds(startPosition);
                    $scope.answerPlayer.on('loadedmetadata', function () {
                        $scope.answerPlayer.seek(startPositionInSeconds);
                    });
                };

                function convertToSeconds(input) {

                    var parts = input.split(':'),
                        minutes = +parts[0],
                        seconds = +parts[1];

                    return (minutes * 60 + seconds).toFixed(6);
                }

                $scope.$watch('answerPlayer', function (answerPlayer) {
                    
                    if (answerPlayer) {
                      
                        setupPlayer($scope.url, $scope.type, $scope.from, $scope.to);
                    }
                });
            }]
        }
    });