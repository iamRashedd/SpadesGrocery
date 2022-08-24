app.controller("delivery",function($scope,$http,ajax){
    $scope.msg = "no error";
      ajax.get("https://localhost:44340/api/delivery/",success,error);
      function success(response){
        $scope.delivery=response.data;
      }
      function error(error){
        $scope.msg = "error";
      }
  
  });
  