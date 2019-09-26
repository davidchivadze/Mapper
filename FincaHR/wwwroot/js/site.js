// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(document).ready(function () {
    $('#CheckAllEmployee').change(function () {
        console.log($("#CheckAllEmployee").prop('checked'));
        if ($("#CheckAllEmployee").prop('checked') === true) {
            $('.employeeCheck').prop('checked',true);

        } else {
            $('.employeeCheck').prop('checked',false);
        }


    });

    $('.employeeCheck').change(function () {

        if ($(this).prop('checked') === false) {
            $("#CheckAllEmployee").prop('checked', false); 
        }

    });

});
