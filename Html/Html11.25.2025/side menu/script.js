let btn = document.querySelector("button")
let close = document.querySelector(".close")
btn.onclick=function(){
    let menu = document.querySelector(".nav")
    menu.classList.add("display")

}

close.onclick=function(){
    let menu = document.querySelector(".nav")
    menu.classList.remove("display")

}