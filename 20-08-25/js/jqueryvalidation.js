$(document).ready(function(){
    $('#username').on('input',validateName);
    $('#mobileno').on('input',validateMobileno);
    $('#email').on('input',validateEmail);
    $('#gender').on('change',validateGender);
    $('#country').on('change',validateCountry);
    $('#dob').on('change',validateDob);
    $('#password').on('input',validatePwd);
    $('#cpassword').on('input',validateCpwd);
    $('#agree').on('change',validateTerms);

    $("#dobErr").hide();
    
    
    function validateName(){
        const $name=$('#username').val().trim();
        const $namepattern=/^[a-zA-Z]+$/;
        if($name=='' || $name==null){
            $("#NameErr").html("please enter the Name")
            return false;

        }else if(!$namepattern.test($name)){
            $("#NameErr").html("please enter the Valid Name")
            return false;
        }
        else{
            $("#NameErr").html("")
            return true;

        }
    }
    
    function validateMobileno(){
        const $mobileno=$('#mobileno').val().trim();
        if($mobileno=='' || $mobileno==null){
            $("#mobilenoErr").html("please enter the Mobile No");
            return false;

        }else if($mobileno.length != 10){
            $("#mobilenoErr").html("Mobile No should be 10 digits");
            return false;
        }
        else{
            $("#mobilenoErr").html("");
            return true;

        }
    }

    function validateEmail(){
        const $email=$('#email').val().trim();
        const $emailpattern=/^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
        if($email==''||$email==null){
            $("#emailErr").html("please enter Email id");
            return false;
        
        }else if(!$emailpattern.test($email)){
            $("#emailErr").html("please enter the valid Email id")
            return false;
        }
        else{
            $("#emailErr").html("")
            return true;

        }
    }

    function validateGender(){
        const $genderMale=$('#GenderMale');
        const $genderFemale=$('#GenderFemale');
        if(!$genderMale.checked && !$genderFemale.checked){

            $('#genderErr').html("please select the Gender");
            return false;
        }

        else{
            $('#genderErr').html("");
            return true;
        }

    }

    function validateDob(){
        const $dob=$('#dob').val().trim();
        if(!$dob){
            $("#dobErr").show();
            return false;
        
        }
        else{
            $("#dobErr").hide("");
            return true;


        }



    }

    function validatePwd(){
        const $pwd=$('#password').val().trim();
        
        if($pwd==''||$pwd==null){
            $("#pwdErr").html("please enter Password");
            return false;
        
        }else if($pwd.length<6){
            $("#pwdErr").html("Password must be 6 Characters")
            return false;
        }
        else{
            $("#pwdErr").html("");
            return true;


        }
    }

    function validateCpwd(){
        const $cpwd=$('#cpassword').val().trim();
        
        if($cpwd==''||$cpwd==null){
            $("#cpwdErr").html("please enter Confirm Password");
            return false;
        
        }else if($pwd!=$cpwd){
            $("#cpwdErr").html("Password must be same");
            return false;
        }
        else{
            $("#cpwdErr").html("");
            return false;


        }
    }

    function validateTerms(){
        const $terms=$('#agree');
        if(!$terms.checked){
            $('#agreeErr').html("please tick the Checkbox");
            return false;
        }

        else{
            $('#agreeErr').html("");
            return true;
        }

    }

    function validateCountry() {
            const $country = document.getElementById("country").value.trim();
            if ($country=='Country') {
            $('#countryErr').html("please select the Country");
                return false;
            } else {
            $('#countryErr').html("");

                
                return true;
            }
        }



 $("#signupform").on('submit',function(e){
    
            e.preventDefault();

            const $isValidUser = validateName();
            const $isValidGender = validateGender();
            const $isValidDOB = validateDob();
            const $isValidCountry = validateCountry();
            const $isValidMobile = validateMobileno();
            const $isValidEmail = validateEmail();
            const $isValidPwd = validatePwd();
            const $isValidTerms = validateTerms();
            const $isValidCpwd = validateCpwd();


            
            if( $isValidUser && $isValidGender && $isValidDOB && $isValidCountry && $isValidMobile && $isValidEmail && $isValidPwd && $isValidTerms && $isValidCpwd){
                return true;

            }
            else{
                return false;
            }
            
            
        })
    

})