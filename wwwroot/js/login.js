$(document).ready(function () {
    var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();
    $("#clockin").click(function () {
        var body = $("body");
        toastr.success('You have been clocked in')





    });

    $("#clockout").click(function () {
        var body = $("body");
        toastr.success('You have been clocked out')

    });

    connection.on("ReceiveMessage", function (message) {
        console.log(message)
    });


});