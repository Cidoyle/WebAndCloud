﻿function validateEmail() {
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