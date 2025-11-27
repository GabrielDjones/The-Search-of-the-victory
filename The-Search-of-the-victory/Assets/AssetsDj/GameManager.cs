using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public List<Sprite> sprites = new List<Sprite> { };

    List<int> juiz = new List<int> {0,1,4,6,8,9,10,11,12,13,14,15,16,17,24,26,29,31,33,35,38};
    List<int> maia = new List<int> {2,5,7,21,23,25,30,34,36};
    List<int> costa = new List<int> { 3, 18, 19, 20, 22, 27, 28, 32, 37, 39 };

    public Image personagem1;
    public Image personagem2;
    public Image personagem3;
 
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

    }

    public void ImageSwitch()
    {
        if (juiz.Contains(clicks))
        { 
            personagem3.sprite = sprites[0];
        }
        else
        {
            personagem3.sprite = sprites[1];
        }

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
