const hamburger = document.querySelector(".hamburger");
const navbarMenu = document.querySelector(".navbar-links");

hamburger.addEventListener("click", () => {
    hamburger.classList.toggle("active");
    navbarMenu.classList.toggle("active");
});