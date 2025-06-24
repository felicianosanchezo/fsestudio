




window.carouselInterop = {
    initCarousel: (carouselId, dotNetHelper) => {
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
    }
};

let isProcessing = false;  // Aseguramos que isProcessing esté bien inicializada







function abrirSelectorDeArchivo(id) {
    // Verificar si ya hay un proceso en curso
    if (isProcessing) {
        console.warn("Ya se está procesando la selección de archivo. Espera a que termine.");
        return;
    }

    isProcessing = true;  // Bloquear nuevas ejecuciones mientras se procesa

    // Obtener el elemento input de tipo file por su id
    var fileInput = document.getElementById(id);

    // Verificar si el elemento existe
    if (fileInput) {
        console.log(`Disparando clic en el elemento con id: ${id}`);
        fileInput.click();  // Disparar el evento click
    } else {
        console.warn(`El elemento con el id '${id}' no fue encontrado.`);
        isProcessing = false;  // Liberar si no se encuentra el input
        return;
    }

    // Esperar el cambio en el input y luego liberar la bandera
    fileInput.addEventListener('change', function () {
        console.log(`Evento 'change' disparado en el input con id: ${id}`);

        if (fileInput.files.length > 0) {
            console.log(`Archivo seleccionado: ${fileInput.files[0].name}, tamaño: ${fileInput.files[0].size} bytes`);
        } else {
            console.warn("No se seleccionó ningún archivo.");
        }

        isProcessing = false;  // Liberamos la bandera cuando se selecciona un archivo
    }, { once: true });  // Asegurar que solo escuche el evento una vez





}






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
}


function scrollToElement(elementId) {
    const element = document.getElementById(elementId);
    if (element) {
        element.scrollIntoView({
            behavior: 'smooth',  // Desplazamiento suave
            block: 'center',     // Alinea el elemento en el centro vertical del viewport
            inline: 'center'     // Alinea en el centro horizontal si es necesario (en caso de desbordamiento horizontal)
        });
    }
}




window.confirmPayment = async function (stripeInstance, clientSecret) {
    const { error } = await stripeInstance.stripe.confirmCardPayment(clientSecret, {
        payment_method: {
            card: stripeInstance.cardElement,
            billing_details: {
                name: 'Nombre del Cliente',
            },
        }
    });

    if (error) {
        console.error("Error en el pago:", error.message);
        return false;
    }
    return true;
};


window.setupStripe = function (clientSecret) {
    if (!window.setupStripeInstance) {
        const stripe = Stripe("pk_test_51QEgASFmj6waeRy3oa2Um2fHllzek6Qmdbso6hjUVCyxbPKZQeeQc9LdP4AWU7g3Oo7yznOeYoMuPfQdC2KNcL7b00nNGXutez");
        const elements = stripe.elements();
        const card = elements.create("card");

        // Monta el elemento de tarjeta en el contenedor con el id 'card-element'
        card.mount("#card-element");

        // Guarda la instancia de Stripe y el elemento de tarjeta
        window.setupStripeInstance = {
            stripe: stripe,
            card: card,
            confirmCardPayment: async function () {
                const result = await stripe.confirmCardPayment(clientSecret, {
                    payment_method: {
                        card: card,
                        billing_details: {
                            name: document.getElementById("cardholder-name").value,
                        },
                    },
                });

                if (result.error) {
                    console.error("Error al confirmar el pago:", result.error.message);
                    return { success: false, error: result.error.message };
                } else {
                    if (result.paymentIntent.status === "succeeded") {
                        console.log("Pago completado con éxito!");
                        return { success: true };
                    }
                }
            }
        };
    }
};



window.getClientIp = async function () {
    const response = await fetch("https://api.ipify.org?format=json");
    const data = await response.json();
    return data.ip;
};




window.getBrowserInfo = function () {
    const userAgent = navigator.userAgent;
    let browserName = "Desconocido";
    let version = "N/A";

    if (userAgent.indexOf("Chrome") > -1) {
        browserName = "Chrome";
        version = userAgent.match(/Chrome\/(\d+)/)[1];
    } else if (userAgent.indexOf("Firefox") > -1) {
        browserName = "Firefox";
        version = userAgent.match(/Firefox\/(\d+)/)[1];
    } else if (userAgent.indexOf("Safari") > -1) {
        browserName = "Safari";
        version = userAgent.match(/Version\/(\d+)/)[1];
    } else if (userAgent.indexOf("MSIE") > -1 || userAgent.indexOf("Trident/") > -1) {
        browserName = "Internet Explorer";
        version = userAgent.match(/(MSIE |rv:)(\d+)/)[2];
    }

    return `${browserName} ${version}`;
};









window.isMobileDevice = function () {
    const userAgent = navigator.userAgent || navigator.vendor || window.opera;
    if (/android/i.test(userAgent)) {
        return "Android";
    }
    if (/iPad|iPhone|iPod/.test(userAgent) && !window.MSStream) {
        return "iOS";
    }
    if (/windows phone/i.test(userAgent)) {
        return "Windows Phone";
    }
    return "Desktop";
};










