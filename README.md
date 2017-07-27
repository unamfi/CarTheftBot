![](Resources/banner.png?raw=true)

CarTheftBot is a chatbot system where citizens report stolen cars to bots and bots report to police to stop them.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

What things you need to install the software and how to install them

```
Give examples
```

### Installing

A step by step series of examples that tell you have to get a development env running

Say what the step will be

```
Give the example
```

And repeat

```
until finished
```

End with an example of getting some data out of the system or using it for a little demo

## Running the tests

Explain how to run the automated tests for this system

### Break down into end to end tests

Explain what these tests test and why

```
Give an example
```

### And coding style tests

Explain what these tests test and why

```
Give an example
```

## Deployment

Add additional notes about how to deploy this on a live system

## Built With

* One
* Two

## Contributing

Please read [CONTRIBUTING.md](https://gist.github.com/PurpleBooth/b24679402957c63ec426) for details on our code of conduct, and the process for submitting pull requests to us.

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/your/project/tags). 

## Authors

* **Alberto Ladrón**
* **Juan Pablo Flores Cortés**
* **Julio César Fruta**

See also the list of [contributors](https://docs.google.com/spreadsheets/d/1biFpxiorsmXsK6GH37ONPSjASQy5b_zpyw3enSVFlHo/edit#gid=0) who participated in this project.

## License

This project is licensed under the GNU License - see the [LICENSE](LICENSE) file for details

## Acknowledgments

* Hat tip to anyone who's code was used
* Inspiration
* etc

# Presentación del proyecto

CarTheftBot is a chatbot system where citizens report stolen cars to bots and bots report to police to stop them.

El águila real es un ave de presa eficiente, ágil.    Es símbolo del valor y el poder debido a su fuerza y tamaño y el es el símbolo nacional de México.
Este proyecto lo representa el águila real porque los ciudadanos unidos serán como ella al defender sus derechos del crimen organizado.
Desgraciadamente en nuestro país hemos dejado de confiar en las
autoridades para la aplicación de la justicia.

El crimen organizado crece dia a dia.  Existe un sentimiento
impotencia como ciudadanos.

### Objetivos

Este proyecto tiene un único objetivo, dejar al crimen
organizado sin un medio de transporte.

### Especificaciones

Los criminales requieren automóviles para operar y los automóviles que
utilizan son robados.

La idea es crear una suite de aplicaciones que permita tener un sistema alterno
al oficial para reporte y seguimiento de los autos robados.  El
sistema será alimentado por la misma ciudadanía, sera un sistema de
multitudes.   La propuesta de creara un sistema alterno es porque los
ciudadanos hemos dejado de confiar en el sistema oficial.

Un punto muy importante es brindar una aplicación que no comprometa la
seguridad física de los usuarios.

El sistema brindará información de manera libre a todo tipo de
usuarios, esperando que dicha información sea utilizada para garantizar el bien público.

La información que brinda el sistema será utilizada para que víctimas
del delito recuperen sus vehículos de manera oportuna y también para
ayudar a otro actores involucrados como aseguradoras.
### Módulos

1. Módulo de reporte inicial de vehículo robado

Para validar la autenticidad del reporte se requerirá una fotografía de la matrícula del vehículo o algún otro método.

2. Módulo para reporte de vehículo sospechoso.

Servirá para que usuarios puedan reportar vehículos que tengan sospecha de ser robados.
Se buscará si existe registro sobre el vehículo robado en la base de datos de repuve http://www2.repuve.gob.mx:8080/ciudadania/

3. Módulo de generación de mapas de delincuencia.

Mediante el uso de herramientas de inteligencia de negocio se podrán estudiar patrones de comportamiento, crear mapas de delincuencia y predecir eventos futuros.
Mapa de incidencia de robo de vehículos.
Mapa de localidades donde los vehículos robados son más utilizados.

4. Módulo para consulta de automóviles robados en determinada ubicación.

Una parte muy importante del sistema es poder predecir patrones en
el robo y uso de los automóviles robados.  Por ejemplo, los automóviles
robados en Monterrey que son utilizados para cometer delitos en
Tamaulipas.
Es común que los vehículos robados sean abandonados frente a
parques o lugares públicos inmediatamente después de ser robados por
un par de días con el objetivo de confirmar que no cuentan con
dispositivos de monitoreo.
Este módulo permitirá al usuario consultar vehículos que han sido
reportados como robados o sospechosos en su ubicación actual,
identificarlos y brindar un reporte de la ubicación del vehículo.
