"use strict";
document.getElementById("createRoomButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").innerText;
    var nameGroup = document.getElementById("nameRoomInput").value;
    let shortId = FormatUser(nameGroup)
    let addListRoom = $("<li>", {
        class: `list-group-item room room-name-${nameGroup}`,
        text: nameGroup
    }).attr({
        "role": "presentation"
    })
    let addTabChatRoom = $("<li>", {
        class: `nav-item room-name-${shortId}`,
        text: nameGroup,
        html: $("<a>", {
            class: "nav-link",
            id: `${shortId}-chat-tab`,
            href: `#${shortId}-chat`,
            text: nameGroup
        }).attr({
            "data-toggle": "tab",
            "role": "tab",
            "aria-controls": `${shortId}-chat`,
            "aria-selected":"true"
        })
    })


    let addHrTag = $("<hr>");
    let fieldMsg = $("<div>", {
        class: "col-9",
        html: $("<input>", {
            type: "text",
            id: `messageInput-${nameGroup}`,
            class: "form-control",
            placeholder: "write message"
        })
    })
    let addBtnSendChat = $("<div>", {
        class: "col-3",
        html: $("<input>", {
            type: "button",
            id: `sendButton-${nameGroup}`,
            class: "btn btn-primary",
            placeholder: "write message",
            value: "Send Message"
        })
    });
    let blockCommand = $("<div>", {
        class: "form-groups row",
    }).append(fieldMsg, addBtnSendChat)
    let addContentTabChatRoom = $("<div>", {
        id: `${shortId}-chat`,
        class: `tab-pane fade`,
        html: $("<div>", {
            class: "box-chat-message",
            html: $("<div>", {
                class: "message-wrapper",
                html: $("<ul>", {
                    id: `${shortId}List`
                })
            })
        })
    }).attr({
        "role": "tabpanel",
        "aria-labelledby": `${shortId}-chat-tab`,
    }).append(addHrTag, blockCommand)
  

    $(".default-list").remove();
    $("#list-name-room").append(addListRoom);
    $("#ListChatTab").append(addTabChatRoom);
    $("#ChatContent").append(addContentTabChatRoom);
    $("#ListChatTab li a").removeClass("active");
    $("#ChatContent .tab-pane.fade").removeClass("show active");
    $(`#${shortId}-chat-tab`).addClass("active");
    $(`#${shortId}-chat`).addClass("show active");
    
   
    document.getElementById(`sendButton-${shortId}`).addEventListener("click", function (event) {
        console.log("sending from groups?")
        var user = document.getElementById("userInput").innerText;
        var message = document.getElementById(`messageInput-${shortId}`).value;
        let groupname = $("#ListChatTab li a.active").text()
        groupname = FormatUser(groupname)
        ///stock=stock_code
        FireCommand(user, message)
        connection.invoke("SendMessageGroups", user, message, groupname).catch(function (err) {
            return console.error(err.toString());
        });
        event.preventDefault();
    });

    connection.invoke("JoinRoom", user, nameGroup).catch(function (err) {
        return console.error(err.toString());
    });
    connection.on("ReceiveMessageGroup", function (user, message) {
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
        document.getElementById(`${shortId}List`).appendChild(li);
        // We can assign user-supplied strings to an element's textContent because it
        // is not interpreted as markup. If you're assigning in any other way, you 
        // should be aware of possible script injection concerns.
        let countList = $(`#${shortId} li`).length;
        if (countList > 50) {
            console.log("this is 50 elements, show only this message")
            //$(`#messagesList li`).slice(0, 50).addClass('d-none')
            //$(`#messagesList li`).first().addClass("d-none")
            /*Nightmare task - very simple thing -_-*  */
            $(`#${shortId} li`).first().remove()
        }
    });
    event.preventDefault();
});