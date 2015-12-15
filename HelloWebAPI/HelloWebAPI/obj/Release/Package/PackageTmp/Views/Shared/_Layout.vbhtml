<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width" />    
    <link href="~/css/main.css" rel="stylesheet" />
    <link href="~/css/normalize.css" rel="stylesheet" />
    <script src="~/js/vendor/jquery-1.10.2.min.js"></script>    
    <script src="~/js/vendor/jquery-ui-1.10.3.custom.min.js"></script>
    <script src="~/js/main.js"></script>
    <script src="~/js/vendor/modernizr.custom.min.js"></script>
    <script src="~/js/main.js"></script>
    <link href="~/css/default.css" rel="stylesheet" type="text/css" media="all" />
    <link href="~/css/fonts.css" rel="stylesheet" type="text/css" media="all" />
    <meta name="keywords" content="" />
    <meta name="description" content="" />
    <link href="http://fonts.googleapis.com/css?family=Open+Sans:400,300,600,700,800" rel="stylesheet" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>


</head>

<body>
    <div id="header-wrapper">
        <div id="header" class="container">
            <div id="logo">
                <img src="~/img/logo.png" width="40" height="40" />
                <h1><a href="#">BMW 汎德</a></h1>
            </div>
            <div id="menu">
                <ul>
                    <li>
                        <a href="#" id="doubleCar">雙門跑車 &#9662;</a>
                        <ul class="dropdown">
                            
                        </ul>
                    </li>
                    <li>
                        <a href="#" id="fourCar">四門房車 &#9662;</a>
                        <ul class="dropdown">                            
                        </ul>
                    </li>
                    <li>
                        <a href="#" id="touring">Touring &#9662;</a>
                        <ul class="dropdown"> 
                        </ul>
                    </li>
                    <li><a href="#">預約賞車</a></li>
                    <li><a href="#">聯絡我們</a></li>
                </ul>
            </div>
        </div>
    </div>

    <div id="header-featured">
        <div class="slideshow" style=" background-color:black">
            <div class="slideshow-slides">
                <a href="./" class="slide" id="slide-1" style="margin: auto;">
                    <img src="~/img/slide-1.jpg" alt="" width="1600" height="465">
                </a>
                <a href="./" class="slide" id="slide-2">
                    <img src="~/img/slide-2.jpg" alt="" width="1600" height="465">
                </a>
                <a href="./" class="slide" id="slide-3">
                    <img src="~/img/slide-3.jpg" alt="" width="1600" height="465">
                </a>
                <a href="./" class="slide" id="slide-4">
                    <img src="~/img/slide-4.jpg" alt="" width="1600" height="465">
                </a>
            </div>
            <div class="slideshow-nav">
                <a href="#" class="prev">Prev</a>
                <a href="#" class="next">Next</a>
            </div>
            <div class="slideshow-indicator"></div>
        </div>
    </div>
    <br />
    <br />
    <div id="banner" class="container">
        <h2>勝者為王 強勢回歸</h2>
        <span>KING of Empire</span>
    </div>


    @RenderBody()
    @Scripts.Render("~/bundles/jquery")
    @RenderSection("scripts", required:=False)

    <script>
        $(function () {
            $('#doubleCar').fadeIn().on('mouseenter', function () {
                getService(1, $(this)) //doubleCar    
            }).on('mouseleave', function () {
                $(this).next().children('li').remove();
            });
            $('#fourCar').fadeIn().on('mouseenter', function () {
                getService(2, $(this)) //doubleCar    
            }).on('mouseleave', function () {
                $(this).next().children('li').remove();
            });
            $('#touring').fadeIn().on('mouseenter', function () {
                getService(3, $(this)) //doubleCar    
            }).on('mouseleave', function () {
                $(this).next().children('li').remove();
            });


            function getService(value,target)
            {
                $.getJSON("/api/Products/" + value, function (data) {
                    var li = "<li></li>";
                    var d = "<div></div>";
                    var img = "<img src='../../img/"+data.fileName+"' width='300' height='110' />";
                    var sp = "<span style='margin-left:25%;'>" + data.Name + "</span>";
                    var result = $(li).append(d).append(img).append(sp)
                    //alert(result)
                    $(target).next().append(result);
                })
            }

        })
       
    </script>


</body>
</html>
