$(document).ready(function() {

    $('#show-more-1').css("display", "none");
    $('#btn-show-1').click(function() {
        $('#show-more-1').css("display", "block");
        $('#btn-show-1').css("display", "none");

    })
    $('#btn-hide-1').click(function() {
        $('#show-more-1').css("display", "none");
        $('#btn-show-1').css("display", "block");

    })

    $('#show-more-2').css("display", "none");
    $('#btn-show-2').click(function() {
        $('#show-more-2').css("display", "block");
        $('#btn-show-2').css("display", "none");

    })
    $('#btn-hide-2').click(function() {
        $('#show-more-2').css("display", "none");
        $('#btn-show-2').css("display", "block");

    })
    $('#show-more-3').css("display", "none");
    $('#btn-show-3').click(function() {
        $('#show-more-3').css("display", "block");
        $('#btn-show-3').css("display", "none");

    })
    $('#btn-hide-3').click(function() {
        $('#show-more-3').css("display", "none");
        $('#btn-show-3').css("display", "block");

    })
    $('#show-more-4').css("display", "none");
    $('#btn-show-4').click(function() {
        $('#show-more-4').css("display", "block");
        $('#btn-show-4').css("display", "none");

    })
    $('#btn-hide-4').click(function() {
        $('#show-more-4').css("display", "none");
        $('#btn-show-4').css("display", "block");

    })
    $('#show-more-5').css("display", "none");
    $('#btn-show-5').click(function() {
        $('#show-more-5').css("display", "block");
        $('#btn-show-5').css("display", "none");

    })
    $('#btn-hide-5').click(function() {
        $('#show-more-5').css("display", "none");
        $('#btn-show-5').css("display", "block");

    })
    $('#show-more-6').css("display", "none");
    $('#btn-show-6').click(function() {
        $('#show-more-6').css("display", "block");
        $('#btn-show-6').css("display", "none");

    })
    $('#btn-hide-6').click(function() {
        $('#show-more-6').css("display", "none");
        $('#btn-show-6').css("display", "block");

    })
    $('#show-more-7').css("display", "none");
    $('#btn-show-7').click(function() {
        $('#show-more-7').css("display", "block");
        $('#btn-show-7').css("display", "none");

    })
    $('#btn-hide-7').click(function() {
        $('#show-more-7').css("display", "none");
        $('#btn-show-7').css("display", "block");

    })
    $('#show-more-8').css("display", "none");
    $('#btn-show-8').click(function() {
        $('#show-more-8').css("display", "block");
        $('#btn-show-8').css("display", "none");

    })
    $('#btn-hide-8').click(function() {
        $('#show-more-8').css("display", "none");
        $('#btn-show-8').css("display", "block");

    })
});

function Previous() {
    window.location = '/home/Index'
}

function getParameterByName(name, url = window.location.href) {
    name = name.replace(/[\[\]]/g, '\\$&');
    var regex = new RegExp('[?&]' + name + '(=([^&#]*)|&|#|$)'),
        results = regex.exec(url);
    if (!results) return null;
    if (!results[2]) return '';
    return decodeURIComponent(results[2].replace(/\+/g, ' '));
}

