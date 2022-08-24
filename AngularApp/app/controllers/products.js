app.controller("products",function($scope,$http,ajax){
  $scope.msg = "no error";
    ajax.get("https://localhost:44340/api/products",success,error);
    function success(response){
      $scope.products=response.data;
    }
    function error(error){
      $scope.msg = "error";
    }

    $scope.filtername=function(){
      ajax.get("https://localhost:44340/api/products/filterbyname/"+$scope.name,success,error);
    }
    $scope.filterprice1=function(){
      ajax.get("https://localhost:44340/api/products/filterbyprice/100",success,error);
    }
    $scope.filterprice2=function(){
      ajax.get("https://localhost:44340/api/products/filterbyprice/300",success,error);
    }
    $scope.filterprice3=function(){
      ajax.get("https://localhost:44340/api/products/filterbyprice/500",success,error);
    }
    $scope.filterrating1=function(){
      ajax.get("https://localhost:44340/api/products/filterbyrating/3",success,error);
    }
    $scope.filterrating2=function(){
      ajax.get("https://localhost:44340/api/products/filterbyrating/4",success,error);
    }
    $scope.filterrating3=function(){
      ajax.get("https://localhost:44340/api/products/filterbyrating/5",success,error);
    }
    

});
