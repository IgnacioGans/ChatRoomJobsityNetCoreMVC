// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$.ajax({
    type: "POST",
    url: "/Login/Index",
    dataType: "json",
    beforeSend: function () {
        $(".loading-sportbook").css('display', 'flex');
    },
    success: function (response) {
        console.log(response)
    },
    error: function (jqXHR, textStatus, errorThrown) {
        console.log("Revisar Sistema")
    },
    complete: function (data) {
        $(".loading-sportbook").hide()
    }
});