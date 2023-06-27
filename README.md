## ----------------------"MUUUCHACHOS" CARNICERIA---------------------------
Realizado por Méndez Luca



![Imagen MUUUCHACHOS](https://github.com/Lucamendez25/SegundoParcial_Labo2D_2023_PrimerCuatri/assets/98615614/8547de93-9a18-458b-997a-bf71479f68d5)



  
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

![Anotación 2023-06-27 131540](https://github.com/Lucamendez25/SegundoParcial_Labo2D_2023_PrimerCuatri/assets/98615614/f5e8aed8-283d-48fc-a329-014babdfff5d)

![Anotación 2023-06-27 131559](https://github.com/Lucamendez25/SegundoParcial_Labo2D_2023_PrimerCuatri/assets/98615614/60e6c0f1-e587-4a30-a0b9-28d3f66c5a8b)

![Anotación 2023-06-27 131608](https://github.com/Lucamendez25/SegundoParcial_Labo2D_2023_PrimerCuatri/assets/98615614/d1f241c5-6495-408f-bf71-28d70167bf09)


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

![Anotación 2023-06-27 173341](https://github.com/Lucamendez25/SegundoParcial_Labo2D_2023_PrimerCuatri/assets/98615614/3a601c09-f9df-4a38-a059-4642c116b955)

# Cliente:
![Anotación 2023-06-27 164636 (2)](https://github.com/Lucamendez25/SegundoParcial_Labo2D_2023_PrimerCuatri/assets/98615614/244ea1a6-b195-4e35-888d-fa55582456ef)
![Anotación 2023-06-27 173415](https://github.com/Lucamendez25/SegundoParcial_Labo2D_2023_PrimerCuatri/assets/98615614/816826cd-e42c-4990-ab69-bfbdd82900cc)
![Anotación 2023-06-27 173427](https://github.com/Lucamendez25/SegundoParcial_Labo2D_2023_PrimerCuatri/assets/98615614/008fd042-f56f-48dd-8089-bc76144a433e)
![Anotación 2023-06-27 173444](https://github.com/Lucamendez25/SegundoParcial_Labo2D_2023_PrimerCuatri/assets/98615614/38148b2a-50cb-4263-bbdc-1e07daefa424)
# Vendedor:
![Anotación 2023-06-27 173504](https://github.com/Lucamendez25/SegundoParcial_Labo2D_2023_PrimerCuatri/assets/98615614/17ffc871-adfd-4c39-ad75-35eae8cb0532)
![Anotación 2023-06-27 173600](https://github.com/Lucamendez25/SegundoParcial_Labo2D_2023_PrimerCuatri/assets/98615614/a2e27370-b439-4894-8e54-3e65bcfd1ac8)
![Anotación 2023-06-27 173539](https://github.com/Lucamendez25/SegundoParcial_Labo2D_2023_PrimerCuatri/assets/98615614/8fc446a6-9971-4b28-bc0a-97230a3c7cce)
![Anotación 2023-06-27 173517](https://github.com/Lucamendez25/SegundoParcial_Labo2D_2023_PrimerCuatri/assets/98615614/30a3511b-5b9d-440a-a717-b1effc1b3f53)
![Anotación 2023-06-27 173614](https://github.com/Lucamendez25/SegundoParcial_Labo2D_2023_PrimerCuatri/assets/98615614/65dd3e74-93c2-4756-8fdd-ed72953f8787)

