<script type="text/javascript" src="http://code.jquery.com/jquery-latest.js"></script>
<script type="text/javascript" src="~/js/jquery.nivo.slider.js"></script>
<script type="text/javascript" src="~/js/jquery.prettyPhoto.js"></script>
<script type="text/javascript" src="~/js/twitter.js"></script>
<script type="text/javascript" src="~/js/custom.js"></script>
<script type="text/javascript" src="http://code.jquery.com/jquery-latest.js"></script>
<script type="text/javascript" src="~/js/jquery.nivo.slider.js"></script>
<script src="~/js/jquery.prettyPhoto.js" type="text/javascript"></script>
<script type="text/javascript" src="~/js/twitter.js"></script>
<script type="text/javascript" src="~/js/custom.js"></script>
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
<script type="text/javascript">

    var _gaq = _gaq || [];
    _gaq.push(['_setAccount', 'UA-38894527-2']);
    _gaq.push(['_trackPageview']);

    (function () {
        var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
        ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
        var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
    })();

</script>
