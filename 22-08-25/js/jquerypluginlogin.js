
$(document).ready(function () {
    $("#loginform").validate({
        rules: {
            email: {
                required: true,
                email: true
            },
            password: {
                required: true,
                minlength: 6,
                maxlength: 15
            }
        },
        messages: {
            email: {
                required: "Please enter email id",
                email: "Please enter valid email id"
            },
            password: {
                required: "Please enter the password",
                minlength: "Password must be at least 6 characters",
                maxlength: "Password must be at most 15 characters"
            }
        },
        submitHandler: function (form) {
            form.submit();
        }
    });
});

