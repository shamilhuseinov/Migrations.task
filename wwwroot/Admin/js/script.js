$(document).ready(function () {
    $("#delete").click(function (event) {
        event.preventDefault();
    });
})

function ConfirmDelete() {
    if (confirm("Are you sure?")) {
        return true;
    }
    else {
        return false;
    }
}