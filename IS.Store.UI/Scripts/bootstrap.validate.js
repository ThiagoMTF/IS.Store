$.validator.setDefaults({
    highlight: function (elemento) {
        $(elemento)
            .closest(".form-group")
            .find('input,label,select,textarea,span')
            .addClass('is-invalid')
    },
    unhighlight: function (elemento) {
        $(elemento)
        .closest(".form-group")
        .find('input,label,select,textarea,span')
        .removeClass('is-invalid')
    }
})