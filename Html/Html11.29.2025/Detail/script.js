let id = window.location.search.split("=")[1];

async function getCardData() {
    console.log(id);
    try {
        const res = await fetch(`https://northwind.vercel.app/api/categories/${id}`);
        const data = await res.json();
        console.log(data);
        createCard(data);
    } catch (error) {
        console.error(error);
    }
}

getCardData();



function createCard(cardData) {

    let card = document.createElement("div");
    card.classList.add(cardData.id);
    let cardElement = `
   <div class="card" style="width: 18rem;">
   <div class="card-body">
       <h5 class="card-title ">${cardData.name}</h5>
       <p class="card-text">${cardData.description}</p>
       <div style="display:flex; justify-content:center; ">
       <button  class="btn btn-primary"><a href="../Home/index.html">Back</a></button>
       
   </div>
   </div>
</div>`

    card.innerHTML += cardElement;
    document.body.appendChild(card);

if(cardData.name==null || cardData.description==null){
    const alertElement = document.querySelector(".alert");
    alertElement.style.visibility = "visible";
}

}

