using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelinhasScript : MonoBehaviour
{
    public IEnumerator Desce(string tela)
    {
        this.transform.GetChild(0).gameObject.SetActive(tela == "over");
        this.transform.GetChild(1).gameObject.SetActive(!(tela == "over"));
        this.GetComponent<Animator>().SetTrigger("desce");
        yield return new WaitForSeconds(1);
        Time.timeScale = 0;
    }
}
