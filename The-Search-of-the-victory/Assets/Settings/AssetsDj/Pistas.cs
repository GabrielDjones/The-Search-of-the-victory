using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Pistas : MonoBehaviour
{
    DialogueArma gunTrigger;
    DialogueSangue sangueTrigger;
    DialogueSecador secadorTrigger;
    [SerializeField] UnityEvent gun;
    [SerializeField] UnityEvent sangue;
    [SerializeField] UnityEvent secador;
    [SerializeField] UnityEvent entregarPistas;
    bool gunInterect;
    bool sangueInterect;
    bool secadorInterect;
    int hints;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [System.Obsolete]
    void Start()
    {
      secadorTrigger = FindObjectOfType(typeof(DialogueSecador)) as DialogueSecador;
      gunTrigger = FindObjectOfType(typeof(DialogueArma)) as DialogueArma;
      sangueTrigger = FindObjectOfType(typeof (DialogueSangue))as DialogueSangue;
    }

    // Update is called once per frame
    void Update()
    {
        if(hints >= 3)
        {
            entregarPistas.Invoke();
        }
    }
    public void Arma()
    {
        if (!gunInterect)
        {
           gun.Invoke();
           gunInterect = true;
           gunTrigger.Interact();
           hints++;
        }
    }
    public void Sangue()
    {
        if (!sangueInterect)
        {
          sangue.Invoke();
          sangueInterect = true;
          sangueTrigger.Interact();
          hints++;
        }
    }
    public void Secador() 
    {
        if (!secadorInterect)
        {
            secador.Invoke();
            secadorInterect = true;
            secadorTrigger.Interact();
            hints++;
        }
       
    }
}
