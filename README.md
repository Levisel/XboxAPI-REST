# Xbox Game Pass API 🎮

## Descripción 📄

Esta API REST inspirada en el servicio de XboxGamePass permite gestionar información relacionada a este servicio. Proporciona operaciones CRUD (Crear, Leer, Actualizar, Eliminar) y utiliza procedimientos almacenados para interactuar con la base de datos. La API está diseñada para facilitar la gestión de clientes, planes, suscripciones y pagos dentro del ecosistema de Xbox Game Pass o cualquier otro tipo de servicio relacionado a este modelo de negocio, ya que el concepto es el mismo.

## Características ✨

- **Clientes**: CRUD de clientes suscritos al servicio.
- **Planes**: CRUD de planes disponibles en Xbox Game Pass.
- **Suscripciones**: CRUD de suscripciones de clientes a los planes de Xbox Game Pass.
- **Pagos**: CRUD de pagos realizados por los clientes.
- **Procedimientos Almacenados**: Uso de procedimientos almacenados para tomar decisiones y mostrar gráficos estadísticos en función de la DATA.

## Endpoints 🚀

### Clientes 👤

- **Obtener todos los clientes**
  - `GET /api/cliente/Listar`
  
- **Obtener un cliente por ID**
  - `GET /api/cliente/Listar/{id}`
  
- **Crear un nuevo cliente**
  - `POST /api/cliente/Insertar`
  
- **Actualizar un cliente**
  - `PUT /api/cliente/Actualizar}`
  
- **Eliminar un cliente**
  - `DELETE /api/cliente/Eliminar/{id}`

### Planes 📅

- **Obtener todos los planes**
  - `GET /api/plan/Listar`
  
- **Obtener un plan por ID**
  - `GET /api/plan/Listar/{id}`
  
- **Crear un nuevo plan**
  - `POST /api/plan/Insertar`
  
- **Actualizar un plan**
  - `PUT /api/plan/Actualizar`
  
- **Eliminar un plan**
  - `DELETE /api/plan/Eliminar/{id}`

### Suscripciones 📃

- **Obtener todas las suscripciones**
  - `GET /api/suscripcion/Listar`
  
- **Obtener una suscripción por ID**
  - `GET /api/suscripcion/Listar/{id}`
  
- **Crear una nueva suscripción**
  - `POST /api/suscripcion/Insertar`
  
- **Actualizar una suscripción**
  - `PUT /api/suscripcion/Actualizar`
  
- **Eliminar una suscripción**
  - `DELETE /api/suscripcion/Eliminar`

### Pagos 💳

- **Obtener todos los pagos**
  - `GET /api/pago/Listar`
  
- **Obtener un pago por ID**
  - `GET /api/pago/Listar/{id}`
  
- **Crear un nuevo pago**
  - `POST /api/pago/Insertar`
  
- **Actualizar un pago**
  - `PUT /api/pago/Actualizar`
  
- **Eliminar un pago**
  - `DELETE /api/pago/Eliminar/{id}`

## Procedimientos Almacenados 🗄️

 Uso de procedimientos almacenados para tomar decisiones y mostrar gráficos estadísticos en función de la DATA.

## Instalación 🛠️

1. Clona el repositorio xddd





