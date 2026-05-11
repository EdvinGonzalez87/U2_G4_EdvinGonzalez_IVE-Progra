Algoritmo sin_titulo
	Definir i, multiplo, suma, cantidadPares Como Entero
	
    suma <- 0
    cantidadPares <- 0
	
    Para i <- 1 Hasta 20 Hacer
		
        multiplo <- i * 7
        suma <- suma + multiplo
		
        Si multiplo MOD 2 = 0 Entonces
            cantidadPares <- cantidadPares + 1
        FinSi
		
    FinPara
	
    Escribir "La suma de los primeros 20 múltiplos de 7 es: ", suma
    Escribir "Cantidad de múltiplos pares: ", cantidadPares
FinAlgoritmo
