//Ejercicio 1
let recognition;
let isListening = false;

window.onload = function() {
    if ('webkitSpeechRecognition' in window) {
        recognition = new webkitSpeechRecognition();
        setupRecognition();
    } else {
        document.getElementById('status').textContent = 'Tu navegador no soporta reconocimiento de voz';
        document.getElementById('startButton').disabled = true;
    }
}

function setupRecognition() {
    recognition.continuous = true;
    recognition.interimResults = true;
    recognition.lang = 'es-ES';

    const startButton = document.getElementById('startButton');
    const statusElement = document.getElementById('status');
    const outputElement = document.getElementById('output');

    startButton.onclick = toggleRecognition;

    recognition.onstart = function() {
        isListening = true;
        statusElement.textContent = 'Escuchando...';
        startButton.classList.add('pulse');
        startButton.textContent = 'Detener Reconocimiento';
    };

    recognition.onend = function() {
        isListening = false;
        statusElement.textContent = 'Reconocimiento detenido';
        startButton.classList.remove('pulse');
        startButton.textContent = 'Iniciar Reconocimiento';
    };

    recognition.onresult = function(event) {
        let finalTranscript = '';
        let interimTranscript = '';

        for (let i = event.resultIndex; i < event.results.length; i++) {
            const transcript = event.results[i][0].transcript.toLowerCase();
            if (event.results[i].isFinal) {
                finalTranscript += transcript;
                processCommand(transcript);
            } else {
                interimTranscript += transcript;
            }
        }

        outputElement.innerHTML = finalTranscript + '<i style="color: #999">' + interimTranscript + '</i>';
    };

    recognition.onerror = function(event) {
        statusElement.textContent = 'Error: ' + event.error;
    };
}

function toggleRecognition() {
    if (isListening) {
        recognition.stop();
    } else {
        recognition.start();
    }
}

function processCommand(transcript) {
    const outputElement = document.getElementById('output');
    
    if (transcript.includes('hola')) {
        speak('¡Hola! ¿Cómo estás?');
    }
    else if (transcript.includes('hora')) {
        const hora = new Date().toLocaleTimeString();
        speak('La hora actual es ' + hora);
    }
    else if (transcript.includes('fecha')) {
        const fecha = new Date().toLocaleDateString();
        speak('La fecha actual es ' + fecha);
    }
    else if (transcript.includes('chiste')) {
        const chistes = [
            '¿Por qué los pájaros no usan Facebook? Porque ya tienen Twitter',
            '¿Qué le dice un jaguar a otro jaguar? Jaguar you',
            '¿Qué le dice una iguana a su hermana gemela? Somos iguanitas',
            '¿Por qué los programadores odian la naturaleza? Porque tiene demasiados bugs',
            '¿Qué hace una abeja en el gimnasio? ¡Zum-ba!',
            '¿Por qué el libro de matemáticas estaba triste? Porque tenía muchos problemas',
            '¿Qué hace un perro con un taladro? ¡Taladrando!',
            '¿Qué le dijo un semáforo a otro? No me mires, me estoy cambiando',
            '¿Cómo se despiden los químicos? Ácido un placer',
            '¿Qué hace una vaca en la luna? ¡Leche lunar!'
        ];
        
        const chisteAleatorio = chistes[Math.floor(Math.random() * chistes.length)];
        speak(chisteAleatorio);
    }
    else if (transcript.includes('limpiar')) {
        outputElement.innerHTML = '';
        speak('Texto limpiado');
    }
}

function speak(text) {
    const utterance = new SpeechSynthesisUtterance(text);
    utterance.lang = 'es-ES';
    speechSynthesis.speak(utterance);
}


//Ejercicio 2
function contarLetras() {
    const textoInput = document.getElementById('textoInput');
    const resultado = document.getElementById('resultado');
    const errorMessage = document.getElementById('errorMessage');
    
    const texto = textoInput.value.toUpperCase();
    
    if (!/^[A-ZÑ\s]*$/.test(texto)) {
        errorMessage.style.display = 'block';
        return;
    } else {
        errorMessage.style.display = 'none';
    }
    
    const conteo = {};
    
    for (let letra of texto) {
        if (letra !== ' ') {
            conteo[letra] = (conteo[letra] || 0) + 1;
        }
    }
    
    resultado.innerHTML = '';
    
    Object.entries(conteo)
        .sort((a, b) => b[1] - a[1]) 
        .forEach(([letra, cantidad]) => {
            const card = document.createElement('div');
            card.className = 'letra-card';
            
            const letraElement = document.createElement('div');
            letraElement.className = 'letra';
            letraElement.textContent = letra;
            
            const cantidadElement = document.createElement('div');
            cantidadElement.className = 'cantidad';
            cantidadElement.textContent = cantidad;
            
            card.appendChild(letraElement);
            card.appendChild(cantidadElement);
            resultado.appendChild(card);
        });
}

document.getElementById('textoInput').addEventListener('input', function(e) {
    const errorMessage = document.getElementById('errorMessage');
    const texto = e.target.value;
    
    if (!/^[A-Za-zÑñ\s]*$/.test(texto)) {
        errorMessage.style.display = 'block';
    } else {
        errorMessage.style.display = 'none';
    }
});


