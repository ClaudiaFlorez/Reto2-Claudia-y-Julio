# Reto2-Claudia-y-Julio
Reto2 VideoGame2D

Nombre estudiante: CLAUDIA MARITZA FLOREZ GUARNIZO
Documento de diseño de videojuego

Nombre del videojuego: Bl00dVania 1.0
Género: Plataformas
Jugadores: Un solo jugador

Especificaciones técnicas del videojuego
Tipo de gráficos: 2D
Vista: Frontal
Plataforma: PC
Lenguaje de programación: C#

Concepto
Descripción general del videojuego: Bl00dvania es la primera versión creada por Mom&Son Inc. como entregable del reto2. Está basada en la historia ficticia del famoso Vlad Tepes (Drácula) “El Empalador” cuyo objetivo en el juego es guiar a Vlad a llegar a su castillo antes del amanecer. 
Esquema de juego: El jugador se enfrenta a diferentes obstáculos (enemigos, vacíos, trampas, entre otros) que encuentra en su camino, los cuales debe vencer para seguir avanzando y a través de ello, lograr su objetivo durante los tres niveles y llegar a su castillo antes que la salida del sol lo destruya. El jugador va ganando puntaje a medida que vence obstáculos y recolecta los ítems para cruzar el nivel, de lo contrario en todos los casos, debe regresar al punto inicial o va perdiendo la vida. Gana puntos y fuerza/poder tomando las copas de sangre, los power-ups y corazones humanos que encuentra en su travesía. 
Opciones de juego: Bl00dvania permite elegir entre 3 diferentes niveles de dificultad, desde fácil hasta difícil, para que el juego sea desafiante pero accesible según las habilidades del jugador.
Resumen de la historia: Vlad Tepes Drácula debe superar tres desafiantes niveles para llegar a su castillo y defender su reino. Cada nivel presenta enemigos y obstáculos únicos que le permitirán seguir avanzando al siguiente nivel.


Modos: Bl00dvania tiene el modo por defecto (Historia) el cual te sumerge en una narrativa histórica y fantástica mientras el personaje lucha contra enemigos y obstáculos para avanzar en su camino.

Elementos del juego: 
Plataformas y niveles unicos.
Enemigos variados con comportamiento tipo “patrol”.
Objetos coleccionables para aumentar la puntuación.
 Power-ups temporales para mejorar las habilidades de Vlad.

Niveles: 
Nivel 1. Fácil: Bosque Encantado. El nivel de juego fácil está diseñado para jugadores principiantes o aquellos que desean disfrutar del juego sin enfrentar demasiado desafío. En este nivel, los obstáculos y enemigos están ubicados de manera estratégica, lo que permite a los jugadores aprender y familiarizarse con los controles y movimientos del juego.
Nivel 2. Normal: Cueva Oscura. El nivel de juego normal es el nivel estándar y equilibrado en términos de dificultad. Aquí, los obstáculos y enemigos ofrecen un desafío adecuado para la mayoría de los jugadores. Es el nivel recomendado para aquellos que desean disfrutar del juego sin que sea demasiado fácil ni demasiado difícil.
Nivel 3. Difícil: Camino al Castillo. El nivel de juego difícil presenta un mayor desafío para los jugadores experimentados. Los obstáculos y enemigos pueden ser más difíciles de vencer. Requiere una mayor precisión y estrategia en los movimientos para tener éxito.

Controles: 
Flechas izquierda/derecha para moverse.
Barra espaciadora para saltar.
Click izquierdo para atacar con espada.
Click derecho para lanzar proyectiles
Tecla “W” movimiento rápido “dash”.


Diseño
Definición del diseño del videojuego: El diseño se centra en la progresión de la dificultad a lo largo de los niveles, con enemigos y obstáculos más difíciles de superar. Se busca ofrecer una experiencia de juego desafiante pero gratificante.
1.	Gráficos y efectos visuales: presenta gráficos y diseño 2D basados en género Plataformeo como metroidvanias y referencia retro. 
2.	Personajes: el personaje principal está basado en la historia de Drácula (Vlad “El Empalador”) y los enemigos están basados en monstruos de la cultura pop. 
3.	Escenarios y ambientación: Los escenarios reflejan diferentes ubicaciones tenebrosas proporcionando un ambiente de terror para una mejor experiencia del jugador.
4.	Sonido y música: La elección de sonidos tenebrosos y música dramática contribuye a la atmósfera intensa del juego. 

