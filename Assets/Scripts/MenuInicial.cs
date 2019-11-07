using UnityEngine;

public class MenuInicial : MonoBehaviour
{
    public void ChamaHistoria(string cena)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(cena);
    }
}
