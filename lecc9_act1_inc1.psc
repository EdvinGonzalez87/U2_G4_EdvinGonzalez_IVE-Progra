Algoritmo lecc9_act1_inc1
	definir pesoacumulado, pesomanzana, contarmanzanas Como Real
	pesoacumulado=0;
	contarmanzanas=0;
	
	Escribir "========Bascula del mercado========="
	
		Mientras pesoacumulado<1000 Hacer
			Escribir "Ingrese el peso de la manzana en gramos (100-300)"
			Leer pesomanzana
			Si pesomanzana>=100 y pesomanzana <=300 Entonces
				pesoacumulado=pesoacumulado+pesomanzana
				Escribir "peso actual: ",pesoacumulado,"Gramos"
				contarmanzanas=contarmanzanas+1
			SiNo
				Escribir "Error: Esa manzanano cumple con el peso solicitado"
			Fin Si
		Fin Mientras
		Escribir "meta alcanzada, Ya tiene ", pesoacumulado/100 "kg en la bolsa "
		Escribir "Usted acumulo", contarmanzanas,"El total de manzanas"
FinAlgoritmo
