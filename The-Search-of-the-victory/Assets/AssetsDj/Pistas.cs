using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Pistas : MonoBehaviour
{
  
    DialogueArma gunTrigger;


    [SerializeField] UnityEvent entregarPistas;
    bool gunInterect;
    bool sangueInterect;
    bool secadorInterect;
    bool botasInterect;
    public int hints;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
      gunTrigger = FindAnyObjectByType(typeof(DialogueArma)) as DialogueArma;
    }

    // Update is called once per frame
    void Update()
    {
        if(hints >= 4)
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
        if (!botasInterect)
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
          gunTrigger.Interact("sangue");
          hints++;
        }
    }
    public void Secador() 
    {
        if (!secadorInterect)
        {
            secadorInterect = true;
            gunTrigger.Interact("secador");
            hints++;
        }
       
    }
    public void SaidaFalsa()
    {
         gunTrigger.Interact("saida");    
    }
    public void SceneSwitcher(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
