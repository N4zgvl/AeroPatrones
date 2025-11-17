# 📘 README – AirportCCM

Control y Coordinación de Mantenimiento en Aeropuertos
Proyecto académico – Instituto Tecnológico de Tijuana

📌 Descripción general

AirportCCM es un sistema desarrollado como parte de una práctica académica cuyo objetivo es evaluar, documentar y refactorizar un proyecto basado en ASP.NET MVC, aplicando patrones de diseño, buenas prácticas de arquitectura y automatización mediante herramientas de DevOps (Ansible).

El proyecto busca mejorar la mantenibilidad, escalabilidad y claridad de una solución existente, justificando cada decisión técnica mediante un informe formal y entregables prácticos.

🎯 Objetivos del proyecto

Analizar problemas en una base de código original.

Identificar malas prácticas, anti–patrones y vulnerabilidades.

Aplicar patrones de diseño adecuados (SOLID, MVC, DTO, Repository, Dependency Injection, etc.).

Refactorizar el código fuente con comentarios detallados en español LATAM.

Automatizar la instalación y despliegue utilizando Ansible.

Entregar documentación formal mediante archivo PDF y presentación en video (LOOM).

🏗️ Arquitectura y tecnologías
Categoría	Tecnología / Patrón
Lenguaje	C#
Framework	.NET 8 / ASP.NET MVC
IDE recomendado	Visual Studio 2022
Documentación	PDF + README
Patrón arquitectónico	MVC + Repository + Services
Buenas prácticas	SOLID, DRY, KISS, Clean Code
🔍 Problemas detectados en la versión original

Código acoplado y dependiente entre controladores y modelo.

Lógica de negocio mezclada con la capa de presentación.

Falta de comentarios y documentación.

Reutilización limitada de componentes.

Falta de validaciones y excepciones controladas.

Escalabilidad y mantenimiento deficientes.

Ausencia de separación clara por capas.

🛠️ Patrones y mejoras implementadas

| Patrón                  | Tipo           | Uso aplicado en el proyecto                       |
| ----------------------- | -------------- | ------------------------------------------------- |
| Factory Method          | Creacional     | Creación controlada de vuelos                     |
| Strategy                | Comportamiento | Tipos de aterrizaje                               |
| State                   | Comportamiento | Ciclo de vida de vuelo                            |
| Observer                | Comportamiento | Subscripción torre–vuelos                         |
| Mediator                | Comportamiento | Torre coordinando comunicación                    |
| Command                 | Comportamiento | Comandos de acción sobre vuelos                   |
| Template Method         | Comportamiento | Flujo de despegue-aterrizaje                      |
| Decorator               | Estructural    | Extender funcionalidades sin modificar clase base |
| Chain of Responsibility | Comportamiento | Validación y autorización por etapas              |
| Singleton               | Creacional     | Instancia única de torre de control               |



▶️ Instalación y ejecución en local

1️⃣ Clonar el repositorio

git clone https://github.com/N4zgvl/AeroPatrones.git


2️⃣ Restaurar dependencias

dotnet restore


3️⃣ Ejecutar aplicación

dotnet run --project src/AirportCCM.Web

👨‍💻 Autor
Nombre:	José Guadalupe Rodríguez Sastre
Carrera	Ingeniería en Informática
Instituto Tecnológico de Tijuana

📄 Licencia MIT
