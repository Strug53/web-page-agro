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

    function ShowSeedTable(){
        $('.Main h3').text("Семена")
        $('#membraneTable').css("opacity", "0");
        $('#membraneTable').css("z-index", "1");

        $('#SzrTable').css("opacity", "0");
        $('#SzrTable').css("z-index", "1");

        $('#seedTable').css("opacity", "1");
        $('#seedTable').css("z-index", "5");

    }


    function ShowMembraneTable(){
        $('.Main h3').text("Пленка")
        $('#seedTable').css("opacity", "0");
        $('#seedTable').css("z-index", "1");

        $('#SzrTable').css("opacity", "0");
        $('#SzrTable').css("z-index", "1");

        $('#membraneTable').css("opacity", "1");
        $('#membraneTable').css("z-index", "5");

    }
    function ShowSzrTable(){
        $('.Main h3').text("СЗР")
        $('#seedTable').css("opacity", "0");
        $('#seedTable').css("z-index", "1");

        $('#membraneTable').css("opacity", "0");
        $('#membraneTable').css("z-index", "1");

        $('#SzrTable').css("opacity", "1");
        $('#SzrTable').css("z-index", "5");

    }
 
    //---------------------------
    function showMembraneForm(){
        $('#SeedForm').css("opacity", "0");
        $('#SeedForm').css("z-index", "0");

        $('#SzrForm').css("opacity", "0");
        $('#SzrForm').css("z-index", "0");

        $('#MembraneForm').css("opacity", "1");
        $('#MembraneForm').css("z-index", "1");
        
    }
    function showSeedForm(){
        $('#MembraneForm').css("opacity", "0");
        $('#MembraneForm').css("z-index", "0");

        $('#SzrForm').css("opacity", "0");
        $('#SzrForm').css("z-index", "0");

        $('#SeedForm').css("opacity", "1");
        $('#SeedForm').css("z-index", "1");
        
    }
    function showSzrForm(){
        $('#MembraneForm').css("opacity", "0");
        $('#MembraneForm').css("z-index", "0");

        $('#SeedForm').css("opacity", "0");
        $('#SeedForm').css("z-index", "0");

        $('#SzrForm').css("opacity", "1");
        $('#SzrForm').css("z-index", "1");
    }

    //--------------
    $('.wholeList').click(function() { 
        $('.title h2').text("Просмотр продукции")

        $('.ChangingPrice').css("opacity", "0")
        $('.ChangingPrice').css("z-index", "-1")

        $('.ChangingDescription').css("opacity", "0")
        $('.ChangingDescription').css("z-index", "-1")


        $('.ChangingTitle').css("opacity","0")
        $('.ChangingTitle').css("z-index","-1")

        
        $('.CreateNewEntity').css("opacity", "0")
        $('.CreateNewEntity').css("z-index", "-1")
        
        $('.Main').css("opacity", "1")
        $('.Main').css("z-index", "5")
        
    });
    $('.New').click(function () { 
        $('.title h2').text("Добавление нового товара") 
        
        $('.ChangingPrice').css("opacity", "0")
        $('.ChangingPrice').css("z-index", "-1")

        $('.ChangingDescription').css("opacity", "0")
        $('.ChangingDescription').css("z-index", "-1")

        $('.ChangingTitle').css("opacity","0")
        $('.ChangingTitle').css("z-index","-1")
        
        $('.Main').css("opacity", "0")
        $('.Main').css("z-index", "-1")
        
        $('.CreateNewEntity').css("opacity", "1")
        $('.CreateNewEntity').css("z-index", "5")
        
    });
    $('.Name').click(function () { 
        $('.title h2').text("Изменение заголовка")  
        
        $('.ChangingPrice').css("opacity", "0")
        $('.ChangingPrice').css("z-index", "-1")

        $('.ChangingDescription').css("opacity", "0")
        $('.ChangingDescription').css("z-index", "-1")

        $('.CreateNewEntity').css("opacity","0")
        $('.CreateNewEntity').css("z-index","-1")
        
        $('.Main').css("opacity", "0")
        $('.Main').css("z-index", "-1")
        
        $('.ChangingTitle').css("opacity", "1")
        $('.ChangingTitle').css("z-index", "5")
    });
    $('.Price').click(function () { 
        $('.title h2').text("Изменение цены")  
        
        $('.CreateNewEntity').css("opacity", "0")
        $('.CreateNewEntity').css("z-index", "-1")

        $('.ChangingDescription').css("opacity", "0")
        $('.ChangingDescription').css("z-index", "-1")

        $('.ChangingTitle').css("opacity","0")
        $('.ChangingTitle').css("z-index","-1")
        
        $('.Main').css("opacity", "0")
        $('.Main').css("z-index", "-1")
        
        $('.ChangingPrice').css("opacity", "1")
        $('.ChangingPrice').css("z-index", "5")
    });
    $('.Description').click(function () { 
        $('.title h2').text("Изменение описания")

        $('.CreateNewEntity').css("opacity", "0")
        $('.CreateNewEntity').css("z-index", "-1")

        $('.ChangingPrice').css("opacity", "0")
        $('.ChangingPrice').css("z-index", "-1")

        $('.ChangingTitle').css("opacity","0")
        $('.ChangingTitle').css("z-index","-1")
        
        $('.Main').css("opacity", "0")
        $('.Main').css("z-index", "-1")
        
        $('.ChangingDescription').css("opacity", "1")
        $('.ChangingDescription').css("z-index", "5")

    });

    //rightSide


    $('.wholeList_rightSide').hover(function () {
            $(this).css("right", "0")
            
        }, function () {
            $(this).css("right", "-290px")
        }
    );

    //Changing in tables
    $('#Seed').click(() => ShowSeedTable());
    $('#Membrane').click(() => ShowMembraneTable());
    $('#Szr').click(() => ShowSzrTable());
    

   



    //switching forms

    $('.CreateNewEntity_select').change(function () { 
    var object = $(".CreateNewEntity_select option:selected").val();
    switch(object){
        case "Membrane":
            showMembraneForm();
            break;
        case "Seed":
            showSeedForm();
            break;
        case "Szr":
            showSzrForm();
        case "MembraneConfiguration":
            break;
    }
    });
})