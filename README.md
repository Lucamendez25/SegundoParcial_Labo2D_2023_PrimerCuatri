## ----------------------"MUUUCHACHOS" CARNICERIA---------------------------
Realizado por Méndez Luca


![Imagen MUUUCHACHOS](https://github.com/Lucamendez25/SegundoParcial_Labo2D_2023_PrimerCuatri/assets/98615614/e9f25f65-6c7d-4ae6-9388-a6d4265f28da)


  
</div>


## Acerca del Proyecto
Este proyecto es el Segundo Trabajo Práctico mandado por el Profesor Felipe Bustos Gil Y Lucas Ferrino para el 2do Cuatrimestre
de Laboratorio. Es una mejora del Primer Trabajo, ya que se trataba de el mismo tema, la carniceria, pero incorporando los últimos temas
vistos en la cursada.
Ya que hace menos de un año, la selección Argentina de Fútbol salió campeona del Mundo, elegí una temática con respecto a eso.

## Tabla de contenidos:
---
- [Interfaces y Generics](#Interfaces-y-Generics)
- [Serialización](#Serialización)
- [Escritura de archivos](#Escritura-de-archivos)
- [Manejo de excepciones](#Manejo-de-excepciones)
- [SQL](#SQL)
- [Unit Testing](#Unit-Testing)
- [Delegados](#Delegados)
- [Task](#Task)
- [Eventos](#Eventos)
- [Imágenes](#Imágenes)

## Interfaces y Generics
---
Utilizo interfaces con generics para poder tener serializadores que me permitan manejar distintas tipos de objetos.
La interfaz en si obliga a los serializadores(xml y json) a desarollar el metodo para serializar y para deserializar, ya que ambos 
tienen distinta manera de hacerlo.

```bash
public interface ISerializador<T> where T : class , new()
{
    public bool Serializar(T obj);
    public T Deserializar();
}

public class SerializadorXml<T> : ISerializador<T> where T : class, new()

public class SerializadorJson<T> : ISerializador<T> where T : class, new()

private SerializadorJson<List<Producto>> serializadorJson = new SerializadorJson<List<Producto>>("Productos.json");
private SerializadorXml<List<Producto>> serializadorXml = new SerializadorXml<List<Producto>>("Productos.xml");
```
 
## Serialización
---
Utilice Json y Xml.
El vendedor puede guardar todos los productos en los dos tipos de archivos, en el Form Heladera
cuando el desee.

## Escritura de archivos
---
Cada cliente, cuando realice una compra se le generar un archivo ".txt". Donde se guardaran todas las compras 
que haya realizado. El vendedor cuando quiera, todas esas compras que haya realizado el Cliente

## Manejo de excepciones
---
Donde mas utilize es en la clase Acceso de datos, la cual se encarga de trabajar con la base de datos y en cada cosa que hago manejo cualquier excepcion 
que se pueda producir.
Además, esta implementado en la mayoria de los forms para poder informar, si hay stock del producto solicitado, sino tiene dinero para efectuar la compra, etc.

## SQL
---
En la base de datos fue donde más empeño puse, ya que necesitaba buenas relaciones para que el manejo sea mucho mas efectivo y no haya campos en NULL.
Utilice 7 tablas:

- Usuarios (Almaceno toda informacion de los Usuarios)
- Roles (Esta tabla nos sirve para poder saber si el Usuario es un Vendedor o un CLiente), se relaciona con la tabla Usuarios.
- Dinero Clientes (Almaceno el Id y el dinero que tiene el usuario en ese Id)
- Ventas Vendedor (Almaceno el Id y las ventas realizadas por el usuario en ese Id)
- Productos (Almaceno toda la informacion que tienen los productos)
- Stock Productos (Almaceno el stock del producto, mediante el Codigo del Producto)
- Publicidad (Almaceno los path de las publicidades)

![Anotación 2023-06-27 131540](https://github.com/Lucamendez25/SegundoParcial_Labo2D_2023_PrimerCuatri/assets/98615614/5a6e50c5-daf0-4103-8dc1-516c4cb71a5d)
![Anotación 2023-06-27 131608](https://github.com/Lucamendez25/SegundoParcial_Labo2D_2023_PrimerCuatri/assets/98615614/b6d37150-a14a-410e-9acf-f735269d0caf)
![Anotación 2023-06-27 131559](https://github.com/Lucamendez25/SegundoParcial_Labo2D_2023_PrimerCuatri/assets/98615614/23fc6e00-8d9d-433e-851f-99dd6b522f20)


## Unit Testing
---
Lo utilice para testear codigo que podria llegar a generar problemas.

## Delegados
---
Utilice delegados, para no tener que estar repitiendo codigo, como por ejemplo, cuando creo ciertos Forms
que lo que hacen son informar que es lo que paso en determinado proceso.

## Task
---
Utilice tasks para ejecutar las publicidades en el form venta en segundo plano automáticamente 
y el flujo de ejecución del programa no se bloqueé.

## Eventos
---
Genero un evento para que pueda modifcar, el picture box, los datos de la publicidad (el path)
```bash
ejemplo :
    public class ProovedorPublicidad
    {
        public event Action<Publicidad> PublicidadCambio;

        public void GenerarPublicidad(Publicidad publicidad)
        {
            PublicidadCambio?.Invoke(publicidad);
        }
    }
```
## Imágenes
# Login:
---

![Anotación 2023-06-27 173341](https://github.com/Lucamendez25/SegundoParcial_Labo2D_2023_PrimerCuatri/assets/98615614/2bf84c4f-b4e0-476c-9b00-1e9300ff921b)


# Cliente:
![Anotación 2023-06-27 164636 (2)](https://github.com/Lucamendez25/SegundoParcial_Labo2D_2023_PrimerCuatri/assets/98615614/e2fe2b56-f9ba-4545-bccc-c5cba9e5b48a)
![Anotación 2023-06-27 173415](https://github.com/Lucamendez25/SegundoParcial_Labo2D_2023_PrimerCuatri/assets/98615614/d4fcc690-3b99-4fce-a7d5-a47f8271a3b7)
![Anotación 2023-06-27 173427](https://github.com/Lucamendez25/SegundoParcial_Labo2D_2023_PrimerCuatri/assets/98615614/d93a2170-de8a-4fad-ac57-184e1acd0a88)
![Anotación 2023-06-27 173444](https://github.com/Lucamendez25/SegundoParcial_Labo2D_2023_PrimerCuatri/assets/98615614/da517c26-d1b9-48dc-84c4-dea1fdddf65b)




# Vendedor:
![Anotación 2023-06-27 173504](https://github.com/Lucamendez25/SegundoParcial_Labo2D_2023_PrimerCuatri/assets/98615614/052fcf68-4587-4e86-9918-782b17617910)
![Anotación 2023-06-27 173600](https://github.com/Lucamendez25/SegundoParcial_Labo2D_2023_PrimerCuatri/assets/98615614/deb92e5b-a0c4-471e-b780-0b46a69b2b8e)
![Anotación 2023-06-27 173539](https://github.com/Lucamendez25/SegundoParcial_Labo2D_2023_PrimerCuatri/assets/98615614/5db21b4d-b0d9-4b5e-a4fa-9e5e825e64c9)
![Anotación 2023-06-27 173517](https://github.com/Lucamendez25/SegundoParcial_Labo2D_2023_PrimerCuatri/assets/98615614/97bd78e9-a068-48b3-8591-ab5e1fc471de)
![Anotación 2023-06-27 173614](https://github.com/Lucamendez25/SegundoParcial_Labo2D_2023_PrimerCuatri/assets/98615614/a263caeb-43ad-47b5-a595-5d370b7b9d4b)


