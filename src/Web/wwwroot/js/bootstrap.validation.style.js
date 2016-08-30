$(function () {
    // any validation summary items should be encapsulated by a class alert and alert-danger
    $('.validation-summary-errors').each(function () {
        $(this).addClass('alert');
        $(this).addClass('alert-danger');
    });

    // check each form-group for errors on ready
    $('form').each(function () {
        $(this).find('div.form-group').each(function () {
            if ($(this).find('span.field-validation-error').length > 0) {
                $(this).addClass('has-error');
            }
        });
    });
});

var page = function () {
    //Update the validator
    $.validator.setDefaults({
        highlight: function (element) {
            $(element).closest(".form-group").addClass("has-error");
            $(element).closest(".form-group").removeClass("has-success");
        },
        unhighlight: function (element) {
            $(element).closest(".form-group").removeClass("has-error");
            $(element).closest(".form-group").addClass("has-success");
        }
    });
}();