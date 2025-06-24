window.carouselInterop = {
    initCarousel: (carouselId, dotNetHelper) => {
        // Espera a que el DOM esté listo
        document.addEventListener('DOMContentLoaded', function () {
            var carouselElement = document.getElementById(carouselId);

            if (!carouselElement) {
                console.warn(`El carrusel con ID ${carouselId} no se encuentra en el DOM.`);
                return;
            }

            // Muestra la primera diapositiva por defecto
            dotNetHelper.invokeMethodAsync('OnCarouselSlideChange', 0);

            // Agrega el event listener si el elemento existe
            carouselElement.addEventListener('slide.bs.carousel', function (event) {
                dotNetHelper.invokeMethodAsync('OnCarouselSlideChange', event.to);
            });
        });
    }
};



///Colaborador_Servicio_Carrucel
let posicion = 0;

function MoverIzquierda() {
    const carrusel = document.querySelector('.carrusel-items');
    const widthItem = document.querySelector('.columna1-fila2-cont3-img1').offsetWidth;
    posicion += widthItem;
    carrusel.style.transform = `translateX(${posicion}px)`;
}

function MoverDerecha() {
    const carrusel = document.querySelector('.carrusel-items');
    const widthItem = document.querySelector('.columna1-fila2-cont3-img1').offsetWidth;
    posicion -= widthItem;
    carrusel.style.transform = `translateX(${posicion}px)`;
}





const carruselItems = document.querySelectorAll('.columna1-fila2-cont3-img1');
const imagePlaceholder = "/Images/Fondos/ImagenVacia.jpg"; // Imagen predeterminada
const numItems = carruselItems.length;

function actualizarImagenes() {
    carruselItems.forEach((item, index) => {
        const img = item.querySelector('img');

        // Si no hay una URL válida, aplica la imagen predeterminada
        if (!img.src || img.src.includes('base64') || img.src.endsWith('/')) {
            img.src = imagePlaceholder;
        }

        // Aplica la clase 'active' a la imagen del centro y desactiva las demás
        if (index === Math.floor(numItems / 2)) {
            item.classList.add('active');
            item.style.opacity = "1"; // Imagen central sin desvanecer
        } else {
            item.classList.remove('active');
            item.style.opacity = "0.5"; // Desvanecer las imágenes laterales
        }
    });
} ems = carruselItems.length;