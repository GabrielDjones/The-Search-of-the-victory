using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    DialogueTrigger dialogueTrigger;
    int clicks;
    [SerializeField] UnityEvent Teste;

    bool started;
    void Start()
    {
        dialogueTrigger = FindAnyObjectByType(typeof(DialogueTrigger)) as DialogueTrigger;
    }

    // Update is called once per frame
    void Update()
    {
       if(started == true && Input.GetKeyDown(KeyCode.E) )
        {
            clicks++;
        }
        
       if ( clicks > 3) 
        {
          Teste.Invoke();
        }
    }
    public void CloseWindow()
    {
        dialogueTrigger.Interact();
        started = true;
    }
}
