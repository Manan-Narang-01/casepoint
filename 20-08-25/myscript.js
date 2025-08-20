var isLightOn=false
        function toggleLight(){
            var imgElement=document.getElementById("myimage")
            if(isLightOn){
                imgElement.src='off.png'
            }else{
                imgElement.src='on.png'
            }
            isLightOn=!isLightOn
        }
