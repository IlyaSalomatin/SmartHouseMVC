

//$(".badrobotHREF-popup").magnificPopup({
//        type: "inline"
// });

$("#badrobotbutton").click(function(){
    $(".sorryText").hide();
    $(".loginpage").show("slow");
});

$("#buttomFormPass").click(function(){
    $.ajax({
        url: "/MyAuthentication/AuthLogin",
        type: "POST",
        data: {
            Name: $("#Name").val(),
            Password: $("#Password").val(),
        },
    });
});