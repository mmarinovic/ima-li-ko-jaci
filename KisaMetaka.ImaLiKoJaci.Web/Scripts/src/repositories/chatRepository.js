imaLiJaciModul
    .factory('chatRepository', ['$resource', function($resource) {
   
        return {
            sendAnswer: function(answer) {

                var resource = $resource('/api/Chat/SendAnswer');

                return resource.save(answer).$promise;
            }
        }
}]);