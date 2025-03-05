//Ejercicio 1
function calcularFactorial(n) {
    if (n === 0 || n === 1) return 1;
    let resultado = 1;
    for (let i = 2; i <= n; i++) {
        resultado *= i;
    }
    return resultado;
}

function esPerfecto(numero) {
    if (numero <= 1) return false;
    let sumaDivisores = 1;
    for (let i = 2; i <= Math.sqrt(numero); i++) {
        if (numero % i === 0) {
            sumaDivisores += i;
            if (i !== numero / i) {
                sumaDivisores += numero / i;
            }
        }
    }
    return sumaDivisores === numero;
}

function esCapicua(numero) {
    const numStr = numero.toString();
    return numStr === numStr.split('').reverse().join('');
}

function esPalindromo(numero) {
    return esCapicua(numero); 
}

function esFactorion(numero) {
    const sumFactoriales = numero.toString()
        .split('')
        .reduce((sum, digit) => sum + calcularFactorial(parseInt(digit)), 0);
    return sumFactoriales === numero;
}

function numeroDeCifras(numero) {
    return numero.toString().length;
}

function analizarNumero() {
    const numeroInput = document.getElementById("numero");
    const numero = parseInt(numeroInput.value);

    if (isNaN(numero)) {
        alert("Por favor, ingrese un número válido");
        numeroInput.value = "";
        return;
    }

    if (numero < 0) {
        alert("Por favor, ingrese un número positivo");
        numeroInput.value = "";
        return;
    }

    const resultados = {
        perfecto: {
            elemento: document.getElementById("resultPerfecto"),
            valor: esPerfecto(numero)
        },
        capicua: {
            elemento: document.getElementById("resultCapicua"),
            valor: esCapicua(numero)
        },
        palindromo: {
            elemento: document.getElementById("resultPalindromo"),
            valor: esPalindromo(numero)
        },
        factorial: {
            elemento: document.getElementById("resultFactorial"),
            valor: calcularFactorial(numero)
        },
        factorion: {
            elemento: document.getElementById("resultFactorion"),
            valor: esFactorion(numero)
        },
        cifras: {
            elemento: document.getElementById("resultCifras"),
            valor: numeroDeCifras(numero)
        }
    };

    Object.entries(resultados).forEach(([tipo, info]) => {
        const { elemento, valor } = info;
        
        elemento.classList.remove('animated');
        void elemento.offsetWidth; 
        elemento.classList.add('animated');

        switch(tipo) {
            case 'factorial':
                elemento.textContent = `El factorial es: ${valor}`;
                break;
            case 'cifras':
                elemento.textContent = `Tiene ${valor} cifras`;
                break;
            case 'perfecto':
            case 'capicua':
            case 'palindromo':
            case 'factorion':
                elemento.textContent = valor ? "Sí" : "No";
                break;
        }
    });
}

document.getElementById("numero").addEventListener("keypress", function(event) {
    if (event.key === "Enter") {
        analizarNumero();
    }
});

document.getElementById("numero").addEventListener("keydown", function(event) {
    if (event.key === "-" || event.key === "+" || event.key === "e" || event.key === ".") {
        event.preventDefault();
    }
});


//Ejercicio 2


//Ejercicio 3

function generarCombinaciones() {
    const digitos = [1, 2, 3, 4];
    const combinaciones = [];
    
    for (let i = 0; i < digitos.length; i++) {
        for (let j = 0; j < digitos.length; j++) {
            for (let k = 0; k < digitos.length; k++) {
                if (digitos[i] !== digitos[j] && 
                    digitos[i] !== digitos[k] && 
                    digitos[j] !== digitos[k]) {
                    const numero = digitos[i] * 100 + digitos[j] * 10 + digitos[k];
                    combinaciones.push(numero);
                }
            }
        }
    }

    combinaciones.sort((a, b) => a - b);

    const contenedor = document.getElementById('resultadoCombinaciones');
    const totalElement = document.getElementById('totalCombinaciones');
    
    contenedor.innerHTML = '';
    
    combinaciones.forEach((numero, index) => {
        const numeroDiv = document.createElement('div');
        numeroDiv.className = 'number-item animated';
        numeroDiv.style.animationDelay = `${index * 50}ms`;
        numeroDiv.textContent = numero;
        contenedor.appendChild(numeroDiv);
    });

    totalElement.textContent = combinaciones.length;

    const resultCard = contenedor.closest('.result-card');
    resultCard.classList.remove('animated');
    void resultCard.offsetWidth; 
    resultCard.classList.add('animated');
}

