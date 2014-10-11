imaLiJaciModul
    .filter('dateTime', ['$filter', function($filter) {

        return function(dateTime) {
          
            if (dateTime) {

                return $filter('date')(dateTime, 'yyyy-MM-dd HH:mm:ss');
            }
        };
    }]);

imaLiJaciModul
    .filter('timeFilter', ['$filter', function ($filter) {

        return function (dateTime) {

            if (dateTime) {

                return $filter('date')(dateTime, 'HH:mm:ss');
            }
        };
    }]);