using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    public GameObject jugador;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - jugador.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LateUpdate()
    {
        //Actualizo la posición de la cámara
        transform.position = jugador.transform.position + offset;
    }

}
