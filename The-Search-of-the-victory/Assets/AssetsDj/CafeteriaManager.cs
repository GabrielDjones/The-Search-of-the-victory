using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class CafeteriaManager : MonoBehaviour
{
    [SerializeField] TMP_Text CharName;
    DialogueTrigger dialogue;
    TextManager textManager;

    [SerializeField] GameObject player;

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

        if (clicks == 15)
        {
            ended = true;
        }

        if (ended == true)
        {
            player.SetActive(true);
            sceneSwitch.Invoke();
        }
    }

    public void SkipText(bool x)
    {
       clicking = x;
    }

    private void NameManager()
    {
        if (clicks == 3) CharName.text = "Isaac";

        if (clicks == 5) CharName.text = "Maia";

        if (clicks == 8) CharName.text = "Diego";

        if (clicks == 9) CharName.text = "Isaac";

        if (clicks == 12) CharName.text = "Diego";

        if (clicks == 13) CharName.text = "Isaac";

        if (clicks == 14) CharName.text = "Maia";

    }
}