async function getLocationFromIp(ip) {
    const response = await fetch(`https://ipapi.co/${ip}/json/`);
    const data = await response.json();
    return data.city + ", " + data.region + ", " + data.country_name;
}


window.getReferrer = function () {
    return document.referrer || "Direct";
};






window.getUTMParameters = function () {
    const urlParams = new URLSearchParams(window.location.search);
    return {
        utm_source: urlParams.get('utm_source') || '',
        utm_medium: urlParams.get('utm_medium') || '',
        utm_campaign: urlParams.get('utm_campaign') || '',
        utm_term: urlParams.get('utm_term') || '',
        utm_content: urlParams.get('utm_content') || ''
    };
};
function ajustarAlturaTextArea(textArea) {
    textArea.style.height = 'auto'; // Reinicia la altura
    textArea.style.height = `${textArea.scrollHeight}px`; // Ajusta según el contenido
}



function scrollToTop() {
    window.scrollTo({
        top: 0,
        behavior: 'smooth' // Agrega un desplazamiento suave
    });
}


function abrirEnNuevaPestana(url) {
    window.open(url, '_blank');
}


function copyToClipboard() {
    const couponText = document.getElementById('coupon-text').textContent;
    navigator.clipboard.writeText(couponText).then(() => {
        alert('¡Cupón copiado al portapapeles!');
    }).catch(err => {
        console.error('Error al copiar:', err);
    });
}

window.loadOBJModel = function (containerId, objPath, mtlPath, dotNetObject) {
    const container = document.getElementById(containerId);

    if (!container) {
        console.error("El contenedor no existe:", containerId);
        return;
    }

    // Configuración básica de Three.js
    const scene = new THREE.Scene();
    const camera = new THREE.PerspectiveCamera(75, container.clientWidth / container.clientHeight, 0.1, 1000);
    const renderer = new THREE.WebGLRenderer({ antialias: true });
    renderer.setSize(container.clientWidth, container.clientHeight);
    renderer.setClearColor(0x283C4F); // Fondo blanco muy clarito
    renderer.shadowMap.enabled = true; // Habilitar sombras
    renderer.shadowMap.type = THREE.PCFSoftShadowMap; // Sombras suaves
    container.appendChild(renderer.domElement);

    // Luz ambiental
    const ambientLight = new THREE.AmbientLight(0xffffff, 0.8);
    scene.add(ambientLight);

    // Luz direccional con sombras
    const directionalLight = new THREE.DirectionalLight(0xffffff, 1);
    directionalLight.position.set(10, 10, 10);
    directionalLight.castShadow = true;
    scene.add(directionalLight);

    // Configurar OrbitControls
    const controls = new THREE.OrbitControls(camera, renderer.domElement);
    controls.target.set(0, 0, 0);
    controls.update();

    function centerObject(object) {
        const box = new THREE.Box3().setFromObject(object);
        const center = box.getCenter(new THREE.Vector3());
        object.position.sub(center); // Restar centro para centrar el objeto
        object.position.y += (box.max.y - box.min.y) / 2; // Ajustar altura
    }

    function onModelLoaded() {
        dotNetObject.invokeMethodAsync('OnModelLoaded');
    }

    // Cargar materiales (si existe un archivo .mtl)
    if (mtlPath) {
        const mtlLoader = new THREE.MTLLoader();
        mtlLoader.load(
            mtlPath,
            (materials) => {
                materials.preload();
                const objLoader = new THREE.OBJLoader();
                objLoader.setMaterials(materials);
                objLoader.load(
                    objPath,
                    (object) => {
                        object.traverse((child) => {
                            if (child.isMesh) {
                                child.castShadow = true;
                                child.receiveShadow = true;
                            }
                        });
                        object.rotation.x = -Math.PI / 2;
                        object.scale.set(0.45, 0.45, 0.45);
                        centerObject(object); // Centrar el objeto
                        scene.add(object);
                        animate();
                        onModelLoaded();
                    }
                );
            }
        );
    } else {
        // Cargar OBJ sin materiales
        const objLoader = new THREE.OBJLoader();
        objLoader.load(
            objPath,
            (object) => {
                object.traverse((child) => {
                    if (child.isMesh) {
                        child.castShadow = true;
                        child.receiveShadow = true;
                    }
                });
                object.rotation.x = -Math.PI / 2;
                object.scale.set(0.4, 0.4, 0.4);
                centerObject(object); // Centrar el objeto
                scene.add(object);
                animate();
                onModelLoaded();
            }
        );
    }

    camera.position.set(0, 2, 10);

    // *** Modificación: Listener de redimensionamiento ***
    window.addEventListener("resize", () => {
        const container = document.getElementById("modelo3d");
        if (container) {
            const width = container.clientWidth;
            const height = container.clientHeight;

            // Actualiza el tamaño del renderizador
            renderer.setSize(width, height);

            // Ajusta la relación de aspecto de la cámara
            camera.aspect = width / height;
            camera.updateProjectionMatrix();
        }
    });
    // *** Fin de la modificación ***

    function animate() {
        requestAnimationFrame(animate);
        renderer.render(scene, camera);
    }
};

