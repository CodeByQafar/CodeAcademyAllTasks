

async function loadSuppliers() {
    try {
        let response = await fetch('https://northwind.vercel.app/api/suppliers')
        let data = await response.json()
        craateTabels(data)
        loadingStatusChange(true)
    }
    catch (error) {
        loadingStatusChange(false)
        console.log(`Error: ${error}`)
    }
}

function loadingStatusChange(isSuccses) {
    console.log()
    let loading = document.getElementById("loading");
    loading.style.display = 'none';
    if (isSuccses) {
        let tabel = document.getElementById("table");
        tabel.style.display = 'flex';
    }
    else {
        let errorCard = document.getElementById("error-card");
        errorCard.style.display = "flex";
    }


}
function craateTabels(data) {

    let table = document.querySelector("#suppliers-table tbody")
    data.forEach(tableData => {
        const tr = document.createElement("tr")
        tr.innerHTML = `
            <td>${tableData.id ?? ''}</td>
            <td>${tableData.companyName ?? ''}</td>
            <td>${tableData.address.postalCode ?? ''}</td>
            <td>${tableData.address.country ?? ''}</td>
            <td>${tableData.address.phone ?? ''}</td>
            <td><a class="detail" href="../detail/index.html?id=${tableData.id}">Detail</a></td>
            <td><button data-id="${tableData.id}" class="delete">Delete</button></td>
          `;

        table.appendChild(tr)
    })
    
    document.querySelector("#suppliers-table tbody")
        .addEventListener("click", async (e) => {
            if (e.target.classList.contains("delete")) {
                let id = e.target.getAttribute("data-id");
                await deleteSuppliers(id);
               e.target.parentElement.parentElement.remove()
            }

        });

}





async function deleteSuppliers(id) {


    try {

        let response = await fetch(`https://northwind.vercel.app/api/suppliers/${id}`, {
            method: "DELETE",
        });
        if (response.ok) {
            console.log("supplier deleted")

        } else {
            console.log("supplier not deleted")
        }
    }
    catch (error) {
        console.log(`Error: ${error}`)
    }
}
// <td>${tableData.id ?? ''}</td>
// <td>${tableData.companyName ?? ''}</td>
// <td>${tableData.contactName ?? ''}</td>
// <td>${tableData.contactTitle ?? ''}</td>
// <td>${tableData.address.street ?? ''}</td>
// <td>${tableData.address.city ?? ''}</td>
// <td>${tableData.address.region ?? ''}</td>
// <td>${tableData.address.postalCode ?? ''}</td>
// <td>${tableData.address.country ?? ''}</td>
// <td>${tableData.address.phone ?? ''}</td>
// <td>${tableData.address.phone ?? ''}</td>


window.addEventListener('DOMContentLoaded', loadSuppliers);