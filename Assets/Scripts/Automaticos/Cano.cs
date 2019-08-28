 using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cano : MonoBehaviour
{
    private GameObject diamante;
    
    void Start()
    {
        this.gameObject.SetActive(Random.Range(1,8) == 1);   
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
