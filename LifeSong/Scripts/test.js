$("img").click(function () {
    if ($(this).attr("data-song"))
    {
        //this is the url
        var url = $(this).attr("data-song")
        var audio = $("#player");
        audio.attr("src",url);
    }
    
});
