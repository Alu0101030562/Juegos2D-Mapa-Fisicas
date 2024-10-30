# Juegos2D Mapa - Fisicas

# Físicas 2D

## 1. Crear una escena simple sobre la que probar diferentes configuraciones de objetos físicos en Unity. Incluye scripts para cada uno de los tipos de objetos: Dinámico, Cinemático, Estático y prográmales eventos OnCollision2D y OnTrigger2D que muestren un mensaje con cada uno de los tipos de evento en consola. Configura adecuadamente el collider y/o Rigidbody, además del evento que corresponda para poder imprimir el mensaje en la consola.

Se añaden tres personajes y una plataforma que servirá como suelo. Se añade un script al personaje para que pueda moverse y comprobar los siguientes apartados.

### a. Ninguno de los objetos será físico.

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/1.%20apartado%20a.gif)

### b. Un objeto tiene físicas y el otro no.

Añadimos los componentes Rigidbody2D y BoxCollider2D al jugador y al suelo, para evitar que el personaje caiga al vacío. El BodyType en el componente Rigidbody2D del personaje será Dynamic, mientras que el del suelo será estático.

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/2.%20Cofiguracion%20b.PNG)

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/3.%20apartado%20b.gif)

### c. Ambos objetos tienen físicas.

Añadimos las mismas físicas que incluimos al personaje controlado por el jugador (Rigidbody2D y BoxCollider2D) al enemigo.

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/4.%20configuracion%20c.PNG)

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/5.%20apartado%20c.gif)

### d. Ambos objetos tienen físicas y uno de ellos tiene 10 veces más masa que el otro.

Aumentamos a 10 la variable Mass del componente Rigidbody2D del enemigo.

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/6.%20configuracion%20d.PNG)

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/7.%20apartado%20d.gif)

### e. Un objeto tiene físicas y el otro es IsTrigger.

Eliminamos el Rigidbody2D del enemigo y marcamos la opción IsTrigger de su BoxCollider2D, lo que hará que el enemigo sea ignorado por las físicas del jugador.

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/8.%20configuracion%20e.PNG)

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/9.%20apartado%20e.gif)

### f. Ambos objetos son físicos y uno de ellos está marcado como IsTrigger.

Volvemos a añadir un Rigidbody2D al enemigo y dejamos marcada la opción IsTrigger.

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/10.%20cofiguracion%20f.PNG)

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/11.%20apartado%20f.gif)

### g. Uno de los objetos es cinemático.

Cambiamos el Rigidbody2D.BodyType del enemigo a Kinematic.

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/12.%20configuracion%20g.PNG)

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/13.%20apartado%20g.gif)

## 2. Incorpora elementos físicos en tu escena que respondan a las siguientes restricciones:
### a. Objeto estático que ejerce de barrera infranqueable.

Esto esta hecho desde el apartado 1 con la plataforma

### b. Zona en la que los objetos que caen en ella son impulsados hacia adelante.

Añadimos un nuevo GameObject en la escena con los componentes AreaEffector2D y BoxCollider2D. Este último ha de tener las variables IsTrigger y UsedByEffector a true.

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/14.%20configuracion%202b.PNG)

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/15.%20apartado%202b.gif)

### c. Objeto que es arrastrado por otro a una distancia fija.

Agregamos otro GameObject y le añadimos los componentes Rigidbody2D, DistanceJoint2D y CircleCollider2D. Luego, marcamos la opción DistanceJoint2D.EnableCollision y asignamos una referencia a DistanceJoint2D.ConnectedRigidbody que apunte a nuestro personaje.

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/16.%20configuracion%202c.PNG)

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/17.%20apartado%202c.gif)

### d. Objeto que al colisionar con otros sigue un comportamiento totalmente físico.

Se añade un objeto con un Rigidbody2D.

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/18.%20apartado%202d.gif)

### e. Incluye dos capas que asignes a diferentes tipos de objetos y que permita evitar colisiones entre ellos.

Añadimos las capas Player y Enemy. La primera será añadida al jugador, mientras que la segunda capa al otro personaje en la escena.

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/19.%20configuracion%202e.PNG)

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/20.%20configuracion%202e%202.PNG)

Luego, nos dirigimos a Edit -> Project Settings -> Physics 2D -> Layer Collision Matrix y desmarcamos la relación Enemy/Player, para que se ignoren las colisiones entre ambas capas.

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/21.%20configuracion%202e%203.PNG)

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/22.%20apartado%202e.gif)

# Mapa (Tilemaps)

## 1. Construir un mapa de juego.

