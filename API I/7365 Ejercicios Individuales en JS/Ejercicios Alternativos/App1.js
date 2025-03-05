//Ejercicio 1

function clasificarNota() {
    const notaInput = document.getElementById("nota");
    const nota = parseInt(notaInput.value);
    const resultadoElement = document.getElementById("resultadoNota");

    if (isNaN(nota)) {
        resultadoElement.innerHTML = "Resultado: <span style='color: red;'>Por favor, ingrese un número válido</span>";
        return;
    }

    if (nota < 0 || nota > 100) {
        resultadoElement.innerHTML = "Resultado: <span style='color: red;'>La nota debe estar entre 0 y 100</span>";
        return;
    }

    let categoria = "";
    let color = "";

    if (nota >= 95 && nota <= 100) {
        categoria = "Excelente";
        color = "#155724";
    } else if (nota >= 90 && nota <= 94) {
        categoria = "Muy Bien";
        color = "#004085";
    } else if (nota >= 80 && nota <= 89) {
        categoria = "Bien";
        color = "#856404";
    } else if (nota >= 60 && nota <= 79) {
        categoria = "Regular";
        color = "#856404";
    } else {
        categoria = "Insuficiente";
        color = "#721c24";
    }

    resultadoElement.innerHTML = `Resultado: <span style='color: ${color};'>${nota} - ${categoria}</span>`;
}

document.getElementById("nota").addEventListener("keypress", function(event) {
    if (event.key === "Enter") {
        clasificarNota();
    }
});

//Ejercicio 2


function mostrarAlertaError(mensaje) {
    Swal.fire({
        title: '¡Error!',
        text: mensaje,
        icon: 'error',
        confirmButtonText: 'Entendido',
        background: '#f8d7da',
        confirmButtonColor: '#d9534f',
        customClass: {
            popup: 'animate__animated animate__shake'
        }
    });
 }
 
 function calcularFaseVuelo() {
    const duracionEstableInput = document.getElementById("duracionEstable");
    const tiempoTranscurridoInput = document.getElementById("tiempoTranscurrido");
    const faseVueloElement = document.getElementById("faseVuelo");
    const duracionTotalElement = document.getElementById("duracionTotal");
 
    const duracionEstable = parseFloat(duracionEstableInput.value);
    const tiempoTranscurrido = parseFloat(tiempoTranscurridoInput.value);
 
    // Validaciones con SweetAlert2
    if (isNaN(duracionEstable) || isNaN(tiempoTranscurrido)) {
        mostrarAlertaError("Por favor, ingrese valores numéricos válidos");
        return;
    }
 
    if (duracionEstable < 0 || tiempoTranscurrido < 0) {
        mostrarAlertaError("Los tiempos no pueden ser negativos");
        return;
    }
 
    // Convertir todo a segundos
    const tiempoDespegue = 10 * 60; // 10 minutos a segundos
    const tiempoAterrizaje = 15; // 15 segundos
    const duracionEstableSegundos = duracionEstable * 60; // minutos a segundos
 
    const duracionTotalSegundos = tiempoDespegue + duracionEstableSegundos + tiempoAterrizaje;
 
    let faseActual = "";
    const tiempoTranscurridoSegundos = tiempoTranscurrido * 60;
 
    if (tiempoTranscurridoSegundos < tiempoDespegue) {
        faseActual = "Despegue";
    } else if (tiempoTranscurridoSegundos < (tiempoDespegue + duracionEstableSegundos)) {
        faseActual = "Vuelo Estable";
    } else if (tiempoTranscurridoSegundos <= duracionTotalSegundos) {
        faseActual = "Aterrizaje";
    } else {
        faseActual = "Vuelo Finalizado";
    }
 
    // Convertir duración total a horas, minutos y segundos
    const horas = Math.floor(duracionTotalSegundos / 3600);
    const minutos = Math.floor((duracionTotalSegundos % 3600) / 60);
    const segundos = duracionTotalSegundos % 60;
 
    faseVueloElement.innerHTML = `Fase actual: ${faseActual}`;
    duracionTotalElement.innerHTML = `Duración total: ${horas} horas, ${minutos} minutos y ${segundos} segundos`;
 }
 
 document.getElementById("duracionEstable").addEventListener("keypress", function(event) {
    if (event.key === "Enter") {
        document.getElementById("tiempoTranscurrido").focus();
    }
 });
 
 document.getElementById("tiempoTranscurrido").addEventListener("keypress", function(event) {
    if (event.key === "Enter") {
        calcularFaseVuelo();
    }
 });
 
 function validarInput(event) {
    if (event.key === "-" || event.key === "+" || event.key === "e") {
        event.preventDefault();
    }
 }
 
 document.getElementById("duracionEstable").addEventListener("keydown", validarInput);
 document.getElementById("tiempoTranscurrido").addEventListener("keydown", validarInput);
