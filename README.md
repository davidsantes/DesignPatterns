# �Qu� son los patrones de dise�o?

Los patrones de dise�o o design patterns, son una solucion general, reutilizable y aplicable a diferentes problemas de dise�o de software. Se trata de plantillas que identifican problemas en el sistema y proporcionan soluciones apropiadas a problemas generales a los que se han enfrentado los desarrolladores durante un largo periodo de tiempo, a trav�s de prueba y error.

## Tipos de patrones de dise�o de software
Los patrones de dise�o m�s utilizados se clasifican en tres categor�as principales, cada patr�n de dise�o individual conforma un total de 23 patrones de dise�o. Las tres categor�as principales son:
* Patrones creacionales
* Patrones estructurales
* Patrones de comportamiento

## Patrones creacionales

Los patrones de creaci�n proporcionan diversos mecanismos de creaci�n de objetos, que aumentan la flexibilidad y la reutilizaci�n del c�digo existente de una manera adecuada a la situaci�n. Esto le da al programa m�s flexibilidad para decidir que objetos deben crearse para un caso de uso dado.

Estos son los patrones creacionales:
* Abstract Factory: en este patr�n, una interfaz crea conjuntos o familias de objetos relacionados sin especificar el nombre de la clase.
* Builder Patterns: permite producir diferentes tipos y representaciones de un objeto utilizando el mismo c�digo de construcci�n. Se utiliza para la creaci�n etapa por etapa de un objeto complejo combinando objetos simples. La creaci�n final de objetos depende de las etapas del proceso creativo, pero es independiente de otros objetos.
* Factory Method: proporciona una interfaz para crear objetos en una superclase, pero permite que las subclases alteren el tipo de objetos que se crearon. Proporciona instanciaci�n de objetos impl�cita a trav�s de interfaces comunes
* Prototype: permite copiar objetos existentes sin hacer que su c�digo dependa de sus clases. Se utiliza para restringir las operaciones de memoria / base de datos manteniendo la modificaci�n al m�nimo utilizando copias de objetos.
* Singleton: este patr�n de dise�o restringe la creaci�n de instancias de una clase a un �nico objeto. 

## Patrones estructurales

Facilitan soluciones y est�ndares eficientes con respecto a las composiciones de clase y las estructuras de objetos. El concepto de herencia se utiliza para componer interfaces y definir formas de componer objetos para obtener nuevas funcionalidades.

Estos son los patrones estructurales:
* Adapter: se utiliza para vincular dos interfaces que no son compatibles y utilizan sus funcionalidades. El adaptador permite que las clases trabajen juntas de otra manera que no podr�an al ser interfaces incompatibles.
* Bridge: en este patr�n hay una alteraci�n estructural en las clases principales y de implementador de interfaz sin tener ning�n efecto entre ellas. Estas dos clases pueden desarrollarse de manera independiente y solo se conectan utilizando una interfaz como puente.
* Composite: se usa para agrupar objetos como un solo objeto. Permite componer objetos en estructuras de �rbol y luego trabajar con estas estructuras como si fueran objetos individuales.
* Decorator: restringe la alteraci�n de la estructura del objeto mientras se le agrega una nueva funcionalidad. La clase inicial permanece inalterada mientras que una clase decorator proporciona capacidades adicionales.
* Facade: proporciona una interfaz simplificada para una biblioteca, un marco o cualquier otro conjunto complejo de clases.
* Flyweight: se usa para reducir el uso de memoria y mejorar el rendimiento al reducir la creaci�n de objetos. El patr�n busca objetos similares que ya existen para reutilizarlo en lugar de crear otros nuevos que sean similares.
* Proxy: se utiliza para crear objetos que pueden representar funciones de otras clases u objetos y la interfaz se utiliza para acceder a estas funcionalidades

## Patrones de comportamiento

El patr�n de comportamiento se ocupa de la comunicaci�n entre objetos de clase. Se utilizan para detectar la presencia de patrones de comunicaci�n ya presentes y pueden manipular estos patrones.

Estos patrones de dise�o est�n espec�ficamente relacionados con la comunicaci�n entre objetos.
* Chain of responsibility: el patr�n de dise�o Chain of Responsibility es un patr�n de comportamiento que evita acoplar el emisor de una petici�n a su receptor dando a m�s de un objeto la posibilidad de responder a una petici�n.
* Command: convierte una solicitud en un objeto independiente que contiene toda la informaci�n sobre la solicitud. Esta transformaci�n permite parametrizar m�todos con diferentes solicitudes, retrasar o poner en cola la ejecuci�n de una solicitud y respaldar operaciones que no se pueden deshacer.
* Interpreter: se utiliza para evaluar el lenguaje o la expresi�n al crear una interfaz que indique el contexto para la interpretaci�n.
* Iterator: su utilidad es proporcionar acceso secuencial a un n�mero de elementos presentes dentro de un objeto de colecci�n sin realizar ning�n intercambio de informaci�n relevante.
* Mediator: este patr�n proporciona una comunicaci�n f�cil a trav�s de su clase que permite la comunicaci�n para varias clases.
* Memento: el patr�n Memento permite recorrer elementos de una colecci�n sin exponer su representaci�n subyacente.
* Observer: permite definir un mecanismo de suscripci�n para notificar a varios objetos sobre cualquier evento que le suceda al objeto que est� siendo observado.
* State: en el patr�n state, el comportamiento de una clase varia con su estado y, por lo tanto, esta representado por el objeto de contexto.
* Strategy: permite definir una familia de algoritmos, poner cada uno de ellos en una clase separada y hacer que sus objetos sean intercambiables.
* T�mplate m�todo: se usa con componentes que tienen similitud donde se puede implementar una plantilla del c�digo para probar ambos componentes. El c�digo se puede cambiar con peque�as modificaciones.
* Visitor: el prop�sito de un patr�n Visitor es definir una nueva operaci�n sin introducir las modificaciones a una estructura de objeto existente.

## Wiki

* [profile.es](https://profile.es/blog/patrones-de-dise�o-de-software/)
* [refactoring.guru](https://refactoring.guru/es/design-patterns/classification)