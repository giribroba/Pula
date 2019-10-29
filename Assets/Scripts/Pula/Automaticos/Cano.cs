 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Cano : MonoBehaviour
{
    [SerializeField] Text contador;
    private GameObject diamante;
    [SerializeField] private int pontuação = 1;
    public static int Conta;
    void Start()
    {
        contador = GameObject.FindWithTag("Contador").GetComponent<Text>();
        this.gameObject.SetActive(Random.Range(1,5) == 1);   
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            contador.text = (int.Parse(contador.text) + pontuação).ToString();
            Destroy(this.gameObject);
        }
    }
}
