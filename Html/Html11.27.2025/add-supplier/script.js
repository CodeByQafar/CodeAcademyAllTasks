

async function createSuppliers() {

    let data = getInputValues()
    try {
        let response = await axios.post("https://northwind.vercel.app/api/suppliers", data)
        clearInputs()
        alert("supplier created")

    } catch (error) {
        alert(error)
        console.log(error)
    }
}
function getInputValues() {
    const companyNameInput = document.getElementById("companyNameInput");
    const contactTitleInput = document.getElementById("contactTitleInput");
    const countryInput = document.getElementById("countryInput");
    const streetInput = document.getElementById("streetInput");
    const phoneInput = document.getElementById("phoneInput");
    const postalCodeInput = document.getElementById("postalCodeInput");


    let data = {
        "companyName": companyNameInput.value,
        "contactName": null,
        "contactTitle": contactTitleInput.value,
        "address": {
            "street": streetInput.value,
            "city": null,
            "region": null,
            "postalCode": postalCodeInput.value,
            "country": countryInput.value,
            "phone": phoneInput.value
        }
    }
    return data;
}
function clearInputs() {
    document.getElementById("companyNameInput").value = '';
    document.getElementById("contactTitleInput").value = '';
    document.getElementById("countryInput").value = '';
    document.getElementById("streetInput").value = '';
    document.getElementById("phoneInput").value = '';
    document.getElementById("postalCodeInput").value = '';
}

let form = document.getElementById('companyForm')

form.addEventListener('submit', async (e) => {
    e.preventDefault();
    createSuppliers()
})