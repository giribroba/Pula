﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cenario : MonoBehaviour
{
    [Header("Configurações")]
    [SerializeField] private GameObject plataforma, camera;
    [SerializeField] private float alturaMax, topoTela, tolerancia;
    private float aluraMinima = 1.9f;
    public float xMax;

    private GameObject ultimaPlataforma;

    void Start()
    {
        PrimeiroLayout();
    }

    void Update()
    {
        CriadorPlataformas(); 
    }

    private void PrimeiroLayout()
    {
        NovaPlataforma(new Vector2(Random.Range(-xMax,xMax), Random.Range(0.7f, alturaMax)));
    }

    private void CriadorPlataformas()
    {
        if (ultimaPlataforma.transform.position.y < camera.transform.position.y + tolerancia)
        {
            NovaPlataforma(new Vector2(Random.Range(-xMax, xMax), Random.Range(ultimaPlataforma.transform.position.y + aluraMinima, ultimaPlataforma.transform.position.y + alturaMax)));
        }
    }

    private void NovaPlataforma(Vector2 posicao)
    {
        ultimaPlataforma = Instantiate(plataforma, posicao, Quaternion.identity);
        ultimaPlataforma.GetComponent<Plataforma>().movel = Random.Range(1,7) == 1;

    }
}
