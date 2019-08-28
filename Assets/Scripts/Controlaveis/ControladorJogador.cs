using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJogador : MonoBehaviour
{
    [Header("Controle")]
    [SerializeField] private float velocidade;
    [SerializeField] private float xMax;
    private float horizontalInput, acelerometroInput;

    private Rigidbody2D rbJogador;

    private void Start()
    {
        rbJogador = this.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Inputs();
    }

    private void FixedUpdate()
    {
        hMovimento();
    }

    /// <summary>
    /// Controla os movimentos do jogador
    /// </summary>
    private void Inputs()
    {
        Limite();
#if UNITY_STANDALONE || UNITY_EDITOR
        //Teclado
        horizontalInput = Input.GetAxis("Horizontal");
#elif UNITY_ANDROID
         //Acelerometro
        acelerometroInput = Input.acceleration.x;

#endif
    }

    /// <summary>
    /// Leva o personagem ao outro lado da tela
    /// </summary>
    private void Limite()
    {
        if (Mathf.Abs(this.transform.position.x) >= xMax)
        {
            this.transform.position = new Vector2(((this.transform.position.x > 0)? -1: 1) * (xMax - 0.2f), transform.position.y);
        }
    }

    /// <summary>
    /// Movimento horizontal do personagem
    /// </summary>
    private void hMovimento()
    {
#if UNITY_STANDALONE || UNITY_EDITOR
        //movimento por teclado
        rbJogador.velocity = new Vector2(horizontalInput * velocidade, rbJogador.velocity.y);
#elif UNITY_ANDROID
        //Movimento por acelerometro
        rbJogador.velocity = new Vector2(acelerometroInput * velocidade * 1.5f, rbJogador.velocity.y);
#endif
    }
}
