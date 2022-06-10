$(document).ready(function(){

    //left-menu
    $('.left_menu').hover(function () {
        $(this).css('left', '0px')
            
        }, function () {
        $(this).css('left', '-60px')
            
        }
    );


    //----------------------
    // functions

    function ShowMembraneTable(){
        $('.Main h3').text("Семена")
        $('#membraneTable').css("opacity", "0");
        $('#membraneTable').css("z-index", "1");

        $('#seedTable').css("opacity", "1");
        $('#seedTable').css("z-index", "5");

    }


    function ShowSeedTable(){
        $('.Main h3').text("Пленка")
        $('#seedTable').css("opacity", "0");
        $('#seedTable').css("z-index", "1");

        $('#membraneTable').css("opacity", "1");
        $('#membraneTable').css("z-index", "5");

    }
    function popup(){
        $('.Membrane_popup').css("top", "10px");
    }
    function popupBack(){
        $('.Membrane_popup').css("top", "-1000px");
    }


    //--------------
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
            $(this).css("right", "-290px")
        }
    );

    //Changing in tables
    $('#Seed').click(() => ShowMembraneTable());
    $('#Membrane').click(() => ShowSeedTable());
    

    //pop-up
    $('.button_conf').click(() => popup());
    $('.Membrane_popup').click(() => popupBack());

})