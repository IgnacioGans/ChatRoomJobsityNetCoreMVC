"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable the send button until connection is established.
document.getElementById("sendButton").disabled = true;
document.getElementById("createRoomButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    //console.log(message)
    let messageTxt = message.message;
    let timestamp = message.timestamp;
    let formatuser = FormatUser(user)
    let currentUserInChat = $("#userInput").text();
    currentUserInChat = FormatUser(currentUserInChat)
    var li = document.createElement("li");
    let currentusermsg = formatuser == currentUserInChat ? "current-user-message" : "other-user-message";
    li.className = `msg-from-user username-${formatuser} ${currentusermsg}`;
    li.innerHTML = `
        <div class="msgTxt">
            ${user} says ${messageTxt}
        </div>
        <div class="timestamp">
            timestamp => ${timestamp}
        </div>
    `;
    
    li.className = `msg-from-user username-${formatuser} ${currentusermsg}`;
    document.getElementById("messagesList").appendChild(li);
    // We can assign user-supplied strings to an element's textContent because it
    // is not interpreted as markup. If you're assigning in any other way, you 
    // should be aware of possible script injection concerns.
    let countList = $("#messagesList li").length;
    if (countList > 50) {
        console.log("this is 50 elements, show only this message")
        //$(`#messagesList li`).slice(0, 50).addClass('d-none')
        //$(`#messagesList li`).first().addClass("d-none")
        /*Nightmare task - very simple thing -_-*  */
        $(`#messagesList li`).first().remove()
    }
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
    document.getElementById("createRoomButton").disabled = false;
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
        //console.log("Shoot Stock Command!")
        //console.log(message)
        //console.log(getStockCode);
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
                if (response.statusBool) {
                    let ValStock = response.resultData[0].symbol;
                    let ValOpenStock = response.resultData[0].open;
                    let messageResult = `“ ${ValStock} quote is $${ValOpenStock} per share”`;
                    connection.invoke("SendMessage", user, messageResult).catch(function (err) {
                        return console.error(err.toString());
                    });
                } else {
                    let messageResult = `“${response.resultData}”`;
                    connection.invoke("SendMessage", user, messageResult).catch(function (err) {
                        return console.error(err.toString());
                    });
                }
                
            },
            error: function (jqXHR, textStatus, errorThrown) {
                //console.log("Check System")
                let messageResult = `not found this stock [${getStockCode}]`;
                connection.invoke("SendMessage", user, messageResult).catch(function (err) {
                    return console.error(err.toString());
                });
            },
            complete: function (data) {

            }
        });
    } 
}


function FormatUser(user) {
    let formatuser = user.toLowerCase();
    formatuser = formatuser.replace(/\s+/g, '');
    //console.log(formatuser)
    return formatuser;
}


function StyleChat(formatuser) {
    let currentUserInChat = $("#userInput").text();
    currentUserInChat = FormatUser(currentUserInChat);
    if (formatuser == currentUserInChat) {
        $(`.username-${currentUserInChat}`).css({
            "align-self": "flex-start"
        });
    } else {
        $(".msg-from-user").css({
            "background": "#262946"
        });
    }
   
}
