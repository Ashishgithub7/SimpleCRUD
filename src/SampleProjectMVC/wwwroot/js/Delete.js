$(function () {
    $(".delete").each(function () {
        const $this = $(this);
        $this.bootstrap_confirm_delete({
            heading: 'Confirm Delete',
            message: `Are you sure you want to delete "${$this.data('name')}"?`,

            callback: function (e) {
                debugger;
                const Id = $this.data('id');
                const type = $this.data('type');
                $.ajax({
                    url: `/${type}/Delete/${Id}`,
                    type: 'DELETE',
                    success: function (response) {
                        debugger;
                        if (response.status === "Success") {
                            $('#bootstrap-confirm-dialog').modal('hide');
                            alertMessage(response.message, statusEnum.Success);
                            setTimeout(() => { location.href = `/${type}/List`; }, 200);

                        } else {
                            $('#bootstrap-confirm-dialog').modal('hide');
                            alertMessage(response.errors.join('\r\n'));
                        }
                    },
                    error: function (error) {
                        console.log(error)
                    }
                })
            },
            cancel_callback: function (e) {
                $('#bootstrap-confirm-dialog').modal('hide');
            }
        });

    });
    $(document).on('click', '#bootstrap-confirm-dialog .close', function () {
        $('#bootstrap-confirm-dialog').modal('hide')
    });
});