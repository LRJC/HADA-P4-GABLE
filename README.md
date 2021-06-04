
###README FINAL

INFORME FINAL GABLE:
-Funcionamiento de la página:

-Al cargar la página, se nos mostrará una página de inicio, que contendrá un ‘header’ con un asp:menú tipo hamburguesa con una serie de categorías de juegos de mesa, además de un buscador donde podremos buscar tanto productos por nombre o categoría. Encontramos el logo de Gable, el cual si pulsamos nos redirecciona a la página de inicio. También podemos encontrar un botón de cesta en el cual si pinchamos y estamos logueados, podemos acceder a los productos de su interior, además de un botón de inicio de sesión. 
En la página de inicio tendremos una barra de navegación con tres categorías de productos, como más valorados, recomendados, …
Al pinchar en un producto, nos saldrá una página específica sobre ese producto, con todos sus datos y valoraciones. 
Estando logueados, podremos añadir al carrito y comentar sobre productos, además, pinchando en el botón de carrito, podremos proceder a hacer un pedido. El botón de Inicio de sesión se sustituirá por un botón de Área Personal, donde podremos acceder a una página donde podremos editar nuestros datos, o revisar nuestros pedidos, cerrar sesión, …
Al realizar un pedido, se nos redirigirá a una página donde tendremos que rellenar una serie de campos con los datos bancarios. 
Cabe destacar que existe un usuario administrador, el cual es el único que puede acceder a la página de admin con sus credenciales(email: admin@gable.com, contraseña: admin). En la página de admin podremos gestionar marcas, productos, y eliminar usuarios.

LUCAS->CADPedido, ENPedido, CADUsuario, ENUsuario, ENMarca, CADMarca, Resultado_busqueda, index.aspx, parte admin, parte del buscador. Ayudas de en CADS de otras personas. 

PABLO->CADProductos, ENProductos, CADLinped, ENLinped, CADValoraciones, ENValoraciones, productos.aspx, parte admin, parte Resultados_busqueda, Poblar base de datos e inserción a visual. Ayudas en CADS de otras personas. 

NICO->CADProvincia,ENProvincia, CADLocalidad, ENLocalidad,AreaPersonal[aspx,aspx.cs] (Parte de datos) y (Parte de pedido),ayuda en el CADUsuario(readUsuario) , parte de admin.aspx y parte de la master.aspx. Método getPedidos de ENPedido y CADPedido.

ALEJANDRO LATORRE->Register.aspx, Login.aspx, DatosPago.aspx y ayuda en la admin.aspx. Ayudas en CADS de otras personas. 

ALEJANDRO OLIVARES->Diseño del logo y textura del header, CADCesta, ENCesta,CADLinCesta, ENLinCesta, Cesta.aspx y parte de la master.aspx.

ANDRES MACIA-> CADDirEnvio, ENDirEnvio, CADTipoProducto, ENTipoProducto, master.aspx

INCIDENCIAS:
-Poca o nula iniciativa por parte de Alejandro Olivares y Andrés Maciá a trabajar en grupo.
Hasta dos días  antes de la entrega no sabíamos nada de Alejandro Latorre, por problemas personales. JUSTIFICADO. Aún así, su parte(login, register, datos pago) está hecha. 

Revisando que todo fuese bien al tener todo hecho(04/06/2021 ~17:00) se ha detectado que la Cesta no funcionaba bien. No se generan los pedidos correctamente. Nicolás ha intentado arreglarlo, pero era muy tarde y no era su código así que ha tenido que rehacer la función de ProceedToBuy(), pero sólo ha podido rehacer el .cs por falta de tiempo. Se ha hablado con Alejandro Olivares, pero no ha puesto de su parte y no se ha llegado a nada. Aún así, hemos añadido pedidos a los usuarios julia@gmail.com (contraseña: julia) y a pepe@gmail.com (contraseña: pepe) a mano a la BBDD para que se pueda visualizar el trabajo realizado en AreaPersonal_ped.aspx. Al loggearse con esos usuarios se puede visualizar correctamente.


¡
# TIENDA DE JUEGOS DE MESA

