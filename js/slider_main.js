
//Non-mobile
let bar_main = document.querySelector('.OneBar');
let bar_main2 = document.querySelector('.TwoBar');
//

let solution_slider = document.querySelector('.solutions_slider_unvisible');

//slides
let slide1 = document.querySelector('.list_slides_1');
let slide2 = document.querySelector('.list_slides_2')
//

solution_slider.style.left = 0;
solution_slider.style.transition = 'all .5s ease';

bar_main2.style.backgroundColor = '#d1d1d1';
bar_main2.style.transform = 'scale(1)';
bar_main.style.backgroundColor = '#f6ae2b';
bar_main.style.transform = 'scale(1.2)';

slide2.style.opacity = 0.4;

bar_main.addEventListener('click', function(){
    solution_slider.style.left = 0;
    solution_slider.style.transition = 'all .5s ease';

    bar_main2.style.backgroundColor = '#d1d1d1';
    bar_main2.style.transform = 'scale(1)';

    bar_main.style.backgroundColor = '#f6ae2b';
    bar_main.style.transform = 'scale(1.2)';

    slide1.style.opacity = 1;
    slide2.style.opacity = 0.4;
})
bar_main2.addEventListener('click', function(){

    bar_main.style.backgroundColor = '#d1d1d1';
    bar_main.style.transform = 'scale(1)';

    bar_main2.style.cursor = 'pointer';
    bar_main2.style.backgroundColor = '#f6ae2b';
    bar_main2.style.transform = 'scale(1.2)';    

    solution_slider.style.left = -1200 + 'px';
    solution_slider.style.transition = 'all .5s ease';

    slide1.style.opacity = 0.4;
    slide2.style.opacity = 1;
    
    
})