//Ejercicio 3

function validarBinario(input) {

    return /^[0-1]+$/.test(input);
}

function sumarBinarios() {
    const binario1Input = document.getElementById("binario1");
    const binario2Input = document.getElementById("binario2");
    const error1 = document.getElementById("error1");
    const error2 = document.getElementById("error2");
    const resultadoElement = document.getElementById("resultado");
    const primerNumeroElement = document.getElementById("primerNumero");
    const segundoNumeroElement = document.getElementById("segundoNumero");

    const binario1 = binario1Input.value.trim();
    const binario2 = binario2Input.value.trim();

    error1.style.display = "none";
    error2.style.display = "none";
    binario1Input.style.borderColor = "#e0e0e0";
    binario2Input.style.borderColor = "#e0e0e0";

    let hayError = false;

    if (!validarBinario(binario1)) {
        error1.style.display = "block";
        binario1Input.style.borderColor = "#FF6B6B";
        hayError = true;
    }

    if (!validarBinario(binario2)) {
        error2.style.display = "block";
        binario2Input.style.borderColor = "#FF6B6B";
        hayError = true;
    }

    if (hayError) {
        return;
    }

    let num1 = binario1.split('').reverse();
    let num2 = binario2.split('').reverse();
    let maxLength = Math.max(num1.length, num2.length);
    let carry = 0;
    let resultado = [];

    while (num1.length < maxLength) num1.push('0');
    while (num2.length < maxLength) num2.push('0');

    for (let i = 0; i < maxLength; i++) {
        let suma = parseInt(num1[i] || '0') + parseInt(num2[i] || '0') + carry;
        resultado.push(suma % 2);
        carry = Math.floor(suma / 2);
    }

    if (carry > 0) {
        resultado.push(carry);
    }

    primerNumeroElement.innerHTML = `Primer número: ${binario1}`;
    segundoNumeroElement.innerHTML = `Segundo número: ${binario2}`;
    resultadoElement.innerHTML = `Suma binaria: ${resultado.reverse().join('')}`;
}

document.getElementById("binario1").addEventListener("input", function(e) {
    const error1 = document.getElementById("error1");
    if (!validarBinario(e.target.value) && e.target.value !== '') {
        error1.style.display = "block";
        e.target.style.borderColor = "#FF6B6B";
    } else {
        error1.style.display = "none";
        e.target.style.borderColor = "#e0e0e0";
    }
});

document.getElementById("binario2").addEventListener("input", function(e) {
    const error2 = document.getElementById("error2");
    if (!validarBinario(e.target.value) && e.target.value !== '') {
        error2.style.display = "block";
        e.target.style.borderColor = "#FF6B6B";
    } else {
        error2.style.display = "none";
        e.target.style.borderColor = "#e0e0e0";
    }
});

document.getElementById("binario1").addEventListener("keypress", function(event) {
    if (event.key === "Enter") {
        document.getElementById("binario2").focus();
    }
});

document.getElementById("binario2").addEventListener("keypress", function(event) {
    if (event.key === "Enter") {
        sumarBinarios();
    }
});

//Ejercicio 4

// Función para formatear precio en pesos colombianos
function formatarPrecio(numero) {
    return new Intl.NumberFormat('es-CO', {
        style: 'currency',
        currency: 'COP',
        minimumFractionDigits: 0,
        maximumFractionDigits: 0
    }).format(numero);
}

// Función para mostrar alertas personalizadas
function mostrarAlerta(mensaje, tipo) {
    Swal.fire({
        title: tipo === 'error' ? 'Error' : 'Advertencia',
        text: mensaje,
        icon: tipo,
        confirmButtonText: 'Entendido',
        confirmButtonColor: '#845EC2',
        background: '#f8f9fa',
        customClass: {
            popup: 'mi-alerta-personalizada'
        }
    });
}

