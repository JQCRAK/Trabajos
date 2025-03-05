function calcularSextoNumero() {
    const num1 = document.getElementById("num1").value;
    const num2 = document.getElementById("num2").value;
    const num3 = document.getElementById("num3").value;
    const num4 = document.getElementById("num4").value;
    const num5 = document.getElementById("num5").value;

    if (!validarNumeros(num1, num2, num3, num4, num5)) {
        alert("Por favor, ingrese números válidos de 5 cifras");
        return;
    }

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



function calcularSextoNumero1() {
    const num1 = document.getElementById("num1").value;
    const num2 = document.getElementById("num2").value;
    const num3 = document.getElementById("num3").value;
    const num4 = document.getElementById("num4").value;
    const num5 = document.getElementById("num5").value;

    if (!validarNumeros1(num1, num2, num3, num4, num5)) {
        alert("Por favor, ingrese números válidos de 5 cifras");
        return;
    }

    const sextoNumero = 
        num1.toString()[0] +
        num2.toString()[1] +
        num3.toString()[2] +
        num4.toString()[3] +
        num5.toString()[4];

    document.getElementById("resultado").innerText = sextoNumero;
    document.getElementById("resultadoAlert").classList.remove("d-none");
}

function validarNumeros1(...numeros) {
    return numeros.every(num => {
        const numStr = num.toString();
        return numStr.length === 5 && !isNaN(num);
    });
}