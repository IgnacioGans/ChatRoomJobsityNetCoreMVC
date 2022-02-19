////document.getElementById("createRoomButtonTest").addEventListener("click", function (event) {
////    var user = document.getElementById("userInput").innerText;
////    var nameGroup = "RemkingCreateRoom";
////    connection.invoke("JoinRoom", user, nameGroup).catch(function (err) {
////        return console.error(err.toString());
////    });
////    event.preventDefault();
////});

//document.getElementById("testChatButton").addEventListener("click", function (event) {
//    var user = document.getElementById("userInput").innerText;
//    var nameGroup = "RemkingTest";
//    connection.invoke("TestRoom", user, nameGroup).catch(function (err) {
//        return console.error(err.toString());
//    });
//    event.preventDefault();
//});



//document.getElementById("sendMsgToSpecificGroup").addEventListener("click", function (event) {
//    var user = document.getElementById("userInput").innerText;
//    var nameGroup = document.getElementById("nameRoomInput").value;

//    connection.invoke("TestRoom", user, nameGroup).catch(function (err) {
//        return console.error(err.toString());
//    });
//    event.preventDefault();
//});