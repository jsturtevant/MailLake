angular.module('mailLake', []).controller('bubController', function ($scope) {
   var list1  = [
        {
            from: "gabby", subject: "Important: please review", preview: "this is the first line."
        },
         {
             from: "James", subject: "Ventureships Alumnus", preview: "this is the first line."
         }
   ];

   var list2 = [
      {
          from: "anders", subject: "TripIt Pro alert: Check-in reminder", preview: "this is the first line."
      },
       {
           from: "Jesse", subject: "RE: CIC Office Hours", preview: "this is the first line."
       }
       ,
       {
           from: "Steve", subject: "RE: Tick tock...RSVP now! (Not just one, but TWO events inside!)", preview: "this is the first line."
       }
   ];


   var list3 = [
    {
        from: "Maria", subject: "Github Repo ", preview: "this is the first line."
    },
     {
         from: "Jesper", subject: "Your BUILDFest Invitation", preview: "this is the first line."
     }
     ,
       {
           from: "Jesse", subject: "RE: CIC Office Hours", preview: "this is the first line."
       }
       ,
       {
           from: "Jesse", subject: "RE: CIC Office Hours", preview: "this is the first line."
       }
       ,
       {
           from: "Jesse", subject: "RE: CIC Office Hours", preview: "this is the first line."
       }
   ];

   $scope.MailItems = list1;
  
   $scope.UpdateMailItems = function (id) {

       if (id == "Important")
           $scope.MailItems = list1;

       if (id == "Manager")
           $scope.MailItems = list2;

       if (id == "Team")
           $scope.MailItems = list3;
    }
    
});

