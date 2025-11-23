using UnityEngine;

public class AreaMusicController : MonoBehaviour
{
    public AudioSource musica;

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            musica.Stop();
        }
    }
}