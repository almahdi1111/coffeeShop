function functionConfirm(Id) {
    const swalWithBootstrapButtons = Swal.mixin({
        customClass: {
            confirmButton: 'btn btn-success',
            cancelButton: 'btn btn-danger'
        },
        buttonsStyling: false
    })

    swalWithBootstrapButtons.fire({
        title: 'Are you sure for Delete this ?',
        text: "Are you sure for Delete !",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonText: 'Yes  !',
        cancelButtonText: 'Cancel ',
        reverseButtons: true,
        timer: 100000
    }).then((result) => {
        if (result.isConfirmed) {
            $("#" + Id + "").submit();
            swalWithBootstrapButtons.fire({
                title: 'Done Delete !',
                text: 'Done',
                icon: 'success',
                timer: '2000000'
            }
            )
        } else if (
            /* Read more about handling dismissals below */
            result.dismiss === Swal.DismissReason.cancel
        ) {
            console.log()
            swalWithBootstrapButtons.fire(
                ' Cancel Deleted',
                '',
                'error'
            )
        }
    })
}