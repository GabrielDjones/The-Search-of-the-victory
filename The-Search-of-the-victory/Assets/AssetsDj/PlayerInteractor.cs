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
    GameManagerPolicial policial;

    public GameObject cam;
    public GameObject player;

    bool first = true;

    private void Start()
    {
        policial = FindAnyObjectByType(typeof(GameManagerPolicial)) as GameManagerPolicial;
        cafe = FindAnyObjectByType(typeof (CafeteriaManager)) as CafeteriaManager;
        dialogue = FindAnyObjectByType(typeof(DialogueTrigger)) as DialogueTrigger;
    }

    void Update()
    {
        Collider2D hit = Physics2D.OverlapCircle(interactionPoint.position, interactionRadius);

        DialogueTrigger2 trigger = hit.GetComponent<DialogueTrigger2>();
        WalkingCode walk = player.GetComponent<WalkingCode>();
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("apertou E");

            if (hit.CompareTag("Policial"))
            {
                    Debug.Log("interagiu2");
                    trigger.Interact();
                    first = false;
                    if (cafe != null) cafe.Policia();
                    if (policial != null) policial.PolicialInteract();
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
            else if ( hit.CompareTag("Carac"))
            {
                trigger.Carac();             
                Debug.Log("carac");
            }
            else if ( hit.CompareTag("Ycaro"))
            {
                trigger.Ycaro();
                Debug.Log("ycaro");
            }
            else if (hit.CompareTag("Luka"))
            {
                trigger.Luka();
                Debug.Log("luka");
            }
            else if (hit.CompareTag("Patricia"))
            {
                trigger.Patricia();
                Debug.Log("patricia");
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
