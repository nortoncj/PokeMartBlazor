window.ShowToastr = (type, message) => {
    if (type === "success") {
        toastr.success(message, "Operation Successful", { timeOut: 5000 });
    }
    if (type === "info") {
        toastr.info(message, "Note", { timeOut: 5000 });
    }
    if (type === "warning") {
        toastr.warning(message, "Warning", { timeOut: 5000 });
    }
    if (type === "error") {
        toastr.error(message, "Operation Failure", { timeOut: 5000 });
    }
}

window.ShowAlert = (icon, title) => {
    
        Swal.fire({
            icon: icon,
            title: title,

        })
    
}

function ShowDeleteConfirmationModal() {
    $('#deleteConfirmationModal').modal('show');
}

function HideDeleteConfirmationModal() {
    $('#deleteConfirmationModal').modal('hide');
}