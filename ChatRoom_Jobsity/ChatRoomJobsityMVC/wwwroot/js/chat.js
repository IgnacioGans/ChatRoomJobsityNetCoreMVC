"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable the send button until connection is established.
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    var li = document.createElement("li");
    document.getElementById("messagesList").appendChild(li);
    // We can assign user-supplied strings to an element's textContent because it
    // is not interpreted as markup. If you're assigning in any other way, you 
    // should be aware of possible script injection concerns.
    li.textContent = `${user} says ${message}`;
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").innerText;
    var message = document.getElementById("messageInput").value;
    ///stock=stock_code
    FireCommand(user, message)
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});


function FireCommand(user, message) {
    /* /stock=stock_code    */
    /* /stock=aapl.us    */
    if (message.startsWith('/stock=')) {
        let getStockCode = message.split("=");
        getStockCode = getStockCode[1];
        console.log("Shoot Stock Command!")
        console.log(message)
        console.log(getStockCode);
        let dataStock = {
            'dataStock': getStockCode,
        };
        $.ajax({
            type: "POST",
            url: "/ChatRoom/ReadCSVFromURL",
            data: dataStock,
            dataType: "json",
            beforeSend: function () {

            },
            success: function (response) {
                console.log(response)
                let ValStock = response[0].symbol;
                let ValOpenStock = response[0].open;
                let messageResult = `“ ${ValStock} quote is $${ValOpenStock} per share”`;
                connection.invoke("SendMessage", user, messageResult).catch(function (err) {
                    return console.error(err.toString());
                });
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log("Check System")
            },
            complete: function (data) {

            }
        });
    }
}


