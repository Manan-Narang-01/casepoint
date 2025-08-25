$(document).ready(function () {
    debugger;
    $("#signupform").validate({  
        
        rules: {
            username: {
                required: true,
                minlength: 2,
                
            },
            email: {
                required: true,
                email: true
            },
            password: {
                required: true,
                minlength: 6,
                maxlength: 15
            },
            dob: {
                required: true,
                
                
                
            },
            mobileno: {
                required: true,
                digits: true,
                mobileprefix:true,
                minlength: 10,
                maxlength: 10,
            },
            cpassword: {
                required: true,
                equalTo: "#password"
            },
            Gender: {
                required: true
            },
            agree: {
                required: true
            },
            country: {
                required: true,
                notEqual: "Country"
            }
        },
        messages: {
            email: {
                required: "Please enter email id",
                email: "Please enter a valid email id"
            },
            password: {
                required: "Please enter the password",
                minlength: "Password must be at least 6 characters",
                maxlength: "Password must be at most 15 characters"
            },
            mobileno: {
                required: "Please enter your mobile number",
                digits: "Only numbers allowed",
                minlength: "Mobile number must be 10 digits",
                maxlength: "Mobile number must be 10 digits"
            },
            cpassword: {
                required: "Please confirm your password",
                equalTo: "Passwords do not match"
            },
            Gender: {
                required: "Please select gender"
            },
            agree: {
                required: "You must agree to the terms"
            },
            country: {
                required: "Please select your country",
                notEqual: "Please select a valid country"
            }
        },

         errorPlacement: function (error, element) {
            if (element.attr("name") == "Gender") {
                error.insertAfter("#genderErr");  
            } else if (element.attr("name") == "agree") {
                error.insertAfter(element.next());  
            } else {
                error.insertAfter(element); 
            }
        },

        submitHandler: function (form) {
            form.submit();
        }
    });
    $.validator.addMethod("notEqual", function (value, element, param) {
        return this.optional(element) || value !== param;
    }, "Please select a valid option.");

    $.validator.addMethod("mobileprefix",function(value,element){
        return this.optional(element) || /^[6-9]/.test(value);
    },"Mobile No must start with 6,7,8 or 9")
});
