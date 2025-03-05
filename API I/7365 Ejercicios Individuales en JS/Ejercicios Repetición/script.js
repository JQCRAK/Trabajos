function esPrimo(n) {
    if (n < 2) return false;
    for (let i = 2; i <= Math.sqrt(n); i++) {
        if (n % i === 0) return false;
    }
    return true;
}

function buscarNumeros() {
    let resultados = [];

    for (let num = 1200; num <= 2000; num++) {
        let divisores = obtenerDivisores(num);
        
        if (divisores.length === 4 && 
            divisores.includes(1) && 
            divisores.includes(num) && 
            divisores.some(d => esPrimo(d) && d !== 1 && d !== num)) {
            
            let primo = divisores.find(d => esPrimo(d) && d !== 1 && d !== num);
            
            resultados.push({
                numero: num,
                divisores: divisores,
                primo: primo
            });
        }
    }

    mostrarResultados(resultados);
}

function obtenerDivisores(numero) {
    return Array.from({length: numero}, (_, i) => i + 1).filter(i => numero % i === 0);
}

function mostrarResultados(resultados) {
    let contenedor = document.getElementById('resultadosContainer');
    contenedor.innerHTML = '';

    if (resultados.length === 0) {
        contenedor.innerHTML = `
            <div class="alert alert-warning">
                No se encontraron números que cumplan las condiciones.
            </div>
        `;
        return;
    }

    resultados.forEach(result => {
        let tarjeta = document.createElement('div');
        tarjeta.className = 'result-card';
        tarjeta.innerHTML = `
            <div class="numero"><strong>Número:</strong> ${result.numero}</div>
            <div class="divisores"><strong>Divisores:</strong> ${result.divisores.join(', ')}</div>
            <div class="primo"><strong>Número primo:</strong> ${result.primo}</div>
        `;
        contenedor.appendChild(tarjeta);
    });
}