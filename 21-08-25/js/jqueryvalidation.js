$(document).ready(function(){
    $('#username').on('input',validateName);
    $('#mobileno').on('input',validateMobileno);
    $('#email').on('input',validateEmail);
    $('input[name="Gender"]').on('change', validateGender);
    $('#country').on('change',validateCountry);
    $('#dob').on('change',validateDob);
    $('#password').on('input',validatePwd);
    $('#cpassword').on('input',validateCpwd);
    $('#agree').on('change',validateTerms);

    $("#dobErr").hide();
    
    
    function validateName(){
        
        const name=$('#username').val().trim();
        const namepattern=/^[a-zA-Z]+$/;    
        if(name=='' || name==null){
            $("#NameErr").html("Please enter your name")
            return false;

        }else if(!namepattern.test(name)){
            $("#NameErr").html("Name can only contain letters (A–Z or a–z).")
            return false;
        }
        else{
            $("#NameErr").html("")
            return true;

        }
    }
    
    function validateMobileno(){
        const mobileno=$('#mobileno').val().trim();
        if(mobileno=='' || mobileno==null){
            $("#mobilenoErr").html("Please enter your mobile numbe");
            return false;

        }else if(mobileno[0] != '6' && mobileno[0] != '7' && mobileno[0] != '8' && mobileno[0] != '9'){
            $("#mobilenoErr").html("Mobile must starts from either 6,7,8 or 9");
            return false;
        }
        else if(mobileno.length != 10){
            $("#mobilenoErr").html("Mobile No must be exactly 10 digits");
            return false;
        }
        else{
            $("#mobilenoErr").html("");
            return true;

        }
    }

    function validateEmail(){
        const email=$('#email').val().trim();
        const emailpattern=/^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
        if(email==''||email==null){
            $("#emailErr").html("Please enter your email-id");
            return false;
        
        }else if(!emailpattern.test(email)){
            $("#emailErr").html("Please enter the valid email-id")
            return false;
        }
        else{
            $("#emailErr").html("")
            return true;

        }
    }

     function validateGender() {
        const genderMale = $('#GenderMale').prop('checked');
        const genderFemale = $('#GenderFemale').prop('checked');
        if (!genderMale && !genderFemale) {
            $('#genderErr').html("Please select your gender");
            return false;
        } else {
            $('#genderErr').html("");
            return true;
        }
    }


    function validateDob(){
        const dob=$('#dob').val().trim();
        if(!dob){
            $("#dobErr").show();
            return false;
        
        }
        else{
            $("#dobErr").hide("");
            return true;


        }



    }

    function validatePwd(){
        const pwd=$('#password').val().trim();
        
        if(pwd==''||pwd==null){
            $("#pwdErr").html("Please enter your password");
            return false;
        
        }else if(pwd.length<6){
            $("#pwdErr").html("Password must be atleast 6 Characters")
            return false;
        }
        else{
            $("#pwdErr").html("");
            return true;


        }
    }

    function validateCpwd(){
        const pwd=$('#password').val().trim();
        const cpwd=$('#cpassword').val().trim();

        if(cpwd==''||cpwd==null){
            $("#cpwdErr").html("Please confirm your password");
            return false;
        
        }else if(pwd!=cpwd){
            $("#cpwdErr").html("Password must be same");
            return false;
        }
        else{
            $("#cpwdErr").html("");
            return true;


        }
    }

    function validateTerms() {
    const terms = $('#agree');
    if (!terms.prop('checked')) {
        $('#agreeErr').html("You must agree terms and conditions");
        return false;
    } else {
        $('#agreeErr').html("");
        return true;
    }
}

    function validateCountry() {
            const country = $('#country').val().trim();
            if (country=='Country') {
            $('#countryErr').html("please select your Country");
                return false;
            } else {
            $('#countryErr').html("");
                return true;
            }
        }



 $("#signupform").on('submit',function(e){
    
            e.preventDefault();

            const isValidUser = validateName();
            const isValidGender = validateGender();
            const isValidDOB = validateDob();
            const isValidCountry = validateCountry();
            const isValidMobile = validateMobileno();
            const isValidEmail = validateEmail();
            const isValidPwd = validatePwd();
            const isValidTerms = validateTerms();
            const isValidCpwd = validateCpwd();


            
            if( isValidUser && isValidGender && isValidDOB && isValidCountry && isValidMobile && isValidEmail && isValidPwd && isValidTerms && isValidCpwd){
                HTMLFormElement.prototype.submit.call(this);
            }
            else{
                return false;
            }
            
            
        })
    

})