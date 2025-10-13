using UnityEngine;

public class PlayerInteractor : MonoBehaviour
{

    [SerializeField] private Transform positionToRespawn;
    public Transform interactionPoint;
    public float interactionRadius = 0.5f;
    public LayerMask interactableLayer;

    public GameObject player;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Collider2D hit = Physics2D.OverlapCircle(interactionPoint.position, interactionRadius, interactableLayer);
            if (hit != null)
            {
                DialogueTrigger trigger = hit.GetComponent<DialogueTrigger>();
                if (trigger != null)
                {
                    trigger.Interact();
                }
            }
            if (hit != null && hit.CompareTag("Teleporter"))
            {
                if (positionToRespawn != null) gameObject.transform.position = positionToRespawn.position; player.SetActive(false);
            }
        }
    }
  
    void OnDrawGizmosSelected()
    {
        if (interactionPoint != null)
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawWireSphere(interactionPoint.position, interactionRadius);
        }
    }
}
