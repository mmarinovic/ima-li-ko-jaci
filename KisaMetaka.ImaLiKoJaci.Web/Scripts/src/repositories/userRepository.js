imaLiJaciModul
    .factory('userRepository', ['$resource', function ($resource) {
        
        return {
            update: function(model) {

                var resource = $resource('/api/user/Update', null, { 'put': { method: 'PUT' } });

                return resource.put(model).$promise;
            },

            getLeaderboard: function() {

                var resource = $resource('/api/user/GetLeaderboard');

                return resource.query().$promise;
            }
        }
}]);