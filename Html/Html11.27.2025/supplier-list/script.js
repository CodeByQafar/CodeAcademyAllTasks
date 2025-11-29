

async function loadSuppliers() {
    try {
        let response = await fetch('https://northwind.vercel.app/api/suppliers');
        let data = await response.json()
      
        craateTabels(data)
    }
    catch (err) {
// let alert=document.
    }
}

function loadingStatusChange() {
let loading=document.getElementsByClassName(".loading");
loading.style.display = 'none';

}
function craateTabels(data) {
   
    let table = document.getElementById("suppliers-table")
    data.forEach(tableData => {
        const tr = document.createElement("tr")
        tr.innerHTML += `
            <td>${s.id ?? ''}</td>
            <td>${s.companyName ?? ''}</td>
            <td>${s.contactName ?? ''}</td>
            <td>${s.contactTitle ?? ''}</td>
            <td>${addr.street ?? ''}</td>
            <td>${addr.city ?? ''}</td>
            <td>${addr.region ?? ''}</td>
            <td>${addr.postalCode ?? ''}</td>
            <td>${addr.country ?? ''}</td>
            <td>${addr.phone ?? ''}</td>
          `;
        table.appendChild(tr)
    })
      loadingStatusChange();
}


loadSuppliers()

async function loadSuppdsdasliers() {
    try {
        const resp = await fetch('https://northwind.vercel.app/api/suppliers');
        const data = await resp.json();
        const tbody = document.querySelector('#suppliers-table tbody');
        tbody.innerHTML = '';
        data.forEach(s => {
            const addr = s.address || {};
            const tr = document.createElement('tr');
            tr.innerHTML = `
            <td>${s.id ?? ''}</td>
            <td>${s.companyName ?? ''}</td>
            <td>${s.contactName ?? ''}</td>
            <td>${s.contactTitle ?? ''}</td>
            <td>${addr.street ?? ''}</td>
            <td>${addr.city ?? ''}</td>
            <td>${addr.region ?? ''}</td>
            <td>${addr.postalCode ?? ''}</td>
            <td>${addr.country ?? ''}</td>
            <td>${addr.phone ?? ''}</td>
          `;
            tbody.appendChild(tr);
        });
    } catch (err) {
        console.error('Məlumat yüklənmədi:', err);
    }
}


//window.addEventListener('DOMContentLoaded', loadSuppliers);