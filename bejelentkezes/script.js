$(document).ready(function(){
    
    if (location.href.indexOf("eszkozok") > -1){
        eszk();
    }
});

function eszk(){
    $.get("php/eszkozok.php", function(adat){$(".eszkozok").html(adat)});
}