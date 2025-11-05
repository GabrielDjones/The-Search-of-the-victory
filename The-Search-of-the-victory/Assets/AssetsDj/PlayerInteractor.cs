using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInteractor : MonoBehaviour
{
    [SerializeField] UnityEvent cameraSwitch;

    [SerializeField] private Transform positionToTeleport;
    public Transform interactionPoint;
    public float interactionRadius = 0.5f;
    public LayerMask interactableLayer;


    DialogueTrigger dialogue;

    CafeteriaManager cafe;

    public GameObject cam;

    private void Start()
    {
        cafe = FindAnyObjectByType(typeof (CafeteriaManager)) as CafeteriaManager;
        dialogue = FindAnyObjectByType(typeof(DialogueTrigger)) as DialogueTrigger;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Collider2D hit = Physics2D.OverlapCircle(interactionPoint.position, interactionRadius, interactableLayer);
5           if (hit != null && hit.CompareTag("policial"))
            {
                dialogue.InteractPolicial();
                Debug.Log("conversa com policial");
            }
            if (hit != null && hit.CompareTag("Teleporter"))
            {
                if (positionToTeleport != null)
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
