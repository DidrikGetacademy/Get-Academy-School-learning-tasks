// app.js
// app.js
document.addEventListener("DOMContentLoaded", function () {
    console.log("DOM loaded successfully");

    // Resten av koden for å manipulere DOM-en
});


    // Hent referansen til body-elementet
    var body = document.body;

    // Opprett et nytt h2-element
    var heading = document.createElement("h2");

    // Sett teksten til overskriften
    heading.innerText = "Hello from frontend!";

    // Legg til overskriften i body
    body.appendChild(heading);
});
