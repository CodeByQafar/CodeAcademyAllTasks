let data=[{
    "id": 4,
    "companyName": "Tokyo Traders",
    "contactName": "Yoshi Nagase",
    "contactTitle": "Marketing Manager",
  },
  {
    "id": 5,
    "companyName": "Cooperativa de Quesos 'Las Cabras'",
    "contactName": "Antonio del Valle Saavedra",
    "contactTitle": "Export Administrator",
  },
  {
    "id": 6,
    "companyName": "Mayumi's",
    "contactName": "Mayumi Ohno",
    "contactTitle": "Marketing Representative",
   
  },
  {
    "id": 7,
    "companyName": "Pavlova Ltd.",
    "contactName": "Ian Devling",
    "contactTitle": "Marketing Manager",

  },
  {
    "id": 8,
    "companyName": "Specialty Biscuits Ltd.",
    "contactName": "Peter Wilson",
    "contactTitle": "Sales Representative",
 
  },
  {
    "id": 9,
    "companyName": "PB Knäckebröd AB",
    "contactName": "Lars Peterson",
    "contactTitle": "Sales Agent",
 
  },
  {
    "id": 10,
    "companyName": "Refrescos Americanas LTDA",
    "contactName": "Carlos Diaz",
    "contactTitle": "Marketing Manager",
  }]



  data.forEach(data=>{
   
   let card=`
   <div class="card" style="width: 18rem;">
   <div class="card-body">
       <h5 class="card-title">${data.companyName}</h5>
       <p class="card-text">${data.contactName}</p>
       <a href="#" class="btn btn-primary">${data.contactTitle}</a>
   </div>
</div>`
   
    document.body.innerHTML+=card;
  })

