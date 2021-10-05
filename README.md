# natalia-jimenez-julio-parcial-2-ads

El programa que desarrollé es un minijuego de Pokémon donde tienes que capturar a Pikachu y Mewtwo con una masterball y una pokeball, a Pikachu lo puedes atrapar tanto con la masterball como con la pokeball pero a Mewtwo solo lo puedes atrapar con la masterball. El minijuego se desarrolló en Unity y se trabajó en Visual Studio 2019 con el lenguaje de programación C#. Para ejecutarlo se necesita la aplicación Unity Hub donde se descarga la versión 2020.3.14 de Unity o la más reciente.

El primer patrón que se implementó fue el patrón de diseño creacional Singleton para manter la canción durante las escenas como instancia única. Se usó primeramente un método de pbjeto llamado Don´t Destroy on Load para preservar el objeto durante la carga de la escena, en este caso el objeto es el audio (Línea 13 del script Script Audio) sin embargo, enl problema que se tenía era que la canción, como hacía parte de cada escena, al correr la escena la canción se volvia a crear por lo que se sobreponía a la que ya estaba sonando y si se quita el audio de la otra escena y empiezo el juego por esa escena no habría música. Para resolver este problema se necesitaba tener una sola instancia del objeto y que nunca se duplique, es decir un Singleton. Primero se creó una variable pública y estática que almacenará una instancia de esa clase y es de tipo de la clase misma es decir tipo Script Audio donde se le guarda la única instancia (línea 7 del mismo script). La variable inst está con valor null por lo tanto si la instancia tiene ese valor, esa instancia se convierte en ese script y solo en ese caso se ejecuta el método Don´t Destroy on Load (Lineas 10 a 14 de Script Audio), cuando otra escena se cargue, la instancia preguntara por el valor y como no es nulo, se destruirá el script y el objeto Audio de la escena (Líneas de la 15 a 18 de Script Audio). 

El segundo platrón implementado es el patrón de comportamiento Strategy. Este patron nos permite definir una familia de clases o algoritmos de forma que sean intercambiables entre si y el consumidor no sepa si está usando el algoritmo 1 o 2 o el que sea y se consigue mediante el uso de interfaces. En este caso el jugador interactuará con la interfaz Ball (script Ball), no sabrá si está utilizando una masterball o una pokeball, solo sabe que tiene una esfera con un método de Lanzar. En el script tanto de la pokeball como de la masterball tienen el método Lanzar para lanzar distintos prefabs de pokeballs o masterballs para poder atrapar a los pokemons. En el script del jugador también hay un método de lanzar que si se presiona la tecla espacio, llamará al método Lanzar de la clase Ball y un método SetBall para establecer el tipo de pokeball (Líneas 16-26 script: Player). En otro script llamado instanciador recogerá por medio del método GetBall es tipo de pokeball que esta lanzando e instanciará esa pokeball al lado del player para que el jugador sepa que pokeball está por lanzar (Líneas 22-30 script: instanciador). Para cambiar entre las pokeballs está el método CambiarBall donde se destruirá la pokeball que tenía el entrenador, se llamará al método GetBall y se le asignará al jugador mediante el método SetBall (Lineas 32-38 script: instanciador).

Notas:  El juego consta de dos escenas donde el jugador podrá cambiar entre las pokeballs y las masterballs con la tecla X y para lanzar con el espacio. Si desea continuar hasta la siquiente escena, solo tiene que caminar recto pero una vez cambia de escena no podrá devolverse.
