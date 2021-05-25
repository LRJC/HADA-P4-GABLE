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
