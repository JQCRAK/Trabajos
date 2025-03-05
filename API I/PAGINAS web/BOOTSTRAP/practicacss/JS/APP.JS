//alert("Hola Mundo Js");

/*
let  local en el archivo  
var  global en el archivo
*/
let valor = 5;
let texto = "Hola, Mundo!";
let valor1=20;
let fecha = new Date();
/*
document.write(valor);   // Correcto: escribe en la página
document.write("<br>");  // Salto de línea
document.write(texto);
document.write("<br>");
document.write(valor1);
document.write("<br>");
document.write(fecha);

*/

function valorleido() {
    let ValorL = document.getElementById("valorn").value;
    document.getElementById("resultado").innerText = ValorL;
}

function leervalor() {
    let Radio = document.getElementById("valorradio").value;

    Radio = parseFloat(Radio);

    if (isNaN(Radio) || Radio <= 0) {
        document.getElementById("radiore").innerText = "Por favor, ingrese un valor numérico válido para el radio.";
        return;
    }

    document.getElementById("radiore").innerText = "Área: " + ArerC(Radio).toFixed(2);
}

function ArerC(radio) {
    return Math.PI * Math.pow(radio, 2);
}


function calcularDiscriminante() {
    let a = parseFloat(document.getElementById("valorA").value);
    let b = parseFloat(document.getElementById("valorB").value);
    let c = parseFloat(document.getElementById("valorC").value);

    if (isNaN(a) || isNaN(b) || isNaN(c)) {
        document.getElementById("discriminanteRes").innerText = "Por favor, ingrese valores numéricos válidos para a, b y c.";
        return;
    }

    let discriminante = Math.pow(b, 2) - 4 * a * c;

    document.getElementById("discriminanteRes").innerText = "Discriminante: " + discriminante;
}

function encontrarmayor() {
    
    const edad1 = document.getElementById("edad1").value;
    const edad2 = document.getElementById("edad2").value;
    const edad3 = document.getElementById("edad3").value;

    const mayor = Math.max(edad1, edad2, edad3);

    document.getElementById("edadM").innerText = "La mayor edad es: " + mayor;
}

function verificarPrimo() {
    const numero = parseInt(document.getElementById("numeroFor").value);
    if (isNaN(numero) || numero <= 1) {
        document.getElementById("resultadoFor").innerText = "Ingrese un número válido mayor que 1.";
        return;
    }

    let esPrimo = true;

    for (let i = 2; i <= Math.sqrt(numero); i++) {
        if (numero % i === 0) {
            esPrimo = false;
            break;
        }
    }

    document.getElementById("resultadoFor").innerText = esPrimo
        ? `${numero} es un número primo.`
        : `${numero} no es un número primo.`;
}