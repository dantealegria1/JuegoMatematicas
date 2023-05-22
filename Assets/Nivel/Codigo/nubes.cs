using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nubes : MonoBehaviour
{
    public float velocidad = 0.3f;
    public Vector3 posicionInicial;
    public Vector3 posicionFinal;
    
    private bool moviendoseDerecha = true;
    public GameObject nubecita;

    void Start()
    {
        // Guarda la posici�n inicial de la imagen
        posicionInicial = transform.position;
        nubecita.transform.position = posicionInicial;
    }

    void Update()
    {
        // Mueve la imagen hacia la derecha
        if (moviendoseDerecha)
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
            // Verifica si ha alcanzado la posici�n final
            if (transform.position.x >= posicionFinal.x)
            {
                moviendoseDerecha = false;
            }
        }
        // Regresa la imagen a la posici�n inicial
        else
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
            // Verifica si ha alcanzado la posici�n inicial
            if (transform.position.x <= posicionInicial.x)
            {
                moviendoseDerecha = true;
            }
        }
    }
}
