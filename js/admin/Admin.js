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
        $('.Main h3').text("Семена подсолнечника")
        $('#membraneTable').css("opacity", "0");
        $('#membraneTable').css("z-index", "1");

        $('#SzrTable').css("opacity", "0");
        $('#SzrTable').css("z-index", "1");

        $('#SpringSeedTable').css("opacity", "0");
        $('#SpringSeedTable').css("z-index", "1");

        $('#sunflowerTable').css("opacity", "1");
        $('#sunflowerTable').css("z-index", "5");

    }


    function ShowMembraneTable(){
        $('.Main h3').text("Пленка")
        $('#sunflowerTable').css("opacity", "0");
        $('#sunflowerTable').css("z-index", "1");

        $('#SzrTable').css("opacity", "0");
        $('#SzrTable').css("z-index", "1");

        $('#SpringSeedTable').css("opacity", "0");
        $('#SpringSeedTable').css("z-index", "1");

        $('#membraneTable').css("opacity", "1");
        $('#membraneTable').css("z-index", "5");

    }
    function ShowSzrTable(){
        $('.Main h3').text("СЗР")
        $('#sunflowerTable').css("opacity", "0");
        $('#sunflowerTable').css("z-index", "1");

        $('#membraneTable').css("opacity", "0");
        $('#membraneTable').css("z-index", "1");

        $('#SpringSeedTable').css("opacity", "0");
        $('#SpringSeedTable').css("z-index", "1");

        $('#SzrTable').css("opacity", "1");
        $('#SzrTable').css("z-index", "5");

    }
    function ShowSpringSeedTable(){
        $('.Main h3').text("Яровые семена")
        $('#sunflowerTable').css("opacity", "0");
        $('#sunflowerTable').css("z-index", "1");

        $('#membraneTable').css("opacity", "0");
        $('#membraneTable').css("z-index", "1");

        $('#SzrTable').css("opacity", "0");
        $('#SzrTable').css("z-index", "1");

        $('#SpringSeedTable').css("opacity", "1");
        $('#SpringSeedTable').css("z-index", "5");
    }
 
    //---------------------------
    function showMembraneForm(){
        $('#SunflowerForm').css("opacity", "0");
        $('#SunflowerForm').css("z-index", "0");

        $('#SpringSeedForm').css("opacity", "0");
        $('#SpringSeedForm').css("z-index", "0");

        $('#SzrForm').css("opacity", "0");
        $('#SzrForm').css("z-index", "0");


        $('#MembraneForm').css("opacity", "1");
        $('#MembraneForm').css("z-index", "1");
        
    }
    function showSunflowerForm(){
        $('#MembraneForm').css("opacity", "0");
        $('#MembraneForm').css("z-index", "0");

        $('#SpringSeedForm').css("opacity", "0");
        $('#SpringSeedForm').css("z-index", "0");

        $('#SzrForm').css("opacity", "0");
        $('#SzrForm').css("z-index", "0");

        $('#SunflowerForm').css("opacity", "1");
        $('#SunflowerForm').css("z-index", "1");
        
    }
    function showSzrForm(){
        $('#MembraneForm').css("opacity", "0");
        $('#MembraneForm').css("z-index", "0");

        $('#SpringSeedForm').css("opacity", "0");
        $('#SpringSeedForm').css("z-index", "0");

        $('#SunflowerForm').css("opacity", "0");
        $('#SunflowerForm').css("z-index", "0");

        $('#SzrForm').css("opacity", "1");
        $('#SzrForm').css("z-index", "1");
    }

    function showSpringSeedForm(){
        $('#MembraneForm').css("opacity", "0");
        $('#MembraneForm').css("z-index", "0");

        $('#SzrForm').css("opacity", "0");
        $('#SzrForm').css("z-index", "0");

        $('#SunflowerForm').css("opacity", "0");
        $('#SunflowerForm').css("z-index", "0");

        $('#SpringSeedForm').css("opacity", "1");
        $('#SpringSeedForm').css("z-index", "1");
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
    $('#SpringSeed').click(() => ShowSpringSeedTable());
    

   



    //switching forms

    $('.CreateNewEntity_select').change(function () { 
    var object = $(".CreateNewEntity_select option:selected").val();
    switch(object){
        case "Membrane":
            showMembraneForm();
            break;
        case "Sunflower":
            showSunflowerForm();
            break;
        case "Szr":
            showSzrForm();
            break;
        case "SpringSeed":
            showSpringSeedForm();
            break;
        case "MembraneConfiguration":
            break;
    }
    });
})