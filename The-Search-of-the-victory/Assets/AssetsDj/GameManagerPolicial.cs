using UnityEngine;

public class GameManagerPolicial : MonoBehaviour
{
    [SerializeField] GameObject player;
    DialogueTrigger2 trigger;

    void Start()
    {
     
        trigger  = FindAnyObjectByType(typeof(DialogueTrigger2))as DialogueTrigger2; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PolicialInteract()
    {

    }
}
