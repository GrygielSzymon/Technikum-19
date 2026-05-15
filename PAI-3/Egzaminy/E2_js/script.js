const button = document.querySelector("#send");

button.addEventListener("click", function(){
    let name = document.querySelector("#name").value;
    let surname = document.querySelector("#surname").value;
    let email = document.querySelector("#email").value;
    let application = document.querySelector("#application").value;
    let show = document.querySelector("#show");
    let result = document.querySelector("#result");

    result.innerHTML = `${name} ${surname} <br> ${email} <br> Usługa: ${application}`;
})