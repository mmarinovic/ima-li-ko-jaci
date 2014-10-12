imaLiJaciModul
    .directive('bulletRain', function() {

        return {
            restrict: 'A',
            link: function(scope, elem) {
                $(elem).kisaMetaka({
                    dropImage:  '/Assets/Images/Single-Bullet-icon.png',
                    numberOfDrops : 300
                });
            }
        }
    });