const nameInput = document.getElementById("exampleInputEmail1");
const descInput = document.getElementById("floatingTextarea2");
const form = document.querySelector("form");
const cardsContainer = document.querySelector(".cards-container");


form.addEventListener("submit", async function (e) {
  e.preventDefault();

  const newCategory = {
    name: nameInput.value,
    description: descInput.value,
  };

  try {
    const res = await axios.post("https://northwind.vercel.app/api/categories", newCategory);

  
    const created = res.data;

   
    createCard(created);

 
    nameInput.value = "";
    descInput.value = "";

    console.log("Category created", created);
  } catch (error) {
    console.error("Error:", error);
  }
});







async function getCategories() {
  try {
    const res = await fetch("https://northwind.vercel.app/api/categories");
  const data = await res.json();
    console.log(data);
    createCard(data);
  } catch (error) {
    console.error(error);
  }
}

getCategories();



function createCard(data){
  let cardsContainer=document.querySelector(".cards-container");
  data.forEach(cardData=>{
  let card=document.createElement("div");
    card.classList.add(cardData.id);
   let cardElement=`
   <div class="card" style="width: 18rem;">
   <div class="card-body">
       <h5 class="card-title">${cardData.name}</h5>
       <p class="card-text">${cardData.description}</p>
       <div style="display:flex; justify-content:center; gap:10px;">
       <button onClick="deleteCategory(${cardData.id}, this.parentElement.parentElement.parentElement)" class="btn btn-primary bg-danger border">Delete</button>
       <button class="btn btn-primary">Detail</button>
   </div>
   </div>
</div>`
   
    card.innerHTML+=cardElement;
    cardsContainer.appendChild(card);
  })


}




async function deleteCategory(id, cardElement) {
  try {
    const res = await fetch(`https://northwind.vercel.app/api/categories/${id}`, {
      method: "DELETE",
    });

    if (res.ok) {
      console.log(`${id} card deleted `);
        cardElement.remove(); 
    } else {
      console.log("error");
    }
  } catch (error) {
    console.error("Error:", error);
  }
}