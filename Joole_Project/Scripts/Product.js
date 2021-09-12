
$(document).ready(function () {
    $("#product-type-button").click(function () {
        $('#product-types').slideToggle('slow');
    });
    $("#tech-specs-label").click(function () {
        $('#tech-specs-dropdown').slideToggle('slow');
    });
});