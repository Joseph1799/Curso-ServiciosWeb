# API de Carros

Esta API en C# permite realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) sobre la entidad Carro. Los métodos GET y POST están implementados para listar carros y guardar un nuevo carro respectivamente.

## Métodos

### Listar Carros
- **URL:** `/Carro/listarCarros`
- **Método:** GET
- **Descripción:** Retorna una lista de carros en formato JSON.
- **Ejemplo de respuesta:**
  ```json
  [
    {
      "id": "1",
      "marca": "Toyota",
      "modelo": "Camry",
      "anio": "2016",
      "color": "Gris"
    },
    {
      "id": "2",
      "marca": "Honda",
      "modelo": "Civic",
      "anio": "2018",
      "color": "Rojo"
    },
    {
      "id": "3",
      "marca": "Hyundai",
      "modelo": "Tucson",
      "anio": "2014",
      "color": "Blanco"
    }
  ]
  ```

### Guardar Carro
- **URL:** `/Carro/guardarCarro`
- **Método:** POST
- **Descripción:** Guarda un nuevo carro y retorna un mensaje de éxito junto con el objeto carro guardado.
- **Parámetros:** El objeto Carro en el cuerpo de la solicitud.
- **Ejemplo de solicitud:**
  ```json
  {
    "id": "4",
    "marca": "Ford",
    "modelo": "Fiesta",
    "anio": "2020",
    "color": "Azul"
  }
  ```
- **Ejemplo de respuesta:**
  ```json
  {
    "success": true,
    "message": "Carro guardado",
    "Results": {
      "id": "4",
      "marca": "Ford",
      "modelo": "Fiesta",
      "anio": "2020",
      "color": "Azul"
    }
  }
  ```

## Documentación con Swagger
La API cuenta con documentación automática generada por Swagger. Puedes acceder a ella ingresando a `/swagger/index.html` una vez que la API esté en ejecución.

## Requisitos para ejecutar la API

Para ejecutar esta API en tu entorno local, necesitarás tener instalado lo siguiente:

- **Visual Studio:** Para compilar y ejecutar la aplicación web en C#.
- **.NET Core SDK:** Necesario para compilar y ejecutar la aplicación .NET Core.
- **Postman (opcional):** Para probar los endpoints de la API una vez que esté en ejecución.

## Instrucciones de ejecución

1. Clona o descarga el repositorio en tu máquina local.
2. Abre el proyecto en Visual Studio.
3. Compila la solución para asegurarte de que no haya errores de compilación.
4. Ejecuta la aplicación. Esto iniciará un servidor local y la API estará disponible en la dirección `http://localhost:puerto/`, donde `puerto` es el número de puerto que utilice tu aplicación.

Una vez que la aplicación esté en ejecución, puedes usar Postman u otra herramienta similar para probar los endpoints de la API y verificar su funcionamiento.

