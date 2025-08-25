
$(document).ready(function () {
    $("#loginform").validate({
        rules: {
            email: {
                required: true,
                email: true
            },
            password: {
                required: true,
                
            }
        },
        messages: {
            email: {
                required: "Please enter email id",
                email: "Please enter valid email id"
            },
            password: {
                required: "Please enter the password",
            }
        },
        submitHandler: function (form) {
            form.submit();
        }
    });
});

