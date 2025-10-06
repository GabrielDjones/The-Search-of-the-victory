using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    

    DialogueTrigger2 dialogueTrigger;
    TextManager textManager;
    public  int clicks;

    [SerializeField] UnityEvent TesteEvent;
    [SerializeField] UnityEvent escolhaDePistaEvent;
    [SerializeField] UnityEvent sapatoEvent;

    bool started = false;
    bool pistaClose = true;
    bool testeClose = true;
    bool sapatoClose = true;
    bool clicking;
    void Start()
    {
        dialogueTrigger = FindAnyObjectByType(typeof(DialogueTrigger2)) as DialogueTrigger2;
        textManager = FindAnyObjectByType(typeof (TextManager)) as TextManager;
    }
    void Update()
    {
       
       if(started && Input.GetKeyDown(KeyCode.E) && clicking == false)
       {
          clicks++;
       }

       if (clicks == 3 && testeClose == true)
       {
            TesteEvent.Invoke();
            started = false;
            testeClose = false;
       }

       if (clicks == 4 && pistaClose)
       {
            escolhaDePistaEvent.Invoke();
            pistaClose = false;
            started = false;
       }
              
       if(clicks == 6 && sapatoClose)
       {
            sapatoEvent.Invoke();
            sapatoClose = false;
            started = false;
       }

    }
    public void Typing(bool x)
    {
        clicking = x;
    }

    public void CloseWindow()
    {
        dialogueTrigger.Interact();
        started = true;
    }
    public void TesteCloser()
    {
        started = true;
    }
}
