//function validateEmail() {
//    var email = document.getElementById("emailVal").value;
//    var emailValid = /^([\w-\.]+@([\w-]+\.)+[\w-]{2,4})?$/;
//    if (!(email).match(emailValid)) {
//        alert("Invalid Email...!!!!!!");
//        return false;
//    }
//    else {
//        return true;
//    }
//}


$(document).ready(function ()
{
    $("#slideShowImg > div:gt(0)").hide();
setInterval(function()
{
    $('#slideShowImg > div:first').fadeOut(0).next().fadeIn(1500).end().appendTo('#slideShowImg');
}, 4000);
});


function enableAnswers() {
    hideAnswers();
    var questions = document.getElementsByClassName("question");
    for (var i = 0; i < questions.length; i++) {
        questions[i].onclick = function () {
            var answer = this.nextElementSibling;
            if (isVisible(answer)) {
                answer.style.display = "none";
            }
            else {
                answer.style.display = "block";
            }
        }
    }
}
function hideAnswers() {
    var questions = document.getElementsByClassName("question");
    for (var i = 0; i < questions.length; i++) {
        var answer = questions[i].nextElementSibling;
        if (isVisible(answer)) {
            answer.style.display = "none";
        }
    }
}
function isVisible(element) {
    var result = false;
    if (element.style.display != "none") {
        result = true;
    }
    return result;
}