$(document).ready(function(){

    //left-menu
    $('.left_menu').hover(function () {
        $(this).css('left', '0px')
            
        }, function () {
        $(this).css('left', '-60px')
            
        }
    );


    




    //----------------------


    $('.wholeList').click(function() { 
        $('.title h2').text("Просмотр продукции")       
        
    });
    $('.New').click(function (e) { 
        $('.title h2').text("Добавление нового товара")       
    });
    $('.Name').click(function (e) { 
        $('.title h2').text("Изменение заголовка")       
    });
    $('.Price').click(function (e) { 
        $('.title h2').text("Изменение цены")       
    });
    $('.Description').click(function (e) { 
        $('.title h2').text("Изменение описания")

    });

    //rightSide

    $('.wholeList_rightSide').hover(function () {
            $(this).css("right", "0")
            
        }, function () {
            $(this).css("right", "-270px")
        }
    );

    




})