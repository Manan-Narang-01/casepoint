function validateuser(){
            const username = document.getElementById("username").value.trim();
            const NameErr = document.getElementById("NameErr");
            const np = /^[a-zA-Z]+$/;
            if (!username) {
                NameErr.textContent = 'Please enter a username.';
                return false;
            } else if (!np.test(username)) {
                NameErr.textContent = 'Please enter a valid username.';
                return false;
            } else {
                NameErr.textContent = '';
                return true;
            }
        }

        function validategender() {
            const genderMale = document.getElementById("GenderMale");
            const genderFemale = document.getElementById("GenderFemale");
            const genderErr = document.getElementById("genderErr");
            if (!genderMale.checked && !genderFemale.checked) {
                genderErr.textContent = 'Please select a gender.';
                return false;
            } else {
                genderErr.textContent = '';
                return true;
            }
        }

        function validatedob() {
            const dob = document.getElementById("dob").value.trim();
            const dobErr = document.getElementById("dobErr");
            if (!dob) {
                dobErr.textContent = 'Please select a date of birth.';
                return false;
            } else {
                dobErr.textContent = '';
                return true;
            }
        }

        function validatecountry() {
            const country = document.getElementById("country").value.trim();
            const countryErr = document.getElementById("countryErr");
            if (country=='Country') {
                countryErr.textContent = 'Please select a country.';
                return false;
            } else {
                countryErr.textContent = '';
                return true;
            }
        }

        function validatemobileno() {
            const mobileno = document.getElementById("mobileno").value.trim();
            const mobilenoErr = document.getElementById("mobilenoErr");
            if (!mobileno) {
                mobilenoErr.textContent = 'Please enter a mobile number.';
                return false;
            } else if (mobileno.length != 10) {
                mobilenoErr.textContent = 'Mobile number must be 10 digits.';
                return false;
            } else {
                mobilenoErr.textContent = '';
                return true;
            }
        }

        function validateemail() {
            const email = document.getElementById("email").value.trim();
            const emailErr = document.getElementById("emailErr");
            const ep = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
            if (!email) {
                emailErr.textContent = 'Please enter an email address.';
                return false;
            } else if (!ep.test(email)) {
                emailErr.textContent = 'Please enter a valid email address.';
                return false;
            } else {
                emailErr.textContent = '';
                return true;
            }
        }

        function validatepwd() {
            const pwd = document.getElementById("password").value.trim();
            const pwdErr = document.getElementById("pwdErr");
            if (!pwd) {
                pwdErr.textContent = 'Please enter a password.';
                return false;
            }  else if (pwd.length < 6) {
                pwdErr.textContent = 'Password must be at least 6 characters.';
                return false;
            }  else {
                pwdErr.textContent = '';
                return true;
            }
        }
        
        function validatecpwd(){
            const pwd = document.getElementById("password").value.trim();
            const cpwd = document.getElementById("cpassword").value.trim();
            const cpwdErr = document.getElementById("cpwdErr");
            if (!cpwd) {
                cpwdErr.textContent = 'Please confirm your password.';
                return false;
            }
            else if (pwd !== cpwd) {
                cpwdErr.textContent = 'Passwords do not match.';
                
                return false;
            }
            else {
                cpwdErr.textContent='';
                return true
            }
        }

        function validateterms() {
            const agree = document.getElementById("agree");
            const agreeErr = document.getElementById("agreeErr");
            if (!agree.checked) {
                agreeErr.textContent = 'You must agree to the terms and conditions.';
                return false;
            } else {
                agreeErr.textContent = '';
                return true;
            }
        }

        function Validation() {
            const isValidUser = validateuser();
            const isValidGender = validategender();
            const isValidDOB = validatedob();
            const isValidCountry = validatecountry();
            const isValidMobile = validatemobileno();
            const isValidEmail = validateemail();
            const isValidPwd = validatepwd();
            const isValidTerms = validateterms();
            const isValidCpwd = validatecpwd();


            
            if( isValidUser && isValidGender && isValidDOB && isValidCountry && isValidMobile && isValidEmail && isValidPwd && isValidTerms && isValidCpwd){
                return true;

            }
            else{
                return false;
            }
        }