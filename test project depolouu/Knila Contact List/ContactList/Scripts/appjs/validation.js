(function ($) {
    var defaultOptions = {
        validClass: 'has-success',
        errorClass: 'has-error',
        highlight: function (element, errorClass, validClass) {
            $(element).closest(".form-contol-group")
                .removeClass(validClass)
                .addClass('has-error');
        },
        unhighlight: function (element, errorClass, validClass) {
            $(element).closest(".form-contol-group")
            .removeClass('has-error')
            .addClass(validClass);
        }
    };

    

    $.validator.setDefaults(defaultOptions);

    $.validator.unobtrusive.options = {
        errorClass: defaultOptions.errorClass,
        validClass: defaultOptions.validClass
    };
})($);