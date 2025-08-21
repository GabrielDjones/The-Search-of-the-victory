using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    DialogueTrigger dialogueTrigger;

    int clicks;
    [SerializeField] UnityEvent Teste;

    bool started;
    bool testeClose = true;
    void Start()
    {
        dialogueTrigger = FindAnyObjectByType(typeof(DialogueTrigger)) as DialogueTrigger;
    }
    void Update()
    {
       if(started == true && Input.GetKeyDown(KeyCode.E))
       {
          clicks++;
       }

       else if (testeClose == false && Input.GetKeyDown(KeyCode.E))
       {
          clicks++;
       }

       if (clicks > 2 && testeClose)
        {
            Teste.Invoke();
            testeClose = false;
            started = false;
        }
    }
    public void CloseWindow()
    {
        dialogueTrigger.Interact();
        started = true;
    }
}
