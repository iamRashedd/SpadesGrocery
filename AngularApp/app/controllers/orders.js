app.controller("orders",function($scope,$http,ajax){
    $scope.msg = "no error";
      ajax.get("https://localhost:44340/api/orders",success,error);
      function success(response){
        $scope.orders=response.data;
      }
      function error(error){
        $scope.msg = "error";
      }

      $scope.approve=function(){
        var data = {id:$scope.id};
        $http.post("https://localhost:44340/api/orders/approve/"+data,data).then(
          function(response){
          alert(response.data);
        },
        function error(error){

        }
        )
      }
      $scope.allorders=function(){
        ajax.get("https://localhost:44340/api/orders/",success,error);
      }
      $scope.allapproved=function(){
        ajax.get("https://localhost:44340/api/orders/allapproved/",success,error);
      }
      $scope.allcanceled=function(){
        ajax.get("https://localhost:44340/api/orders/allcanceled/",success,error);
      }
      $scope.details=function(){
        ajax.get("https://localhost:44340/api/orders/allcanceled/",success,error);
      }
  
  });
  