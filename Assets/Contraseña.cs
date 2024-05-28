using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contraseña : MonoBehaviour
{
    //Cuando el usuario presione el boton
    //aceptan se debe escribir un mensaje en la consola
    //si el texto de InputPassword coincide con la contraseña predeterminada
    //escribir "Acces Granted"
    //sino escribir "Acces Denied"

    public InputField ingreseContraseña;
    public string password = "uriel";

    void Start()
    {

    }


    void Update()
    {

    }

    public void contraseña()

    {
        if(ingreseContraseña.text == password)
        {
            Debug.Log("Acces Granted");
        }
        else
        {
            Debug.Log("Acces Denied");
        }

    }
}
