

$("#badrobotbutton").click(function(){
    $(".sorryText").hide();
    $(".loginpage").show("slow");
});

$("#maneMenu").click(
    function () {
        document.location.replace("/Home/Index"); 
    }
 );

$("#offonButtonFrostedGlass").click(
    function () {
        if ($("#offonButtonFrostedGlass").val == "off") {
            $("#offonButtonFrostedGlass").val = "on";
        }
        else {
            $("#offonButtonFrostedGlass").val = "off";
        }
    }
 );

//$("#buttomFormPass").click(function(){
//    $.ajax({
//        url: "/Authentication/AuthLogin",
//        type: "POST",
//        data: {
//            Name: $("#Name").val(),
//            Password: $("#Password").val(),
//        },

//    }).done(function () {
//        window.location.href = "/";
//    });

//});