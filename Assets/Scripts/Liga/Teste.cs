using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{
    [SerializeField] private LayerMask tabela;
    private Vector2 posição;

    void Update()
    {
        posição = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

}
