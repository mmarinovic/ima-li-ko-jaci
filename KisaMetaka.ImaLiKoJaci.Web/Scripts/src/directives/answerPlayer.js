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

                    $scope.$watch('answerPlayer.currentTime', function(currentTime) {

                        if (currentTime >= stopPosition) {

                            $(audioElement).animate({ volume: 0 }, 2000);
                        }
                    });
                };

                function setStartPosition(startPosition) {

                    $scope.answerPlayer.on('loadedmetadata', function () {
                        $scope.answerPlayer.seek(startPosition);
                    });
                };

                $scope.$watch('answerPlayer', function (answerPlayer) {
                    
                    if (answerPlayer) {
                      
                        setupPlayer($scope.url, $scope.type, $scope.from, $scope.to);
                    }
                });
            }]
        }
    });