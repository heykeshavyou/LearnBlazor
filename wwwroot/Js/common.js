window.showtoaster = function (type, message) {
    if (type == "success") {
        toastr.success(message);
    }
    if (type == "warning") {
        toastr.warning(message);
    }
    if (type == "error") {
        toastr.error(message);
    }
}
window.alertSweet = function (type,message) {

    if (type == "success") {
        Swal.fire({
        title: "Good job!",
        text: message,
        icon: "success"
    });
    }
    if (type == "error") {
        Swal.fire({
            title: "Bad job!",
            text: message,
            icon: "error"
        });
    }
}