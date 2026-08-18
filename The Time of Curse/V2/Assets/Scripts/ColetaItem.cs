using UnityEngine;
using UnityEngine.SceneManagement;

public class ColetarItem : MonoBehaviour
{
    public GameObject canvas; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            canvas.SetActive(true);

        }
    }

      public void TelaInicial()
    {
        SceneManager.LoadScene(0);
    }


}