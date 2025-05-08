# Taller-3-Scripting
# Patrones de Diseño
# Informe de Proyecto - Examen de Scripting con Patrones de Diseño en Unity

**Estudiante:** Isabela Giraldo Jimenez
**Evaluación:** Proyecto Final con Patrones de Diseño en Unity

## Enlace al ejecutable

Puedes descargar y probar el proyecto desde este enlace:  
[Descargar Patronesdediseño.exe en Google Drive](https://drive.google.com/file/d/16XgYL6Zee62pPzsMRl2ebOXUHXgE5hdq/view?usp=sharing)
---

## Índice

* [Objetivo del proyecto](#objetivo-del-proyecto)
* [Escena 1: Factory + Facade - FactoryScene](#escena-1-factory--facade---factoryscene)
* [Escena 2: Observer - ObserverScene](#escena-2-observer---observerscene)
* [Escena 3: Object Pooling - ProjectileScene](#escena-3-object-pooling--comportamiento-especializado---projectilescene)
* [Escena Maestra: MainMenu](#escena-maestra-mainmenu)
* [Conclusión y cumplimiento de reglas](#conclusión-y-cumplimiento-de-reglas)

---

## Objetivo del proyecto

Implementar tres escenas independientes en Unity, cada una resolviendo una problemática diferente usando patrones de diseño. Una cuarta escena (MainMenu) permite navegar entre ellas.

Adicionalmente, se debió cumplir la restricción de **no usar el inspector para relacionar objetos**, excepto para prefabs o parámetros visuales.

---

## Escena 1: Factory + Facade - `FactoryScene`

**Problema:** El usuario puede seleccionar uno de tres tipos de objetos (cubo, esfera, cápsula) y generarlos en escena mediante un botón.

**Patrones aplicados:**

* **Factory:** Se crearon tres clases concretas que implementan una interfaz `IObjectFactory`, cada una retornando un tipo de objeto distinto.
* **Facade:** La clase `ObjectSpawner` encapsula el uso de las factories y expone un método simple `Spawn()` al UIManager.

**Interacción:**

* Se usó un canvas con botones para seleccionar tipo de objeto y para instanciar.
* Las conexiones entre lógica y prefabs se hicieron por código o Inspector solo para los prefabs (cumpliendo la restricción).

**Instrucciones de uso:**

1. Seleccionar una figura (cubo, esfera o cápsula) presionando uno de los botones.
2. Presionar el botón "Instanciar" para crear una instancia en la escena.
3. Presionar "Volver" para regresar al menú.

---

## Escena 2: Observer - `ObserverScene`

**Problema:** Un clic izquierdo cíclicamente lanza un número entre 1 y 4, que afecta visualmente a un cubo y se imprime en consola.

**Patrón aplicado:**

* **Observer:** Se implementó un `EventManager` con un evento `OnButtonClicked`.

  * `ClickEmitter` emite el evento.
  * `ColorChanger` cambia el color del cubo al recibir el evento.
  * `Logger` imprime el número en consola.

**Resultado:** El cubo cambia cíclicamente de color y la consola muestra el número actual.
El botón "Volver" está incluido y funcional.

**Instrucciones de uso:**

1. Hacer clic izquierdo en cualquier parte de la pantalla para cambiar el color del cubo.
2. Observar en consola el número actual (de 1 a 4).
3. Presionar "Volver" para regresar al menú.

---

## Escena 3: Object Pooling + comportamiento especializado - `ProjectileScene`

**Problema:** Al disparar proyectiles con clic izquierdo (y cambiar de tipo con clic derecho), cada tipo tiene un comportamiento diferente al impactar con un collider objetivo.

**Patrón aplicado:**

* **Object Pooling:**

  * Se creó una clase abstracta `AbstractProjectilePool` para manejar el reciclaje de objetos.
  * Se extendió con `Type1ProjectilePool`, `Type2ProjectilePool`, y `Type3ProjectilePool`.

**Comportamientos de los proyectiles:**

* **Tipo 1:** Imprime un mensaje en consola.
* **Tipo 2:** Desactiva temporalmente el collider y bloquea el disparo por 1 segundo.
* **Tipo 3:** Activa un sistema de partículas incluido en el prefab.

**Otros detalles:**

* Se evitó interferencia con UI usando `EventSystem.current.IsPointerOverGameObject()`.
* El botón "Volver" inicialmente no respondía por conflicto con el input, pero fue corregido por código.

**Instrucciones de uso:**

1. Hacer clic derecho para cambiar el tipo de proyectil (Tipo 1, 2 o 3).
2. Hacer clic izquierdo para disparar el proyectil actual.
3. Observar el comportamiento del proyectil al impactar con el cubo "Target".
4. Presionar "Volver" para regresar al menú.

---

## Escena Maestra: `MainMenu`

**Propósito:**

* Navegar entre `FactoryScene`, `ObserverScene` y `ProjectileScene`
* Usar `MainMenuManager` como `SceneLoader`

**Resultado:**

* Navegación funcional entre escenas
* Todos los botones funcionan correctamente

**Instrucciones de uso:**

1. Al iniciar el ejecutable, se carga `MainMenu`.
2. Seleccionar una de las tres escenas para probarlas.
3. Usar "Volver" desde cada escena para regresar.

---

## Conclusión y cumplimiento de reglas

* Se utilizaron **Factory**, **Facade**, **Observer** y **Object Pooling** correctamente.

* Se resolvieron problemas como:

  * Encapsulación de lógica de instanciación (Factory)
  * Modularidad y eventos desacoplados (Observer)
  * Eficiencia y reutilización de objetos (Object Pooling)

* Se cumplió la restricción de no usar el Inspector para referencias entre scripts. Solo se usó para:

  * Prefabs
  * Botones UI
  * Parámetros visuales como el `ImpactEffect`

**Observación:**

* Único detalle pendiente fue que el botón "Volver" en `ProjectileScene` inicialmente no funcionaba, pero se resolvió con lógica que ignora input si el clic está sobre UI.

---

**Estado final:** Proyecto completamente funcional y en cumplimiento con los requerimientos del examen.


