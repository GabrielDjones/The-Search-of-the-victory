using UnityEngine;
using UnityEngine.Events;

public class PlayerInteractor : MonoBehaviour
{
    [SerializeField] UnityEvent cameraSwitch;

    [SerializeField] private Transform positionToTeleport;
    public Transform interactionPoint;
    public float interactionRadius = 0.5f;
    public LayerMask interactableLayer;

    public GameObject cam;
    
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
                if (positionToTeleport != null)
                {
                    cameraSwitch.Invoke();
                    gameObject.transform.position = positionToTeleport.position;
                    cam.transform.position = positionToTeleport.position;
                }
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
