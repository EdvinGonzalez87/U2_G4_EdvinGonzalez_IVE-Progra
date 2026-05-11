Algoritmo sin_titulo
	
    Definir opcion, boletos, totalBoletos, totalDinero Como Entero
	
    totalBoletos <- 0
    totalDinero <- 0
	
    Repetir
		
        Escribir "1. Boleto adulto (15 soles)"
        Escribir "2. Boleto niño (10 soles)"
        Escribir "3. Salir"
        Leer opcion
		
        Segun opcion Hacer
			
            1:
                totalBoletos <- totalBoletos + 1
                totalDinero <- totalDinero + 15
				
            2:
                totalBoletos <- totalBoletos + 1
                totalDinero <- totalDinero + 10
				
        FinSegun
		
    Hasta Que opcion = 3
	
    Escribir "Total de boletos vendidos: ", totalBoletos
    Escribir "Total de dinero cobrado: ", totalDinero, " soles"
FinAlgoritmo