document.addEventListener('DOMContentLoaded', generarCombinaciones);




//Ejercicio 4

function intercambiarDigitos(numero) {
    return parseInt(numero.toString().split('').reverse().join(''));
}

function buscarNumerosEspeciales() {
    const resultados = [];
    const productosVistos = new Set();

    for (let num1 = 10; num1 <= 99; num1++) {
        for (let num2 = 10; num2 <= 99; num2++) {
            const producto1 = num1 * num2;
            const num1Invertido = intercambiarDigitos(num1);
            const num2Invertido = intercambiarDigitos(num2);
            const producto2 = num1Invertido * num2Invertido;

            if (producto1 === producto2 && !productosVistos.has(producto1)) {
                if (num1 !== num1Invertido || num2 !== num2Invertido) {
                    productosVistos.add(producto1);
                    resultados.push({
                        original: {
                            num1: num1,
                            num2: num2,
                            producto: producto1
                        },
                        invertido: {
                            num1: num1Invertido,
                            num2: num2Invertido,
                            producto: producto2
                        }
                    });
                }
            }
        }
    }

    mostrarResultados(resultados);
}

function mostrarResultados(resultados) {
    const contenedor = document.getElementById('resultadosContainer');
    const totalElement = document.getElementById('totalPares');
    
    contenedor.innerHTML = '';
    
    resultados.forEach((resultado, index) => {
        const resultadoDiv = document.createElement('div');
        resultadoDiv.className = 'result-item animated';
        resultadoDiv.style.animationDelay = `${index * 100}ms`;
        
        const contenido = `
            <div class="result-title">Producto: ${resultado.original.producto}</div>
            <div class="calculation">
                <div class="calculation-item">
                    ${resultado.original.num1} × ${resultado.original.num2} = ${resultado.original.producto}
                </div>
                <div class="calculation-item">
                    ${resultado.invertido.num1} × ${resultado.invertido.num2} = ${resultado.invertido.producto}
                </div>
            </div>
        `;
        
        resultadoDiv.innerHTML = contenido;
        contenedor.appendChild(resultadoDiv);
    });

    totalElement.textContent = resultados.length;

    const resultCard = contenedor.closest('.result-card');
    resultCard.classList.remove('animated');
    void resultCard.offsetWidth; 
    resultCard.classList.add('animated');
}

document.addEventListener('DOMContentLoaded', buscarNumerosEspeciales);



//Ejercicio 5

function generarTabla() {
    const tabla = document.getElementById('multiplicationTable');
    tabla.innerHTML = ''; 
    
    const thead = document.createElement('tr');
    
    thead.appendChild(document.createElement('th'));
    
    for (let i = 1; i <= 12; i++) {
        const th = document.createElement('th');
        th.textContent = i;
        thead.appendChild(th);
    }
    tabla.appendChild(thead);
    
    for (let i = 1; i <= 12; i++) {
        const tr = document.createElement('tr');
        
        const th = document.createElement('th');
        th.textContent = i;
        tr.appendChild(th);
        
        for (let j = 1; j <= 12; j++) {
            const td = document.createElement('td');
            td.textContent = i * j;
            
            td.addEventListener('mouseenter', function() {
                highlightRelatedCells(i, j);
            });
            
            td.addEventListener('mouseleave', function() {
                removeHighlight();
            });
            
            tr.appendChild(td);
        }
        tabla.appendChild(tr);
    }
    
    tabla.classList.remove('animated');
    void tabla.offsetWidth;
    tabla.classList.add('animated');
}

function highlightRelatedCells(row, col) {
    const tabla = document.getElementById('multiplicationTable');
    const cells = tabla.getElementsByTagName('td');
    const headers = tabla.getElementsByTagName('th');
    
    headers[col].classList.add('cell-highlight');
    headers[row * (12 + 1)].classList.add('cell-highlight');
    
    const currentCell = tabla.rows[row].cells[col];
    currentCell.classList.add('cell-highlight');
}

function removeHighlight() {
    const tabla = document.getElementById('multiplicationTable');
    const cells = tabla.getElementsByTagName('td');
    const headers = tabla.getElementsByTagName('th');
    
    for (let cell of cells) {
        cell.classList.remove('cell-highlight');
    }
    
    for (let header of headers) {
        header.classList.remove('cell-highlight');
    }
}

document.addEventListener('DOMContentLoaded', generarTabla);