document.addEventListener("DOMContentLoaded", function() {
    console.log("Portfolio carregado com sucesso!");

    const contactForm = document.getElementById('contactForm');
    if (contactForm) {
        contactForm.addEventListener('submit', function(event) {
            event.preventDefault();
            alert('Obrigado pelo seu contato! A sua mensagem foi enviada com sucesso.');
            contactForm.requestFullscreen();
        });
    }
});