window.renderModeloDesdeAPI = function (containerId, elementos) {
    const container = document.getElementById(containerId);
    if (!container) {
        console.error("No se encontró el contenedor:", containerId);
        return;
    }

    // Limpiar el contenedor antes de renderizar
    container.innerHTML = "";

    // Configuración básica de Three.js
    const scene = new THREE.Scene();
    scene.background = new THREE.Color(0x283C4F); // Azul oscuro

    const camera = new THREE.PerspectiveCamera(50, container.clientWidth / container.clientHeight, 0.1, 1000);
    const renderer = new THREE.WebGLRenderer({ antialias: true });
    renderer.setSize(container.clientWidth, container.clientHeight);
    renderer.shadowMap.enabled = true;
    container.appendChild(renderer.domElement);

    // ?? Luces realistas
    const ambientLight = new THREE.AmbientLight(0xffffff, 0.6);
    scene.add(ambientLight);

    const directionalLight = new THREE.DirectionalLight(0xffffff, 1);
    directionalLight.position.set(15, 20, 10);
    directionalLight.castShadow = true;
    directionalLight.shadow.mapSize.width = 2048;
    directionalLight.shadow.mapSize.height = 2048;
    scene.add(directionalLight);

    // ?? Plano base (suelo)
    const planeGeometry = new THREE.PlaneGeometry(200, 200);
    const planeMaterial = new THREE.ShadowMaterial({ opacity: 0.2 });
    const plane = new THREE.Mesh(planeGeometry, planeMaterial);
    plane.rotation.x = -Math.PI / 2;
    plane.receiveShadow = true;
    scene.add(plane);

    // ?? Controles de cámara
    const controls = new THREE.OrbitControls(camera, renderer.domElement);
    controls.enableDamping = true;
    controls.dampingFactor = 0.05;
    controls.screenSpacePanning = false;
    controls.maxPolarAngle = Math.PI / 2;

    // ?? Crear la geometría desde la API
    const geometry = new THREE.BufferGeometry();
    const vertices = [];
    const indices = [];

    elementos.forEach((elemento) => {
        elemento.caras.forEach((cara) => {
            const idx = vertices.length / 3;
            vertices.push(cara.x1, cara.y1, cara.z1);
            vertices.push(cara.x2, cara.y2, cara.z2);
            vertices.push(cara.x3, cara.y3, cara.z3);
            indices.push(idx, idx + 1, idx + 2);
        });
    });

    geometry.setAttribute('position', new THREE.Float32BufferAttribute(vertices, 3));
    geometry.setIndex(indices);
    geometry.computeVertexNormals(); // Suaviza las caras del modelo

    // ?? Asignar materiales diferentes a paredes, ventanas y piso
    const materialMuros = new THREE.MeshStandardMaterial({ color: 0xffffff, metalness: 0.1, roughness: 0.8 });
    const materialVentanas = new THREE.MeshStandardMaterial({ color: 0x89CFF0, transparent: true, opacity: 0.5 });
    const materialPiso = new THREE.MeshStandardMaterial({ color: 0x8B5A2B, metalness: 0.2, roughness: 0.9 });

    // ?? Detectar y asignar materiales según la categoría
    const grupo = new THREE.Group();
    elementos.forEach((elemento) => {
        const material = elemento.categoria.includes("Ventana") ? materialVentanas :
            elemento.categoria.includes("Piso") ? materialPiso :
                materialMuros;
        const mesh = new THREE.Mesh(geometry, material);
        mesh.castShadow = true;
        mesh.receiveShadow = true;
        grupo.add(mesh);
    });

    // ?? Centrar el modelo
    function centerObject(object) {
        const box = new THREE.Box3().setFromObject(object);
        const center = box.getCenter(new THREE.Vector3());
        object.position.sub(center); // Centrar en el origen
        object.position.y += (box.max.y - box.min.y) / 2; // Ajustar altura
    }

    grupo.rotation.x = -Math.PI / 2; // Corregir la orientación
    centerObject(grupo);
    scene.add(grupo);

    // ?? Ajustar la cámara para una mejor perspectiva
    camera.position.set(20, 30, 20);
    controls.update();

    function animate() {
        requestAnimationFrame(animate);
        controls.update();
        renderer.render(scene, camera);
    }
    animate();

    // ?? Ajustar el tamaño al cambiar la ventana
    window.addEventListener("resize", () => {
        const width = container.clientWidth;
        const height = container.clientHeight;
        renderer.setSize(width, height);
        camera.aspect = width / height;
        camera.updateProjectionMatrix();
    });
};




window.scrollIntoViewIfNeeded = (element) => {
    if (element) {
        element.scrollIntoView({ behavior: "smooth", block: "center", inline: "center" });
    }
};