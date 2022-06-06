

let solution_slider_mob = document.querySelector('.solutions_slider_unvisible');

//slides
let slide2_mob = document.querySelector('.list_slides_2')
let slide1_mob = document.querySelector('.list_slides_1');
//
//list
let list1 = document.querySelector('#sl1');

let list2 = document.querySelector('#sl2');

let list3 = document.querySelector('#sl3');

let list4 = document.querySelector('#sl4');

let list5 = document.querySelector('#sl5');

let list6 = document.querySelector('#sl6');


//

//Moblie arrows
let arrow1 = document.querySelector('.arrow1');
let arrow2 = document.querySelector('.arrow2');
//

const amountOfSlides = 6;

let offset = 0;

let count = 1;

arrow2.addEventListener('click', function(){
    console.log('Yes')
    offset += 408;
    count++;
    solution_slider_mob.style.left = -offset +'px';
    if(count == amountOfSlides){
        offset = -410;
        count = 1;
    }
    
    


})


arrow1.addEventListener('click', function(){
    offset -= 408;
    count--;
    solution_slider_mob.style.left = -offset +'px';
    if(count == 0){
        offset = 2030;
        solution_slider_mob.style.left = -offset +'px';
        count = 6;
    }

})



