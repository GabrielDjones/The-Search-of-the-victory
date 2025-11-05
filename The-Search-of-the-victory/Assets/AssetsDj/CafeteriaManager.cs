using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class CafeteriaManager : MonoBehaviour
{
    [SerializeField] TMP_Text CharName;
    DialogueTrigger dialogue;
    TextManager textManager;

    [SerializeField] Transform positionToTeleport;
    [SerializeField] Transform positionToTeleportCamera;

    [SerializeField] GameObject player;
    [SerializeField] GameObject Cam;

    [SerializeField] UnityEvent sceneSwitch;
   

    bool clicking;
    public int clicks;
    bool ended = false;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textManager = FindAnyObjectByType(typeof(TextManager)) as TextManager;
        dialogue = FindAnyObjectByType(typeof(DialogueTrigger)) as DialogueTrigger;
        dialogue.Interact();
        CharName.text = "Maia";
    }

    void Update()
    {

        NameManager();

        if ( Input.GetKeyDown(KeyCode.E) && clicking == false && ended == false)
        {
            clicks++;
        }

        if (clicks == 14)
        {
            ended = true;
        }

        if (ended == true)
        { 
            player.SetActive(true);
            sceneSwitch.Invoke();
            clicks = 20;
            Debug.Log("hospital");
        }

        if (clicks == 32)
        {
            player.SetActive(true);
            player.transform.position = positionToTeleport.position;
            Cam.transform.position = positionToTeleportCamera.position; 
            ended = false;
            Debug.Log("polical");
        }
    }

    public void SkipText(bool x)
    {
       clicking = x;
    }

    public void hospital()
    {
        ended = false;
    }

    private void NameManager()
    {
        if (clicks == 3) CharName.text = "Isaac";

        if (clicks == 5) CharName.text = "Maia";

        if (clicks == 7) CharName.text = "Diego";

        if (clicks == 8) CharName.text = "Isaac";

        if (clicks == 11) CharName.text = "Diego";

        if (clicks == 12) CharName.text = "Isaac";

        if (clicks == 13) CharName.text = "Maia";
        //---------------------------------------//
        if (clicks == 21) CharName.text = "Maria da Penha";
        if (clicks == 22) CharName.text = "Maia";
        if (clicks == 25) CharName.text = "Maria da Penha";
        if (clicks == 27) CharName.text = "Maia";
        if (clicks == 28) CharName.text = "Maria da Penha";
        if (clicks == 29) CharName.text = "Maia";
        if (clicks == 30) CharName.text = "Maria da Penha";
        if (clicks == 31) CharName.text = "Maia";
    }
}
