Algoritmo sin_titulo
	Definir opcion, totalBoletos, totalCobrado Como Entero
	
    totalBoletos <- 0
    totalCobrado <- 0
	
    Repetir
		
        Escribir "Presione 1 si es niño"
        Escribir "Presione 2 si es adulto"
        Escribir "Presione 0 para finalizar"
        Leer opcion
		
        Si opcion = 1 Entonces
			
            totalBoletos <- totalBoletos + 1
            totalCobrado <- totalCobrado + 10
			
        Sino
			
            Si opcion = 2 Entonces
				
                totalBoletos <- totalBoletos + 1
                totalCobrado <- totalCobrado + 15
				
            FinSi
			
        FinSi
		
    Hasta Que opcion = 0
	
    Escribir "Número de boletos vendidos: ", totalBoletos
    Escribir "Total cobrado: ", totalCobrado, " soles"
FinAlgoritmo
