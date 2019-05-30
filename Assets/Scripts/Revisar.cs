﻿/*  ---------- TAREAS ----------
 * 
 * Testear en VR si todas las luces encienden como tienen que hacerlo (que el material se cambie)
 * 
 * Testear en VR si todos los interruptores y la linterna suenan al pulsarse
 * 
 * Testear en Vr si se puede subir la escalera y si hay que aumentar el Step Up Offset en VRTK_Scripts > BodyPhysics
 * 
 */



/* ---------- DUDAS ----------
 * 
 *
 * 
 * Si fuerzo mucho el movimiento hacia una pared acabo atravesándola
 *
 * Para abrir las puertas, ¿puedo limitar el ángulo en el que se abre la puerta como máximo?
 * https://www.moddb.com/tutorials/how-to-open-a-vr-door-in-unity-and-steamvr
 * 
 * Por algún motivo tengo las luces de la planta de abajo como estáticas pero las luces de la planta de arriba no lo son, estas luces son las que se encienden con los interruptores
 * ¿Las pongo todas como estáticas o como no estáticas?
 * 
 */

/* ---------- PROBLEMAS ----------
 * 
 * He puesto que todos los prefabs de las paredes, suelos y techos generen sombras a ambos lados y algunas luces siguen traspasándolos
 * 
 * 
 * Error Objetos con UVs sobrepuestas
 * https://docs.unity3d.com/Manual/ProgressiveLightmapper-UVOverlap.html
 * No me aparece el menú de Objects Maps en Lighting para corregir esas UVs
 * 
 * 
 */

/* ---------- OTRAS DUDAS ----------
 * 
 * ¿Qué hago con el exterior? ¿Creo una pequeña zona residencial para que no se quede la casa en el vacío?
 * ¿O qué otra cosa podría hacer? (sin que resulte en añadir muchos más elementos para no cargar la escena)
 * 
 * 
 * ¿Tengo que bajar la resolución de todos los archivos de las texturas para bajarle el peso? 
 * (algunas texturas están en 4K) 
 * ¿O sólo bajo la resolución de los archivos que más pesen? 
 * Son muchas texturas como para ir 1 a 1, si no hay otra manera pues se hace.
 * 
 * 
 */

/* ---------- SPRINTS ----------
 * 
 * SPRINT 1: 17 ABRIL AL 01 MAYO 
 * Prerrequisitos: gráficos y GDD (Objetivo y mecánicas)
 * Tareas: tareas de programación básicas (mecánicas) y diseño de niveles
 * 
 * SPRINT 2: 02 MAYO AL 15 MAYO
 * Prerrequisitos: Diseño de niveles terminado
 * Tareas: Programación avanzada e iluminación
 * 
 * SPRINT 3: 16 MAYO AL 29 MAYO
 * Prerrequisitos: Mecánicas terminadas
 * Tareas: Testeo y optimizacion y sonido
 * 
 * 
 */