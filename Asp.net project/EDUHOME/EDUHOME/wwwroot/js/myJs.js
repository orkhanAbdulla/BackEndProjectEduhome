let inputSub;
$(document).on('click', `#button-subscribe`, function () {
    inputSub = $("#input-subscribe").val();
    $("#response-sub").empty()
    $.ajax({
        url: `/Account/Subscribe`,
        data: {
            "email": inputSub,
        },
        type: "Post",
        success: function (res) {
            $("#response-sub").append(res)
        }
    })
})
$(document).on('keyup',`#Course-search`, function () {
    console.log($(this).val())
    $("#New-Courses").empty()
    if ($(this).val().length > 0) {
        $.ajax({
            url: `/Courses/Search`,
            data: {
                "search": $(this).val(),
            },
            type: "Get",
            success: function (res) {
                console.log("sdsad")
                $("#Old-Courses").css("display", "none")
                $("#New-Courses").append(res)
            }
        })
    }
    else {
        $("#Old-Courses").css("display", "block")

    }



})