### INTEGRANTES DEL GRUPO
* ALEJANDRO OLIVARES
* LUCAS JEACOCK (Coordinador)
* NICOLAS VAN OLMEN
* ANDRES MACIA
* ALEJANDRO LATORRE
* PABLO SANCHEZ

### DESCRIPCIÓN
-La tienda online GABLE es un portal de compraventa de juegos de mesa donde puedes encontrar una gran variedad de productos como juegos tradicionales, juegos de rol, de estrategia y muchos más!!!!
Como cliente, navega por nuestra página y descubre miles de juegos.

### PARTE PUBLICA
-En esta parte podrás ver todos los productos disponibles en la página, con sus precios, valoraciones y marcas. Además podrás añadir al carrito tus productos favoritos. Estando en la parte pública, podrás tanto registrarte como iniciar sesión. 

### LISTADO ENTIDADES PUBLICAS
-ENProducto -> Esta entidad representa a los productos. Estos contienen, marca, imagen, un precio, un género y descripción, y una serie de valoraciones representadas por la ENValoracion. Las funcionalidades implementadas son las siguientes: leer, crear, eliminar, modificar. 

-ENCesta -> La ENCesta representa el carrito o cesta de la compra. Cuando estás navegando como usuario público sin estar registrado en nuestra página, puedes seleccionar un producto y meterlo en el carrito, para posteriormente comprarlo. Eso sí, para comprar un producto deberás registrarte como usuario de la página obligatoriamente. Las funcionalidades implementadas son las siguientes: añadir producto, quitar producto, y proceder a compra. 

-ENLineaCesta -> La línea de la cesta sirve para enumerar los productos dentro de la cesta. Cada línea tiene un producto concreto con su cantidad y precio. Las dos funcionalidades que tiene son las de añadir y quitar productos de la cesta. 

-EnTipoProducto -> Esta entidad representa la categoría del producto, o su género. Como funcionalidades, se implementan las CRUD. 

-ENMarca -> Esta entidad representa la marca de los productos. Tenemos su nombre, origen y logo. Las funcionalidades que se implementan son las CRUD. 

### PARTE PRIVADA
-En esta parte es donde se hacen todas las gestiones relacionadas con los usuarios registrados en la página, como puede ser comprar, modificar la cuenta, dejar valoraciones, ...
Además, siendo ADMIN, habrá la opción de añadir y quitar productos a la página web. Siendo ADMIN, gestionas los productos, las provincias, las localidades, borrar valoraciones, ... 

### LISTADO ENTIDADES PRIVADAS
-ENUsuario -> Esta entidad representa al usuario registrado en la página web, es decir, que puede comprar en la página. Las funcionalidades que tiene, a parte de las CRUD, son las de login y logout. Siendo admin, estan las funcionalidades de añadir y quitar productos a la página, y añadir y quitar provincias y localidades de la base de datos de la página.

-ENLocalidad -> Esta entidad representa las localidades del mundo real, y se utiliza para da veracidad a las direcciones de los usuarios. Las funcionalidades que tiene son las CRUD.  

-ENPedido -> Representa cuando un usuario ha hecho una compra, que entonces se registra como un pedido. 

-ENLineaPedido -> La línea del pedido sirve para enumerar los productos dentro de un pedido. Cada linea de pedido tiene un producto concreto con su cantidad y precio. 

-ENValoracion -> Esta entidad representa una opinión de un usuario sobre un producto. Esta opinión es representada por una nota numérica del 1 al 5, y un mensaje opcional. Las funcionalidades que tiene son las CRUD. 

-ENDirEnvio -> ENDirEnvio representa la dirección de envío de los usuarios registrados en la página. Esta entidad tiene como funcinalidades las CRUD. 

-ENProvincia -> Esta entidad representa las provincias del mundo real, y se utiliza para da veracidad a las direcciones de los usuarios. Las funcionalidades que tiene son las CRUD. 

###PROBLEMAS

###REPARTO DEL TRABAJO

## LAS BASE DE DATOS ESTA SUBIDA AL REPO EN LA RAMA DEVELOP
