<script src="http://code.jquery.com/jquery-latest.js"></script>
<script type="text/javascript" src="js/jquery.nivo.slider.js"></script>
<script src="js/jquery.prettyPhoto.js" type="text/javascript"></script>
<script src="js/twitter.js"></script>    
<script src="js/custom.js"></script>   
<script>
//// Start Simple Sliders ////
$(function () {
    setInterval("rotateDiv()", 10000);
});

function rotateDiv() {
    var currentDiv = $("#simpleslider div.current");
    var nextDiv = currentDiv.next();
    if (nextDiv.length == 0)
        nextDiv = $("#simpleslider div:first");

    currentDiv.removeClass('current').addClass('previous').fadeOut('2000');
    nextDiv.fadeIn('3000').addClass('current', function () {
        currentDiv.fadeOut('2000', function () { currentDiv.removeClass('previous'); });
    });

}
//// End Simple Sliders //// 
</script> 
<script type="text/javascript" charset="utf-8">
    $(document).ready(function () {
        $("a[rel^='prettyPhoto']").prettyPhoto();
    });
</script>

@*Partial Scripts*@

<script type="text/javascript" charset="utf-8" >
    $(function Home()
    {
        $("#content").load("@Url.Action("Index","Home")", { 'id' : '123' }, 
                                        function (response, status, xhr)
        {
            if (status == "error")
            {
                alert("An error occurred while loading the results.");
            }
        });
    });
</script>