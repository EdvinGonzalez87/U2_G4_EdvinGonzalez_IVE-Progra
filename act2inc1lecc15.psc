Algoritmo sin_titulo
	Definir billete, cantidad100, totalDinero Como Entero
	
    cantidad100 <- 0
    totalDinero <- 0
	
    Repetir
		
        Escribir "Ingrese el valor del billete (20, 50, 100) o 0 para terminar:"
        Leer billete
		
        Si billete = 100 Entonces
            cantidad100 <- cantidad100 + 1
            totalDinero <- totalDinero + billete
        FinSi
		
    Hasta Que billete = 0
	
    Escribir "Cantidad de billetes de 100: ", cantidad100
    Escribir "Total de dinero en billetes de 100: ", totalDinero

FinAlgoritmo