// Función principal de cálculo de alquiler
function calcularAlquiler() {
    const kilometrosInput = document.getElementById("kilometros");
    const subtotalElement = document.getElementById("subtotal");
    const ivaElement = document.getElementById("iva");
    const totalElement = document.getElementById("total");

    // Parsear con redondeo
    const kilometros = Math.round(parseFloat(kilometrosInput.value) * 100) / 100;

    // Validaciones mejoradas
    if (isNaN(kilometros) || kilometros <= 0) {
        mostrarAlerta('Por favor, ingrese un número positivo de kilómetros', 'error');
        kilometrosInput.value = "";
        return;
    }

    // Nuevo límite máximo de 2000 km
    if (kilometros > 2000) {
        mostrarAlerta('El número de kilómetros no puede superar los 2000 km', 'error');
        return;
    }

    // Constantes de tarifas
    const TARIFA_BASE = 300000;
    const KM_LIMITE1 = 300;
    const KM_LIMITE2 = 1000;
    const TARIFA_ADICIONAL1 = 15000;
    const TARIFA_ADICIONAL2 = 10000;
    const IVA = 0.20;

    // Cálculo del costo base con redondeo
    let costoBase = 0;

    if (kilometros <= KM_LIMITE1) {
        costoBase = TARIFA_BASE;
    } else if (kilometros <= KM_LIMITE2) {
        costoBase = TARIFA_BASE + Math.round((kilometros - KM_LIMITE1) * TARIFA_ADICIONAL1);
    } else {
        costoBase = TARIFA_BASE + 
                    Math.round((KM_LIMITE2 - KM_LIMITE1) * TARIFA_ADICIONAL1) +
                    Math.round((kilometros - KM_LIMITE2) * TARIFA_ADICIONAL2);
    }

    // Cálculo de subtotal e IVA con redondeo
    const total = Math.round(costoBase);
    const subtotal = Math.round(total / (1 + IVA));
    const ivaValor = Math.round(total - subtotal);

    // Actualización de elementos HTML
    subtotalElement.innerHTML = `Subtotal: ${formatarPrecio(subtotal)}`;
    ivaElement.innerHTML = `IVA (20%): ${formatarPrecio(ivaValor)}`;
    totalElement.innerHTML = `Total a Pagar: ${formatarPrecio(total)}`;

    // Animación de resultados
    [subtotalElement, ivaElement, totalElement].forEach(element => {
        element.style.transform = 'scale(1.05)';
        setTimeout(() => {
            element.style.transform = 'scale(1)';
        }, 200);
    });
}

// Eventos de entrada
document.getElementById("kilometros").addEventListener("keypress", function(event) {
    if (event.key === "Enter") {
        calcularAlquiler();
    }
});

document.getElementById("kilometros").addEventListener("keydown", function(event) {
    // Prevenir entrada de caracteres no numéricos
    if (event.key === "-" || event.key === "+" || event.key === "e") {
        event.preventDefault();
    }
});

//Ejercicio 5

function calcularEdad() {
    const fechaNacimientoInput = document.getElementById("fechaNacimiento");
    const edadActualElement = document.getElementById("edadActual");
    const mesesElement = document.getElementById("meses");
    const diasElement = document.getElementById("dias");

    const fechaNacimiento = new Date(fechaNacimientoInput.value);
    const hoy = new Date();

    if (isNaN(fechaNacimiento.getTime())) {
        alert("Por favor, seleccione una fecha válida");
        return;
    }

    if (fechaNacimiento > hoy) {
        alert("La fecha de nacimiento no puede ser futura");
        fechaNacimientoInput.value = "";
        return;
    }

    let edad = hoy.getFullYear() - fechaNacimiento.getFullYear();
    let meses = hoy.getMonth() - fechaNacimiento.getMonth();
    let dias = hoy.getDate() - fechaNacimiento.getDate();

    if (meses < 0 || (meses === 0 && dias < 0)) {
        edad--;
        meses += 12;
    }

    if (dias < 0) {
        const ultimoDiaMesAnterior = new Date(hoy.getFullYear(), hoy.getMonth(), 0).getDate();
        dias += ultimoDiaMesAnterior;
        meses--;
    }

    edadActualElement.innerHTML = `Edad: ${edad} años`;
    mesesElement.innerHTML = `Meses: ${meses}`;
    diasElement.innerHTML = `Días: ${dias}`;

    [edadActualElement, mesesElement, diasElement].forEach(element => {
        element.style.transform = 'scale(1.05)';
        setTimeout(() => {
            element.style.transform = 'scale(1)';
        }, 200);
    });
}

document.getElementById("fechaNacimiento").addEventListener("keypress", function(event) {
    if (event.key === "Enter") {
        calcularEdad();
    }
});

document.getElementById("fechaNacimiento").max = new Date().toISOString().split("T")[0];

