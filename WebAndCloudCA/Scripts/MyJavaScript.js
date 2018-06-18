$(document).ready(function ()
{
    $("#slideShowImg > div:gt(0)").hide();
setInterval(function()
{
    $('#slideShowImg > div:first').fadeOut(0).next().fadeIn(1500).end().appendTo('#slideShowImg');
}, 4000);
});


$(document).ready(function ()
{
    $(".answer").hide();
    $(".question").bind('click', function () {
        $(this).next().toggle();
    })    
})