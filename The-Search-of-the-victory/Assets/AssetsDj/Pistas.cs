using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Pistas : MonoBehaviour
{
    DialogueTrigger dialogueTrigger;
    DialogueArma gunTrigger;
    DialogueSangue sangueTrigger;
    DialogueSecador secadorTrigger;

    [SerializeField] UnityEvent entregarPistas;
    bool gunInterect;
    bool sangueInterect;
    bool secadorInterect;
    bool botasInterect;
    public int hints;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
      dialogueTrigger = FindAnyObjectByType(typeof(DialogueTrigger)) as DialogueTrigger;
      secadorTrigger = FindAnyObjectByType(typeof(DialogueSecador)) as DialogueSecador;
      gunTrigger = FindAnyObjectByType(typeof(DialogueArma)) as DialogueArma;
      sangueTrigger = FindAnyObjectByType(typeof (DialogueSangue))as DialogueSangue;
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
           gunInterect = true;
           gunTrigger.Interact("arma");
           hints++;
        }
    }
    public void Botas()
    {
        if (botasInterect)
        {
            botasInterect = true;
            gunTrigger.Interact("botas");
            hints++;
        }
    }
    public void Sangue()
    {
        if (!sangueInterect)
        {
          sangueInterect = true;
          sangueTrigger.Interact();
          hints++;
        }
    }
    public void Secador() 
    {
        if (!secadorInterect)
        {
            secadorInterect = true;
            secadorTrigger.Interact();
            hints++;
        }
       
    }
    public void SaidaFalsa()
    {
         dialogueTrigger.Interact();    
    }
    public void SceneSwitcher(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
