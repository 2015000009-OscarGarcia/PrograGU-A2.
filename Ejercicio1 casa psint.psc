Algoritmo Ejercicio1_En_Casa
    Definir anguloGrados, anguloRadianes Como Real
    Definir opcion Como Entero
    Escribir "Ingrese el ángulo en grados: "
    Leer anguloGrados
    anguloRadianes = anguloGrados * (PI / 180)
    
    Escribir "1- Seno, 2- Coseno, 3- Tangente"
    Leer opcion
    Segun opcion Hacer
        1: Escribir "Seno: ", Sen(anguloRadianes)
        2: Escribir "Coseno: ", Cos(anguloRadianes)
        3: Escribir "Tangente: ", Tan(anguloRadianes)
        De Otro Modo: Escribir "Opción inválida"
    FinSegun
FinAlgoritmo