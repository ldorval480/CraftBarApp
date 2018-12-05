/**
 * Created by ldorval on 11/30/2018.
 */
angular.module('craftBar.services.styleService', [])
.service('styleService', function($http){

    var styleService = {};

    styleService.getStyles = function() {
//      var url = {FETCH: 'localhost:52485/api/beer'};
//      return $http.get(url.FETCH);
      return $http({
        method : 'GET',
        cache  : true,
        url    : 'http://craftbarapi.local:8000/api/style'
      });
    };

    return styleService;
  });