// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function setActiveMenu() {
    const currentUrl = window.location.pathname;
    const navLinks = document.querySelectorAll('.navbar-nav .nav-link');

    navLinks.forEach(link => {
        let linkUrl = link.getAttribute('href');
        if (linkUrl && linkUrl !== '/') {
            linkUrl = linkUrl.replace(/\/$/, '');
        }

        let cleanCurrentUrl = currentUrl.replace(/\/$/, '');

        if (cleanCurrentUrl === linkUrl ||
            (cleanCurrentUrl === '' && linkUrl === '/') ||
            (cleanCurrentUrl.startsWith(linkUrl) && linkUrl !== '/')) {

            link.classList.add('active');
            link.closest('.nav-item').classList.add('active');
        }
    });
}

// Initialize when document is ready
document.addEventListener('DOMContentLoaded', setActiveMenu);