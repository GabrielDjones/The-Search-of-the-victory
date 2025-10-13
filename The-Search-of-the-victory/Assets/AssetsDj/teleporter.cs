 using UnityEngine;

public class teleporter : MonoBehaviour
{
    [SerializeField] private Transform positionToRespawn;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Teleporter") && Input.GetKeyDown(KeyCode.E))
        {
           gameObject.transform.position = positionToRespawn.position;
        }
    }

}