Técnicas de gamificación:
1.	Puntaje: Sistema de puntuación por corazón y copa de sangre tomada y recompensas por tramos superados.
2. 	Sistema de progresión: Bl00dVania presenta un sistema de progresión en el que el jugador puede subir al siguiente nivel al completar los desafíos del nivel actual ó puede empezar en un nivel avanzado basado en su experiencia y curiosidad.

Flujo del videojuego: 
El flujo del videojuego Bl00dVania sigue un ciclo de juego típico que se repite a lo largo de la experiencia de juego:
•	Introducción con historia ficticia de Vlad Tepes Drácula.
•	Selección de nivel de dificultad.
•	Juego a través de tres niveles.
•	Pantalla de puntuación y logros para completar cada nivel.
•	Finalización del juego y resumen de la puntuación total.

Interfaces de usuario:
Las interfaces de usuario en el juego de Bl00dVania son intuitivas y diseñadas para proporcionar una experiencia de juego fluida. 
1.	Menú principal: Es la primera pantalla que aparece al iniciar el juego. Desde aquí, el jugador puede acceder al juego, al menú de Opciones y más. 
2.	Selección de Nivel: En esta interfaz, los jugadores pueden elegir el nivel de juego que desean realizar de acuerdo a su curiosidad o previa experiencia.
3.	Pantalla de Nivel: Es la interfaz principal durante un nivel. Muestra la información esencial, como el panel de vida, el puntaje, tiene su botón de pausa y de volver al menú inicial. 
4.	Pantalla de Pausa: En esta interfaz, muestra el estado del juego y le da opción al jugador de reiniciar el nivel, continuar desde el punto donde quedó o salir al menú principal. 

5.	Pantalla de resultados: Al finalizar el nivel, se muestra una pantalla de resultados donde se felicita la actuación del jugador. Muestra la opción de continuar al siguiente nivel, reiniciar el mismo nivel ó salir al menú principal.
6.	Menú de opciones: Aquí el jugador puede activar o desactivar el audio. También pueden acceder a opciones adicionales como información de los creadores, obtener ayuda o volver al menú principal..
7.	Pantalla de game over: Cuando el jugador pierda todas sus vidas nos aparecerá la pantalla de game over que consta de:
●	Mensaje de “Humm…Te moriste”: como dice el título, nos aparece un mensaje indicando que hemos perdido.
●	Salir: salir de la pantalla actual y volver al menú principal.
●	Botón de volver a jugar: Nos devuelve a la escena de inicio de partida del nivel actual, para volver a realizar otro intento.
El juego utiliza una combinación de elementos visuales, iconos, texto y navegación intuitiva para proporcionar a los jugadores una experiencia de usuario cómoda y accesible. Cada interfaz está diseñada para facilitar la interacción y la comprensión de las diferentes funciones y opciones del juego.

Storyboard: 

 

Vlad atravesando el bosque encantado, superando obstáculos y recolectando items para seguir su camino hacia la cueva oscura.
 
Vlad ha pasado el bosque y puede seguir su camino hacia la cueva.

 
Vlad atravezando la cueva oscura y recolectando ítems para llegar a su castillo antes del amanecer

 
Vlad enfrentando enemigos para seguir su camino hacia su hogar.


Bibliografía
Unity. (s. f.). Game design document (GDD) template. https://acortar.link/3tl9Ay
Unity Package Manager: Metroidvania Controller
YouTube: https://www.youtube.com/watch?v=3syACF6Wcxk
Google: https://www.google.com/search?client=firefox-b-d&q=castelvania
Google: https://www.freepik.es/
ChatGPT: https://chat.openai.com/



