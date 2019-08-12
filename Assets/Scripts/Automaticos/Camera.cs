﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [Header("Objetos")]
    [SerializeField] private GameObject jogador;
    private Transform transformJogador; 

    [Header("Configurações")]
    [SerializeField] float suavidade;

    private float ySuavizada;

    private void Start()
    {
        transformJogador = jogador.transform;
    }

    private void FixedUpdate()
    {
        SeguirJogador();
    }

    private void SeguirJogador()
    {
        ySuavizada = Mathf.Lerp(this.transform.position.y, transformJogador.position.y + 2, suavidade);
        transform.position = new Vector3(this.transform.position.x, ySuavizada, this.transform.position.z);
    }
}