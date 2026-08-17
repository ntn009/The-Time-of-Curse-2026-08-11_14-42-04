using UnityEngine;
using UnityEngine.SceneManagement;

public class ColetaItem : MonoBehaviour
{
    [SerializeField] private GameObject canvas;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("COLISÃO DETECTADA COM: " + other.gameObject.name);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("COLISÃO NORMAL COM: " + collision.gameObject.name);
    }

    public void Entrar()
    {
        SceneManager.LoadScene(0);
    }
}
