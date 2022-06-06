
//ЗАДАЙ КЛАСС ТЭГУ a



//list of object TO change
let seeds = document.getElementsByClassName('seed');

let bio = document.getElementsByClassName('bio');

let technic = document.getElementsByClassName('technic');

let fertilizers = document.getElementsByClassName('fertilizers');

let sectionBurger = document.querySelector('.left_menu_burger');

let ul = document.querySelector('.ul');

//list of object FOR change

let title = document.querySelector('.script_title_above');

let El = document.getElementsByClassName('EL');



const lengthOfStandart = 2;
const MaxLength = 8;
//counter
let counterSeed = 0;
let counterBio = 0;
let counterTech = 0;
let counterFert = 0;

// imagesTrigger
let seedTrigger = document.querySelector('.seed_');
let bioTrigger = document.querySelector('.bio_');
let technicTrigger = document.querySelector('.technic_');
let fertilizerTrigger = document.querySelector('.fertilizer_');
//
let backButton = document.querySelector('.left_menu_burger_head');


//seed
seedTrigger.addEventListener('click', function(){
    title.innerHTML = "Семена";

    let seed = 0;

    for(let v = 0; v < seeds.length; v++){
        seed++;
    }


    
    for(let i = 0; i <= 1; i++){
        let lastEl = document.querySelector('.El' + `${i}`);
        let seedEl = document.querySelector('.seed' + `${i}`).textContent;


        lastEl.innerHTML = seedEl;
    }
    if(seed > lengthOfStandart){
        for(let j = 2; j < fert; j++){
            
            let seedEl = document.querySelector('.seed' + `${j}`);
            let seedText = seedEl.textContent;

            let list = document.createElement('li');
            let ref = document.createElement('a');
            let attr = seedEl.getAttribute('href');
            let txt = document.createTextNode(seedText);

            ref.href = attr;

            ref.appendChild(txt);
            list.appendChild(ref);
            ul.appendChild(list);
        }
    }

    let lists = document.querySelectorAll('.EL');
    

    if(seed != lists.length){
      for(let r = lists.length - 1; r != seed - 1; r--){
        let li = lists[r]
        li.remove();
      }
    
    }

    sectionBurger.style.left = 0 + "%";
    sectionBurger.style.transition = "all .5s ease"; 
     
});

//bio
bioTrigger.addEventListener('click', function(){
    title.innerHTML = "Биоконсерванты";
    let bioCounter = 0;


    for(let v = 0; v < bio.length; v++){
        bioCounter++;
    }
    
    const amountOfBio = 2;


    for(let i = 0; i <= amountOfBio - 1; i++){
        let lastEl = document.querySelector('.El' + `${i}`);
        let bioEl = document.querySelector('.bio' + `${i}`).textContent;


        lastEl.innerHTML = bioEl;
    }



    if(bioCounter > lengthOfStandart){
        for(let j = 2; j < bioCounter; j++){
            
            let bioEl = document.querySelector('.bio' + `${j}`);
            let bioText = bioEl.textContent;

            let list = document.createElement('li');
            let ref = document.createElement('a');
            let attr = bioEl.getAttribute('href');
            let txt = document.createTextNode(bioText);

            ref.href = attr;

            list.className = "EL" + `${j}` + " " + "EL";

            ref.className = "El" + `${j}`;

            ref.appendChild(txt);
            list.appendChild(ref);
            ul.appendChild(list);
        }
    }

    let lists2 = document.querySelectorAll('.EL');
    

    if(bioCounter != lists2.length){
      for(let r = lists2.length - 1; r != bioCounter - 1; r--){
        let li = lists2[r];
        li.remove();
      }
    
    }




    sectionBurger.style.left = 0 + "%";
    sectionBurger.style.transition = "all .5s ease"; 
        

})


fertilizerTrigger.addEventListener('click', function(){
    title.innerHTML = "Удобрения";
    
    let fert = 0;


    //Counter of incoming elements
    let lists = document.querySelectorAll('.EL');

    console.log(lists);


    for(let v = 0; v < fertilizers.length; v++){
        fert++;
    }
    
    if(fert > lists.length){
        
        let forAnotherCycle = 0;

        for(let i = 0; i <= lists.length - 1; i++){
            let lastEl = document.querySelector('.El' + `${i}`);
            let fertEl = document.querySelector('.fertilizer' + `${i}`).textContent;


            lastEl.innerHTML = fertEl;

            forAnotherCycle++;
        }

        for(let j = forAnotherCycle ; j < fert; j++){
            
            let fertEl = document.querySelector('.fertilizer' + `${j}`);
            let fertText = fertEl.textContent;

            let list = document.createElement('li');
            let ref = document.createElement('a');
            let attr = fertEl.getAttribute('href');
            let txt = document.createTextNode(fertText);

            ref.className ="El" + `${j}`;
            ref.href = attr;

            ref.appendChild(txt);
            list.appendChild(ref);

            list.className = "EL" + `${j}` + " " + "EL";
            ref.className = "El" + `${j}`;

            ul.appendChild(list);
            }
        sectionBurger.style.left = 0 + "%";
        sectionBurger.style.transition = "all .5s ease";
        counterFert++; 
    }

    else{
    sectionBurger.style.left = 0 + "%";
    sectionBurger.style.transition = "all .5s ease";
    }
})



//backButton
backButton.addEventListener('click', function(){
    sectionBurger.style.left = 100 + "%";
    sectionBurger.style.transition = "all .5s ease"; 
} );






