$(document).ready(function(){
            $('#email').on('input',validateEmail);
            $('#password').on('input',validatePwd);
        
            function validateEmail(){
                const $email=$('#email').val().trim();
                const $emailpattern=/^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
                if($email==''||$email==null){
                    $("#emailErr").html("please enter Email Id");
                    return false;
                
                }else if(!$emailpattern.test($email)){
                    $("#emailErr").html("please enter the valid Email Id")
                    return false;
                }
                else{
                    $("#emailErr").html("")
                    return true;
        
                }
            }
        
            function validatePwd(){
                const $pwd=$('#password').val().trim();
                
                if($pwd==''||$pwd==null){
                    $("#pwdErr").html("please enter Password");
                    return false;
                
                }
                else{
                    $("#pwdErr").html("");
                    return true;
        
        
                }
            }
        
             $("#loginform").on('submit',function(e){
                    e.preventDefault();
                    const $isValidEmail = validateEmail();
                    const $isValidPwd = validatePwd();
                    if(   $isValidEmail && $isValidPwd ){
                        return true;
                    }
                    else{
                        return false;
                    }
                    
                    
                })
            
        })