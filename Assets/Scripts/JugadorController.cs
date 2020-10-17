﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class JugadorController : MonoBehaviour
{
    private Rigidbody rb;
    private int contador;
    public float velocidad;

    public Text textoContador, textoGanar;
    // Use this for initialization
    void Start()
    {
        //Capturo esa variable al iniciar el juego
        rb = GetComponent<Rigidbody>();
        contador = 0;

        setTextoContador();
        //Inicio el texto de ganar a vacío
        textoGanar.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
  
        float movimientoH = Input.GetAxis("Horizontal");
        float movimientoV = Input.GetAxis("Vertical");


        Vector3 movimiento = new Vector3(movimientoH, 0.0f, movimientoV);
        //Asigno ese movimiento o desplazamiento a mi RigidBody
        rb.AddForce(movimiento * velocidad);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coleccionable"))
        {
            other.gameObject.SetActive(false);
            contador += 1;
            setTextoContador();



        }


    }
    void setTextoContador()
    {
        textoContador.text = "Contador: " + contador.ToString();
        if (contador >= 12)
        {
            textoGanar.text = "¡Ganaste!";
        }
    }


}
