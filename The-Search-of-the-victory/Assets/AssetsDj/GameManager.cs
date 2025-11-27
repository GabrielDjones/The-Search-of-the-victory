using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public List<Sprite> sprites = new List<Sprite> { };

    List<int> maia = new List<int> {2,5,7,21,23,25,30,34,36};
    List<int> costa = new List<int> { 3, 18, 19, 20, 22, 27, 28, 32, 37, 39 };

    public Image personagem1;
    public Image personagem2;

    public Sprite maiatalk;
    public Sprite maiashy;
    public Sprite maiawworried;
    public Sprite maiaquiet;
    public Sprite maiaangry;

    public Sprite costadispleased;
    public Sprite costapleased;
    public Sprite costatalk;
    public Sprite costatalkangry;
    public Sprite costazombando;
    public Sprite costachallenging;


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
        ImageSwitch();
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

       //_______________//

        if (clicks == 1)
        {
            personagem1.sprite = maiatalk;
            personagem2.sprite = costapleased;
        }
        if (clicks == 2)
        {
            personagem1.sprite = maiaquiet;
            personagem2.sprite = costatalk;
        }
        if (clicks == 3)
        {
            personagem1.sprite = maiaquiet;
            personagem2.sprite = costapleased;
        }
        if (clicks == 4)
        {
            personagem1.sprite = maiatalk;
            personagem2.sprite = costapleased;
        }
        if (clicks == 5)
        {
            personagem1.sprite = maiaquiet;
            personagem2.sprite = costapleased;
        }
        if (clicks == 6)
        {
            personagem1.sprite = maiawworried;
            personagem2.sprite = costapleased;
        }
        if (clicks == 7)
        {
            personagem1.sprite = maiaquiet;
            personagem2.sprite = costapleased;
        }
        if (clicks == 17)
        {
            personagem1.sprite = maiaquiet;
            personagem2.sprite = costazombando;
        }

        if (clicks == 18)
        {
            personagem1.sprite = maiaquiet;
            personagem2.sprite = costadispleased;
        }

        if (clicks == 19)
        {
            personagem1.sprite = maiaquiet;
            personagem2.sprite = costatalkangry;
        }
        if (clicks == 20)
        {
            personagem1.sprite = maiaangry;
            personagem2.sprite = costadispleased;
        }
        if (clicks == 21)
        {
            personagem1.sprite = maiaquiet;
            personagem2.sprite = costatalkangry;
        }

        if (clicks == 22)
        {
            personagem1.sprite = maiatalk;
            personagem2.sprite = costadispleased;
        }

        if (clicks == 23)
        {
            personagem1.sprite = maiaquiet;
            personagem2.sprite = costadispleased;
        }

        if (clicks == 21)
        {
            personagem1.sprite = maiaquiet;
            personagem2.sprite = costatalkangry;
        }

        if (clicks == 24)
        {
            personagem1.sprite = maiaquiet;
            personagem2.sprite = costatalkangry;
        }

        if (clicks == 26)
        {
            personagem1.sprite = maiaquiet;
            personagem2.sprite = costapleased;
        }
        if (clicks == 27)
        {
            personagem1.sprite = maiawworried;
            personagem2.sprite = costapleased;
        }
        if (clicks == 28)
        {
            personagem1.sprite = maiaquiet;
            personagem2.sprite = costapleased;
        }

        if (clicks == 30)
        {
            personagem1.sprite = maiaquiet;
            personagem2.sprite = costadispleased;
        }

        if (clicks == 31)
        {
            personagem1.sprite = maiatalk;
            personagem2.sprite = costapleased;
        }

        if (clicks == 32)
        {
            personagem1.sprite = maiaquiet;
            personagem2.sprite = costapleased;
        }

        if (clicks == 33)
        {
            personagem1.sprite = maiatalk;
            personagem2.sprite = costadispleased;
        }
        if (clicks == 34)
        {
            personagem1.sprite = maiaquiet;
            personagem2.sprite = costatalkangry;
        }
        if (clicks == 35)
        {
            personagem1.sprite = maiaquiet;
            personagem2.sprite = costadispleased;
        }
        if (clicks == 37)
        {
            personagem1.sprite = maiaquiet;
            personagem2.sprite = costatalkangry;
        }

    }

  

    public void ImageSwitch()
    {

        if (maia.Contains(clicks))
        {
            personagem1.sprite = sprites[2];
        }
        else
        {
            personagem1.sprite = sprites[3];
        }

        if (costa.Contains(clicks))
        {
            personagem2.sprite = sprites[4];
        }
        else
        {
            personagem2.sprite = sprites[5];
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
