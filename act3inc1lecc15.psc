Algoritmo sin_titulo
	Definir num, i, contador, cantidadPrimos, sumaPares Como Entero
	
    cantidadPrimos <- 0
    sumaPares <- 0
	
    Para num <- 300 Hasta 1 Con Paso -1 Hacer
		
        Si num MOD 2 = 0 Entonces
            sumaPares <- sumaPares + num
        FinSi
		
        contador <- 0
		
        Para i <- 1 Hasta num Hacer
			
            Si num MOD i = 0 Entonces
                contador <- contador + 1
            FinSi
			
        FinPara
		
        Si contador = 2 Entonces
            cantidadPrimos <- cantidadPrimos + 1
        FinSi
		
    FinPara
	
    Escribir "Cantidad de números primos entre 300 y 1: ", cantidadPrimos
    Escribir "Suma de los números pares entre 300 y 1: ", sumaPares
FinAlgoritmo
