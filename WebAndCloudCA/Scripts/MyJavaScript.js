function validateEmail() {
    var email = document.getElementById("emailVal").value;
    var emailValid = /^([\w-\.]+@([\w-]+\.)+[\w-]{2,4})?$/;
    if (!(email).match(emailValid)) {
        alert("Invalid Email...!!!!!!");
        return false;
    }
    else {
        return true;
    }
}

$(document).ready(function()
{
    $("#slideShowImg > div:gt(0)").hide();
setInterval(function()
{
    $('#slideShowImg > div:first').fadeOut(0).next().fadeIn(1500).end().appendTo('#slideShowImg');
}, 4000);
});