Algoritmo sin_titulo
	Definir num, i, factorial Como Entero
	
    Escribir "Ingrese un número entero:"
    Leer num
	
    factorial <- 1
	
    Para i <- 1 Hasta num Hacer
        factorial <- factorial * i
    FinPara
	
    Escribir "El factorial de ", num, " es: ", factorial
FinAlgoritmo
