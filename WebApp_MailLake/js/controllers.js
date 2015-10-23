angular.module('mailLake', []).controller('bubController', function ($scope) {
    $scope.MailItems = [
        {
            from: "gabby", subject: "test1", preview: "this is the first line."
        },
         {
             from: "James", subject: "test2", preview: "this is the first line."
         }
    ];
  


});

