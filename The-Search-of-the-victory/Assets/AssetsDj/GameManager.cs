using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    DialogueTrigger dialogueTrigger;

    public  int clicks;

    [SerializeField] UnityEvent Teste;
    [SerializeField] UnityEvent escolhaDePista;

    bool started = false;
    bool pistaClose = true;
    bool testeClose = true;
    void Start()
    {
        dialogueTrigger = FindAnyObjectByType(typeof(DialogueTrigger)) as DialogueTrigger;
    }
    void Update()
    {
       if(started && Input.GetKeyDown(KeyCode.E))
       {
          clicks++;
       }

       if (testeClose == false && Input.GetKeyDown(KeyCode.E))
       {
            clicks++;
       }

       if (clicks == 4 && pistaClose == true)
       {
            escolhaDePista.Invoke();
            pistaClose = false;
            testeClose = true;
       }
              
       if (clicks == 2 && testeClose)
        {
            Teste.Invoke();
            started = false;
        }
    }
    public void CloseWindow()
    {
        dialogueTrigger.Interact();
        started = true;
    }
    public void TesteCloser()
    {
        testeClose = false;
    }
}
