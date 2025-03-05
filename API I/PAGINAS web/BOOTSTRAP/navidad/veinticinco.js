function calcularFactorial() {
    const numero = parseInt(document.getElementById("numeroFactorial").value);

    if (isNaN(numero) || numero < 0 || numero > 15) {
        document.getElementById("resultadoFactorial").innerText = "Por favor, ingrese un número válido entre 0 y 15.";
        return;
    }

    const resultado = factorial(numero);
    document.getElementById("resultadoFactorial").innerText = `Factorial de ${numero}: ${resultado}`;
}

function factorial(n) {
    if (n === 0 || n === 1) return 1;
    return n * factorial(n - 1);
}


