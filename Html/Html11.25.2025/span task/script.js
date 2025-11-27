let incress = document.querySelector(".Increses")
let Decrese = document.querySelector(".Decrese")
let Reset = document.querySelector(".Reset")
let box = document.querySelector(".box")

let width = 200;


incress.onclick = function () {
    width += 10;
    box.style.width = width + "px";
    console.log(box.style.width)
}; 
Decrese.onclick = function () {
    width -= 10;
    box.style.width = width + "px";
    console.log(box.style.width)
};
 Reset.onclick = function () {
    width = 200;
    box.style.width = width + "px";
    console.log(box.style.width)
};