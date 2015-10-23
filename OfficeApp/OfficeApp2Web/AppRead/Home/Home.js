/// <reference path="../App.js" />

(function () {
    "use strict";

    // The Office initialize function must be run each time a new page is loaded
    Office.initialize = function (reason) {
        $(document).ready(function () {
            app.initialize();

            displayItemDetails();
            //updateWeight();
            $('#itemid').text(Office.context.mailbox.item.itemId);
        });
    };

    // Displays the "Subject" and "From" fields, based on the current mail item
    function displayItemDetails() {
        var item = Office.cast.item.toItemRead(Office.context.mailbox.item);
        $('#subject').text(item.subject);

        var from;
        if (item.itemType === Office.MailboxEnums.ItemType.Message) {
            from = Office.cast.item.toMessageRead(item).from;
        } else if (item.itemType === Office.MailboxEnums.ItemType.Appointment) {
            from = Office.cast.item.toAppointmentRead(item).organizer;
        }

        if (from) {
            $('#from').text(from.displayName);
            $('#from').click(function () {
                app.showNotification(from.displayName, from.emailAddress);
            });
        }
    }

    // Display weight
    function updateWeight() {
        $.ajax({
            method: "GET",
            url: "http://localhost:55065/api/importance/",
            data: { id : Office.context.mailbox.item.itemId }
        })
        .done(function (currentWeight) {
            $('#currentweight').text(currentWeight);
        });
    }

    // lower the weight
    $('#weightlower').click(function () {
        $.ajax({
            method: "POST",
            url: "http://localhost:55065/api/importance?mailId=" + Office.context.mailbox.item.itemId + "&importance=-1",
            data: {}
        })
        .done(function (newWeight) {
            $('#currentweight').text(newWeight);
        });
    });

    // rise the weight
    $('#weighthigher').click(function () {
        $.ajax({
            method: "POST",
            url: "http://localhost:55065/api/importance?mailId=" + Office.context.mailbox.item.itemId + "&importance=1",
            data: {}
        })
        .done(function (newWeight) {
            $('#currentweight').text(newWeight);
        });
    });

    // confirm weight
    $('#weightcorrect').click(function () {
        $.ajax({
            method: "POST",
            url: "http://localhost:55065/api/importance?mailId=" + Office.context.mailbox.item.itemId + "&importance=0",
            data: {}
        })
        .done(function (newWeight) {
            $('#currentweight').text(newWeight);
        });
    });


})();


