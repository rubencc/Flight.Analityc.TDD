# Flight.Analityc.TDD

Validaremos el resumen de cada vuelo para evaluar la calidad asignando una calificacion (APlus, A, B, C, D, E) a cada uno de ellos.
La calificacion de la que se parte es la A. Cada segmento de tiempo que se excede resta un punto en la calificacion. 

1) Un vuelo que viaja dentro de la peninsula con un retraso de hasta 15 min pierde un punto en la calificacion. 

2) Un vuelo que viaja entre dos puntos de España, siendo o no uno de ellos dentro de la peninsula, con un retraso de hasta 20min
pierde un punto en la calificacion. 

3) Un vuelo que viaja con destino o salida de las islas canarias con un retraso de hasta 30min pierde un punto.

4) Un vuelo con origen y destino dentro del mismo contienente con un retraso de hasta 45min pierde un punto. 

5) Un vuelo con origen y destino en diferentes continentes con un retraso de hasta 65min pierde un punto. 

6) Un vuelo no puede exceder los 900Min.

7) Un vuelo que haya aterrizado en un destino distinto al fijado automaticamente tiene la peor calificación. 

9) Los vuelos con hora de llegada estimada que coinciden con la hora de llegada real ganan un punto. 
