app.controller("login",function($scope,$http,ajax){
    $scope.msg = "no error";
      ajax.get("https://localhost:44340/api/login",success,error);
      function success(response){
        $scope.delivery=response.data;
      }
      function error(error){
        $scope.msg = "error";
      }
  
  });
  