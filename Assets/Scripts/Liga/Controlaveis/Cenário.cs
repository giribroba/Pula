using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cenário : MonoBehaviour
{
    [SerializeField] float velocidade;
    [SerializeField] float camMaxX;
    void Update()
    {
        if (Input.touchCount == 2 && Mathf.Abs(Camera.main.transform.position.x) <= camMaxX)
        {
            Camera.main.transform.Translate(Vector2.left * Input.touches[0].deltaPosition.x * velocidade * Time.deltaTime);
        }
        if (Mathf.Abs(Camera.main.transform.position.x) > camMaxX)
        {
            Camera.main.transform.position = new Vector3((Camera.main.transform.position.x < 0? -camMaxX : camMaxX), Camera.main.transform.position.y, Camera.main.transform.position.z);
        }
    }
}
