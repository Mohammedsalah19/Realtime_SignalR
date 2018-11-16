$(function() {

    //connection to class chathub
    var chat = $.connection.chatHub;
    //recive all messages from client

    chat.Client.push = function (name, message) {


        $("#chatlist").append("<li><strong>" + name + "</strong> says: <p>" + message + "</p></li>")
    };

    //set your name 

    $('#txtName').val(prompt('Enter your name:', ''));
    // set focus on input message
    $("txtMessage").focus();


    //connection to hub successfully

    $.connection.hub.start().done(function () {

        $("btnSend").click(function () {

            var name = $("txtName").val();
            var message = $("txtMessage").val();

            //call send message method from server chathub class

            chat.server.Send(name, message);
            //clear message box
            $("txtMessage").val('').focus();


        })

    })

})