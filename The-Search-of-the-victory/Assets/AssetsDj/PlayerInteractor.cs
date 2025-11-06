using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayerInteractor : MonoBehaviour
{
    [SerializeField] UnityEvent cameraSwitch;

    [SerializeField] private Transform positionToTeleport;

    public Transform interactionPoint;
    public float interactionRadius = 0.8f;
    public LayerMask interactableLayer;

    DialogueTrigger2 dialogue;
    CafeteriaManager cafe;
    GameManagerPolicial policial;

    public GameObject Cam;
    public GameObject player;

    DialogueTrigger trigger;


    bool first = true;
    bool carac = true;
    bool ycaro = true;
    bool patricia = true;
    bool luka = true;
    bool policialExit = false;
    public string sceneName;

    public int hints;
    private void Start()
    {
        policial = FindAnyObjectByType(typeof(GameManagerPolicial)) as GameManagerPolicial;
        cafe = FindAnyObjectByType(typeof (CafeteriaManager)) as CafeteriaManager;
        dialogue = FindAnyObjectByType(typeof(DialogueTrigger2)) as DialogueTrigger2;
        trigger = FindAnyObjectByType(typeof(DialogueTrigger)) as DialogueTrigger;
    }

    void Update()
    {
        if (hints == 10)
        {
            SceneManager.LoadScene(sceneName);
        }
        Collider2D hit = Physics2D.OverlapCircle(interactionPoint.position, interactionRadius,interactableLayer);

        WalkingCode walk = player.GetComponent<WalkingCode>();
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("apertou E");

            if (hit.gameObject.CompareTag("Policial") && first == true)
            {
                first = false;
                if (cafe != null)
                {
                    cafe.Policia();
                    trigger.InteractPolicial();
                }

                if (policial != null)
                {
                    dialogue.Interact();
                    walk.canMove = false;
                    policialExit = true;
                }
            }
            
            else if (hit != null && hit.CompareTag("Teleporter"))
            {
                if (positionToTeleport != null && Cam != null)
                {  
                    
                    cameraSwitch.Invoke();
                    gameObject.SetActive(false);
                    cafe.hospital();
                    trigger.InteractHospital();
                    Cam.transform.position = positionToTeleport.position;

                }
            }
            else if ( hit.CompareTag("Carac") && carac)
            {
               carac =false;
               dialogue.Carac();
               Debug.Log("carac");
               walk.canMove = false;
            }
            else if ( hit.CompareTag("Ycaro") && ycaro)
            {
                ycaro = false;
                dialogue.Ycaro();
                Debug.Log("ycaro");
                walk.canMove = false;
            }
            else if (hit.CompareTag("Luka") && luka)
            {
                luka = false;
                dialogue.Luka();
                Debug.Log("luka");
                walk.canMove = false;
            }
            else if (hit.CompareTag("Patricia") && patricia)
            {
                patricia = false;
                dialogue.Patricia();
                Debug.Log("patricia");
                walk.canMove = false;
            }

        }
    }

    public void PolicialExit()
    {
        WalkingCode walk = player.GetComponent<WalkingCode>();
        if (policialExit)
        {
            policialExit = false;
            CameraController2D cam = Cam.GetComponent<CameraController2D>();
            player.transform.position = positionToTeleport.position;
            walk.canMove = false;
            dialogue.Think();
            cam.enabled = true;
        }
        if (!carac)
        {
            hints++;
        }
        if (!ycaro)
        {
            hints++;
        }
        if (!luka) 
        {
            hints++;
        }
        if (!patricia)
        {
            hints++;
        }
        else return;
    }


    void OnDrawGizmosSelected()
    {
        if (interactionPoint != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(interactionPoint.position, interactionRadius);
        }
    }
}
