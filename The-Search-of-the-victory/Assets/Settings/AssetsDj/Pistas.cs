using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Pistas : MonoBehaviour
{
    DialogueArma gunTrigger;
    DialogueSangue sangueTrigger;
    [SerializeField] UnityEvent gun;
    [SerializeField] UnityEvent sangue;
    bool gunInterect;
    bool sangueInterect;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [System.Obsolete]
    void Start()
    {
      gunTrigger = FindObjectOfType(typeof(DialogueArma)) as DialogueArma;
      sangueTrigger = FindObjectOfType(typeof (DialogueSangue))as DialogueSangue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Arma()
    {
        if (!gunInterect)
        {
           gun.Invoke();
           gunInterect = true;
           gunTrigger.Interact();
        }
    }
    public void Sangue()
    {
        if (!sangueInterect)
        {
          sangue.Invoke();
          sangueInterect = true;
          sangueTrigger.Interact();
        }
    }
}
