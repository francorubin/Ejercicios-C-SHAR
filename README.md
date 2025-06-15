# Práctica de Programación Orientada a Objetos

Este proyecto contiene la resolución de una serie de ejercicios prácticos sobre **Programación Orientada a Objetos (POO)**. Todos los ejercicios fueron desarrollados utilizando el lenguaje **C#**, y aplican conceptos como clases, objetos, interfaces, encapsulamiento y herencia.

## Ejercicios incluidos

### 1. Semáforo 🚦
Se creó una clase `Semaforo` que permite simular el comportamiento real de un semáforo. 
- Cambia de color según una secuencia temporal (Rojo, Rojo-Amarillo, Verde, Amarillo).
- Permite iniciar desde cualquier color.
- Soporta el modo **intermitente**, alternando entre "amarillo" y "apagado" cada segundo.

### 2. Cronómetro ⏱️
Clase `Cronometro` que simula un cronómetro funcional.
- Tiene métodos para reiniciar, incrementar el tiempo y mostrarlo en minutos y segundos.
- Al llegar a 60 segundos, incrementa automáticamente el contador de minutos.

### 3. Jugador Cansado 🏃‍♂️
Implementación de una interfaz `Jugador` con clases `Amateur` y `Profesional`.
- Permite simular jugadores que se cansan tras correr un cierto tiempo.
- Métodos: `correr(minutos)`, `cansado()`, `descansar(minutos)`.

### 4. Vehículos en Movimiento 🚗🚚🚲
Se desarrollaron las clases `Auto`, `Camion` y `Bicicleta`, todas implementando una interfaz `Vehiculo`.
- Cada vehículo tiene una velocidad diferente y puede moverse por tiempo determinado.
- Se implementó una clase `Carrera` que permite simular una competencia entre dos vehículos y mostrar sus posiciones finales.

### 5. Cuenta Bancaria 💰
Clases `CuentaBancaria` y `Banco`.
- Permiten consultar, modificar saldo, depositar, extraer y transferir dinero entre cuentas.
- Se implementan validaciones para que no se pueda extraer más de lo disponible.

## Objetivo
Aplicar los conocimientos adquiridos sobre Programación Orientada a Objetos de forma práctica, usando ejemplos que simulan situaciones del mundo real.

## Autor
**Franco Mondino y Franco Rubin**  
Estudiante de Instituto Politécnico Superior, Sexto Informática 

Profesor: Mauricio Gonzales

Fecha: Junio 2025

---

> Todos los ejercicios están desarrollados respetando buenas prácticas de codificación y organizados en clases separadas para facilitar la lectura y reutilización del código.

