using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceInvaders
{
    // Toda la esctructura se basa en el polimorfismo !!!!INVESTIGAR!!!!!
    internal class GameObjectManager
    {
        // contenedor lista, vector para guardar putneros de gameObjects

        void AddGameObjet(ref GameObject gameObject)
        {
            //Añade el punto de la clase a la lista
        }

        void RemoveGameObjet(ref GameObject gameObject)
        {
            //Quita el punto de la clase de la lista
        }

        void Initialize()
        {
            // Llama al initialize de todos los gameObject que estan en la lista
            // Como son metodos virtuales llaman al especifico de la clase (polimorfismo)
        }

        void Update()
        {
            // Llama al update de todos los gameObject que estan en la lista
            // Como son metodos virtuales llaman al especifico de la clase (polimorfismo)
        }
    }
}
