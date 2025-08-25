function validateuser(){
            const username = document.getElementById("username").value.trim();
            const NameErr = document.getElementById("NameErr");
            const np = /^[a-zA-Z0-9._]+$/;
            if (!username) {
                NameErr.textContent = 'Please enter a username.';
                return false;
            }else if (username.length < 3 || username.length >31 ) {
                NameErr.textContent = 'Password must be at least 3 characters and atmost 30 characters.';
                return false;
            }  
            else if (!np.test(username)) {
                NameErr.textContent = 'Please enter a valid username.';
                return false;
            } else {
                NameErr.textContent = '';
                return true;
            }
        }

        function validatemobileno() {
            const mobileno = document.getElementById("mobileno").value.trim();
            const mobilenoErr = document.getElementById("mobilenoErr");
            if (!mobileno) {
                mobilenoErr.textContent = 'Please enter a mobile number.';
                return false;
            }
            else if(mobileno[0] != '6' && mobileno[0] != '7' && mobileno[0] != '8' && mobileno[0] != '9'){
                mobilenoErr.textContent="Mobile must starts from either 6,7,8 or 9";
                return false;
            } 
            else if (mobileno.length != 10) {
                mobilenoErr.textContent = 'Mobile number must be 10 digits.';
                return false;
            } else {
                mobilenoErr.textContent = '';
                return true;
            }
        }

        function validatepwd() {
            const pwd = document.getElementById("password").value.trim();
            const pwdErr = document.getElementById("pwdErr");
            if (!pwd) {
                pwdErr.textContent = 'Please enter a password.';
                return false;
            }  else if (pwd.length < 8) {
                pwdErr.textContent = 'Password must be at least 8 characters.';
                return false;
            }  else {
                pwdErr.textContent = '';
                return true;
            }
        }
        

        function Validation() {
            const isValidUser = validateuser();
            const isValidMobile = validatemobileno();
            const isValidPwd = validatepwd();


            
            if( isValidUser &&  isValidMobile &&  isValidPwd ){
                return true;

            }
            else{
                return false;
            }
        }