using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    

    DialogueTrigger2 dialogueTrigger;
    TextManager textManager;
    public  int clicks;

    [SerializeField] UnityEvent TesteEvent;
    [SerializeField] UnityEvent escolhaDePistaEvent;
    [SerializeField] UnityEvent sapatoEvent;
    [SerializeField] UnityEvent respostaEvent;
    [SerializeField] UnityEvent armaEvent;
    [SerializeField] UnityEvent banheiraEvent;
    [SerializeField] UnityEvent sangueEvent;

    bool started = false;
    bool pistaClose = true;
    bool testeClose = true;
    bool sapatoClose = true;
    bool resposta = true;
    bool arma = true;
    bool banheira = true;
    bool sangue = true;
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

       if (clicks == 10 && testeClose)
       {
            TesteEvent.Invoke();
            started = false;
            testeClose = false;
       }

       if (clicks == 12 && pistaClose)
       {
            escolhaDePistaEvent.Invoke();
            pistaClose = false;
            started = false;
       }
              
       if(clicks == 14 && sapatoClose)
       {
            sapatoEvent.Invoke();
            sapatoClose = false;
            started = false;
       }
       if(clicks == 18 && resposta)
       {
            respostaEvent.Invoke();
            resposta = false;
            started =false;
       }
       if(clicks == 22 && arma)
       {
            armaEvent.Invoke();
            arma = false;
            started = false;
       }
       if (clicks == 27 && banheira)
       {
            banheiraEvent.Invoke();
            banheira = false;
            started = false;
       }
       if( clicks == 31 && sangue)
       {
            sangueEvent.Invoke();
            sangue = false;
            started = false;
       }
       if (clicks == 38)
       {
           SceneManager.LoadScene("Victory");
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
