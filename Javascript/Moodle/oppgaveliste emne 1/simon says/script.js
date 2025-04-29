//modell
let btnArray = ['red','yellow','blue','green']
let memoryArray = [];
let userArray = [];
let buttonBlink=['','','','']
let disableBtn = 'disabled';
let errorBlink= 'red';
let level = 0;
let high = 0;
let counter = 0;
let userIndex = 0;
let memoryArrayCounter = 0;

//view
show();
function show(){
let html = '';
let buttons='';


for(let i = 0; i < btnArray.length; i++){
   buttons += `
   <div class="${btnArray[i]} ${buttonBlink[i]} ${disableBtn}  shape" onclick="userSelect(${i})"></div>
   `;
}

html += `
<h1 class="cont">Simen sier:</h1>
<div class="stil">${buttons}</div>
<div class="cont">
<button onclick="startGame()">start</button><br>
<div>level: ${level}</div>
</div>
<div class="cont">Highscore:${high}</div>


`;
   
   document.getElementById("app").innerHTML = html;
}



//Controller
function newMemory(){
   var temp = Math.floor((Math.random() * btnArray.length));
   memoryArray.push(btnArray[temp])
   buttonBlink[temp]='blink';
   show();
   setTimeout(function () {
      buttonBlink[temp]='';
   },300)
}

function userSelect(index){
userArray.push(btnArray[index])
buttonBlink[index]='blink';
show()
setTimeout(function (){
   buttonBlink[index]='';
   show()
},100);
checkWinner()
}


function startGame(){
   if(counter == 0){
      setTimeout(newMemory, 400)
      counter++;
      disableBtn='';
   }
}

function checkWinner(){
if(memoryArray[userIndex] == userArray[userIndex]){
   userIndex++;
   if(memoryArray.length == userArray.length){
      level++;
      userArray = []
      userIndex = 0;
      setTimeout(newMemory, 400);
   }
} else {
   if(level > high){high = level}
   level = 0;
   memoryArray = [];
   userArray = [];
   userIndex = 0;
   disableBtn= 'disabled'
   document.querySelector('body').classList.add('wrong');
   setTimeout(function () {
      document.querySelector('body').classList.remove('wrong');
   },200);
   counter = 0;
}
}