Desde la pestaña "Hierarchy" hacemos click derecho y seleccionamos **2D Object -> Tilemap -> Rectangular** para crear el tilemap.

Una vez hecho esto, vamos a **windows -> 2D -> Tile Palette**. Con esto se abrirá la pestaña de Tile Palette, donde podremos crear nuestra nueva paleta.

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/23.%20configuracion%201.PNG)

Una vez creada ya podemos seleccionar el pincel con el sprite que queremos para poder dibujar en el mapa

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/24.%20configuracion%202.PNG)

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/25.%20configuracion%203.PNG)

Una vez hecho ya tendriamos el fondo, una primera parte del mapa.

## 2. Trabajar con varios tilemaps
### a. Crea dos Tilemaps adicionales, uno puede representar elementos decorativos y otro obstáculos.

Ahora, crearemos dos tilemaps nuevos, uno para la superficie y el otro para elementos decorativos

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/26.%20configuracion%204.PNG)

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/27.%20configuracion%205.PNG)

### b. Agrega a la capa de obstáculos la configuración necesaria para que el Tilemap se construya de forma independiente y el obstáculo actúe como tal.

Añadimos el componente TilemapCollider2D en TM_Ground, marcando la opción UsedByComposite. A continuación, añadimos el componente CompositeCollider2D, que añadirá automáticamente un Rigidbody2D. Por último, establecemos el Rigidbody2D.BodyType a Static, para que no se vea afectado por las físicas y se caiga al vacío.

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/28.%20movimiento%20ground.gif)

## 3. Implementar un control de personajes basado en físicas.
### a. Movimiento basado en físicas

Añadiremos la siguientes variables:

- Una que indicará la velocidad del jugador
- Otra encargada de indicar si el jugador se esta moviendo
- La dirección a la que se debe mover el jugador
- Un rigidbody que será de referencia al Rigidbody2D del jugador. Está será inicializada en el método Start() con la ayuda del método GetComponent<T>().

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/28.%20movimiento%20ground.gif)

### b. Salto

[script](https://github.com/Alu0101030562/Juegos2D-Mapa-Fisicas/blob/main/Assets/Scripts/Player%20TileMap/PlayerJump.cs)

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/29.%20movimiento%20salto.gif)

## 4. Implementar las siguientes mecánicas relacionadas con plataformas:
### a. Salto a una plataforma

Lo primero que haremos será hacer que el sprite del jugador sea hijo de Tilemap_Ground y crear otro tilemap más al que se le incluirá la etiqueta "Ground". Este nuevo tilemap consistirá en plataformas flotantes que se moverán de izquierda a derecha.

[Script de las plataformas](https://github.com/Alu0101030562/Juegos2D-Mapa-Fisicas/blob/main/Assets/Scripts/Player%20TileMap/Platform.cs)

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/30.%20salto%20a%20plataforma.gif)

### b. Manejar colisiones con elementos de una capa determinada.

Creamos la layer "Ground" y sustituimos la línea if (other.gameObject.CompareTag("Ground")) en el método OnCollisionEnter2D() por if (other.gameObject.layer == LayerMask.NameToLayer("Ground")). De esta forma, se ignorará cualquier colisión que no pertenezca a la capa "Ground".

### c. Plataformas invisibles que se vuelven visibles.

Se añade otra layer llamada "Invisible" y se le asigna a un nuevo tilemap.

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/31.%20Plataformas%20invisbles.PNG)

Para hacer que los tiles sean invisibles, se desactiva el componente TilemapRenderer de TM_InvisiblePlatforms.

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/32.%20configuracion%20TM%20invisible.PNG)

La acción que se realizará cuando se colisione con estas plataformas invisibles será aplicar una fuerza que eleve al jugador en el eje positivo de la Y y volver estas plataformas visibles.

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/33.%20plataforma%20invisible.gif)

### d. Mecánica de recolección.

Añadimos los objetos que serán coleccionados a la escena y le asignamos la capa "Item". Cada objeto ha de tener un componente de tipo Collider2D y un Rigidbody2D cuyo BodyType esté establecido como Kinematic.

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/34.%20Items.PNG)

Cada objeto recolectado incrementará nuestra puntuación, por tanto, creamos una UI para mostrarla.

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/35.%20Interfaz.PNG)

![](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/MapaFisicas2D/36.%20puntuacion%20final.gif)

[Script final con la mecanica de recolección](https://github.com/Alu0101030562/Juegos2D-Mapa-Fisicas/blob/main/Assets/Scripts/Player%20TileMap/PlayerTMController.cs)

