let id = window.location.search.split('=')[1]


async function loadSupplier() {
    try {
        const response = await axios.get(`https://northwind.vercel.app/api/suppliers/${id}`)
        createElement(response.data)
        loadingStatusChange(true)
    } catch (error) {
        loadingStatusChange(false)
        console.log(`Error: ${error}`)
    }

}

function loadingStatusChange(isSuccses) {
    console.log()
    let loading = document.getElementById("loading");
    loading.style.display = 'none';
    if (isSuccses) {
        let detailSection = document.getElementById("detail");
        detailSection.style.display = 'flex';
    }
    else {
        let errorCard = document.getElementById("error-card");
        errorCard.style.display = "flex";
    }


}

function createElement(data) {
    let detailSection=document.getElementById("detail")
    detailSection.innerHTML+=`
     <div class="detail-box">
      <h1>${data.companyName}</h1>
      <p><b>Contact Title:</b> ${data.contactTitle}</p>
      <p><b>Country:</b> ${data.address.country}</p>
      <p><b>Street:</b> ${data.address.street}</p>
      <p><b>Phone:</b> ${data.address.phone}</p>
      <p><b>Postal Code:</b> ${data.address.postalCode}</p>
      <button class="back-button"><a href="../supplier-list/index.html">Back</a></button>
    </div>
    `;

}
loadSupplier()
