$(document).ready(function () {

    if (location.href.indexOf("monitor2") > -1) {
        todolist();
        $(document).on('change', '.done', function () {
            let id = $(this).val();
            setToDone(id);
        });
    }
    if (location.href.indexOf("newtask") > -1) {
        getUserData();
    }
});
function todolist() {
    $.get("php/tasklist.php", function (adat) { $(".todolist").html(adat) });
}
function setToDone(id) {
    console.log(id);
    $.post("php/setdone.php", { id: id }, function (data, status) {  //JSON forma -> key : value páros
        todolist(); //frissített lista betöltése, a kész feladat inaktiválva
    });

}