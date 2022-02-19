// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$("#sendForm").click(function (e) {
    e.preventDefault();
    let user = $("#user2").val();
    let password= $("#pass2").val();
    let data = {
        'user': user,
        'password': password,
    };
    $.ajax({
        type: "POST",
        url: "/Login/LoginAjax",
        dataType: "json",
        data: data,
        beforeSend: function () {
            
        },
        success: function (response) {
            console.log(response)
            window.location.href = "/ChatRoom/Index";
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log("Error Ajax")
        },
        complete: function (data) {
            
        }
    });
});