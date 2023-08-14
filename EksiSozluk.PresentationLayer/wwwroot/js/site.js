$(document).ready(function () {
    $(".nav-link").click(function (e) {
        e.preventDefault();

        var categoryId = $(this).data("category-id");
        loadCategoryHeadings(categoryId);
    });
});

function loadCategoryHeadings(categoryId) {
    $("#headers").empty();
    $.ajax({
        url: "/Category/HeadingsByCategory",
        type: "GET",
        data: { categoryId: categoryId },
        success: function (data) {
            $("#headers").html(data);
        }
    });
}
