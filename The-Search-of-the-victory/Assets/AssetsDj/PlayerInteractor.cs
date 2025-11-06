using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInteractor : MonoBehaviour
{
    [SerializeField] UnityEvent cameraSwitch;

    [SerializeField] private Transform positionToTeleport;
    public Transform interactionPoint;
    public float interactionRadius = 0.8f;
    public LayerMask interactableLayer;

    DialogueTrigger dialogue;

    CafeteriaManager cafe;

    public GameObject cam;

    bool first = true;

    private void Start()
    {
        cafe = FindAnyObjectByType(typeof (CafeteriaManager)) as CafeteriaManager;
        dialogue = FindAnyObjectByType(typeof(DialogueTrigger)) as DialogueTrigger;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("apertou E");
            Collider2D hit = Physics2D.OverlapCircle(interactionPoint.position, interactionRadius, interactableLayer);
            DialogueTrigger2 trigger = hit.GetComponent<DialogueTrigger2>();
            if (trigger != null && first)
            {
                trigger.Interact();
                cafe.Policia();
                first = false;
            }
            else if (hit != null && hit.CompareTag("Teleporter"))
            {
                if (positionToTeleport != null && cam != null)
                {   
                    cameraSwitch.Invoke();
                    gameObject.SetActive(false);
                    dialogue.InteractHospital();
                    cafe.hospital();
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
