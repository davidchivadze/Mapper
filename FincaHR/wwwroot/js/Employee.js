$(document).ready(function () {
    $('#UserImageUpload').change(function () {
        readURL(this);
    });
    $('#EmployeeGender').click(function () {
        $.ajax({
            url: '/',


        });

    })
});

function readURL(input) {

    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#UserImageView').attr('src', e.target.result);
        }


        reader.readAsDataURL(input.files[0]);
    }
}