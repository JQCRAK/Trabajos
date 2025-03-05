//Ejercicio 1
function calcularArea(event) {
    event.preventDefault();
    
    const errorElement = document.getElementById('error-message');
    const ladoA = document.getElementById('lado-a').value;
    const ladoB = document.getElementById('lado-b').value;
    const ladoC = document.getElementById('lado-c').value;
    
    errorElement.textContent = '';
    errorElement.style.opacity = '0';
    
    if (!ladoA || !ladoB || !ladoC) {
        mostrarError1('Todos los campos son obligatorios');
        return false;
    }
    const a = parseFloat(ladoA);
    const b = parseFloat(ladoB);
    const c = parseFloat(ladoC);

    if (isNaN(a) || isNaN(b) || isNaN(c)) {
        mostrarError1('Por favor ingrese solo números válidos');
        return false;
    }

    if (a <= 0 || b <= 0 || c <= 0) {
        mostrarError1('Los lados deben ser mayores que 0');
        return false;
    }

    if (a + b <= c || b + c <= a || a + c <= b) {
        mostrarError1('Los lados no forman un triángulo válido');
        return false;
    }

    const s = (a + b + c) / 2;

    const area = Math.sqrt(s * (s - a) * (s - b) * (s - c));

    document.getElementById('semiperimetro').textContent = `${s.toFixed(2)} cm`;
    document.getElementById('area').textContent = `${area.toFixed(2)} cm²`;

    return false;
}

function mostrarError1(mensaje) {
    const errorElement = document.getElementById('error-message');
    errorElement.textContent = mensaje;
    errorElement.style.opacity = '1';
    
    document.getElementById('semiperimetro').textContent = '-';
    document.getElementById('area').textContent = '-';
}


//Ejercicio 2

function calcularAreaTrapecio(event) {
    event.preventDefault(); 
    
    const baseMayorInput = document.getElementById("base-mayor").value;
    const baseMenorInput = document.getElementById("base-menor").value;
    const alturaInput = document.getElementById("altura").value;
    
    const errorMessage = document.getElementById("error-message");
    
    const baseMayor = parseFloat(baseMayorInput);
    const baseMenor = parseFloat(baseMenorInput);
    const altura = parseFloat(alturaInput);
    
    errorMessage.innerText = "";
    errorMessage.classList.remove("visible");
    
    if (baseMayor < baseMenor) {
        errorMessage.innerText = "La base mayor debe ser mayor o igual a la base menor.";
        errorMessage.classList.add("visible");
        return;
    }
    
    if (isNaN(baseMayor) || baseMayor <= 0) {
        errorMessage.innerText = "Por favor ingrese un valor válido para la base mayor (número positivo).";
        errorMessage.classList.add("visible");
        return;
    }
    
    if (isNaN(baseMenor) || baseMenor <= 0) {
        errorMessage.innerText = "Por favor ingrese un valor válido para la base menor (número positivo).";
        errorMessage.classList.add("visible");
        return;
    }
    
    if (isNaN(altura) || altura <= 0) {
        errorMessage.innerText = "Por favor ingrese un valor válido para la altura (número positivo).";
        errorMessage.classList.add("visible");
        return;
    }
    
    // Usar toFixed(2) para asegurar precisión de 2 decimales
    const area = Number(((baseMayor + baseMenor) * altura) / 2).toFixed(2);
    
    document.getElementById("area").innerText = area;
 }
//Ejercicio 3 

function calcularNumero(event) {
    event.preventDefault();

    const numero = parseFloat(document.getElementById('numero').value);
    const errorMessage = document.getElementById('error-message');
    const raizSpan = document.getElementById('raiz');

    if (isNaN(numero)) {
        errorMessage.classList.add('visible');
        errorMessage.textContent = "Por favor, ingresa un número válido.";
        return;
    }

    const antecesor = numero - 1;
    const sucesor = numero + 1;

    // Para la raíz cuadrada
    if (numero >= 0) {
        raizSpan.textContent = Math.floor(Math.sqrt(numero));
    } else {
        raizSpan.textContent = "No existe para números negativos";
    }

    // Cantidad de cifras (ignorando el signo negativo y el punto decimal)
    const cantidadCifras = Math.abs(numero)
        .toString()
        .replace(".", "")
        .replace(/^0+/, "")
        .length;

    // Actualizar resultados
    document.getElementById('antecesor').textContent = antecesor;
    document.getElementById('sucesor').textContent = sucesor;
    document.getElementById('cifras').textContent = cantidadCifras;

    // Limpiar mensaje de error
    errorMessage.classList.remove('visible');

    return false; // Para asegurar que el formulario no se envíe
}

//Ejercicio 4
function calcularAngulo(event) {
    event.preventDefault();

    const altura = parseFloat(document.getElementById("altura").value);
    const sombra = parseFloat(document.getElementById("sombra").value);

    const errorMessage = document.getElementById("error-message");
    const anguloElement = document.getElementById("angulo");

    if (isNaN(altura) || isNaN(sombra) || altura <= 0 || sombra <= 0) {
        errorMessage.textContent = "Por favor ingrese valores válidos (números positivos).";
        errorMessage.classList.add("visible");
        anguloElement.textContent = "-";
        return false;
    } else {
        errorMessage.classList.remove("visible");
    }

    const anguloRad = Math.atan(altura / sombra);  
    let anguloGrados = anguloRad * (180 / Math.PI);

    const grados = Math.floor(anguloGrados);
    const minutos = Math.floor((anguloGrados - grados) * 60);
    const segundos = Math.round(((anguloGrados - grados) * 60 - minutos) * 60);

    anguloElement.textContent = `${grados}° ${minutos}' ${segundos}"`;
    return false;
}


//Ejercicio 5

function calcularSextoNumero() {
    const num1 = document.getElementById("num1").value;
    const num2 = document.getElementById("num2").value;
    const num3 = document.getElementById("num3").value;
    const num4 = document.getElementById("num4").value;
    const num5 = document.getElementById("num5").value;

    const alertDiv = document.getElementById("alerta");

    if (!validarNumeros(num1, num2, num3, num4, num5)) {
        alertDiv.textContent = "Por favor, ingrese números válidos de 5 cifras.";
        alertDiv.classList.remove("d-none");
        return;
    }

    alertDiv.classList.add("d-none");

    const sextoNumero = 
        num1.toString()[0] + 
        num2.toString()[1] + 
        num3.toString()[2] + 
        num4.toString()[3] + 
        num5.toString()[4]; 

    document.getElementById("resultado").innerText = sextoNumero;
    
    const modal = new bootstrap.Modal(document.getElementById('resultadoModal'));
    modal.show();
}

function validarNumeros(...numeros) {
    return numeros.every(num => {
        const numStr = num.toString();
        return numStr.length === 5 && !isNaN(num);  
    });
}