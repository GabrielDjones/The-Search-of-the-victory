using UnityEngine;

public class GameManagerPolicial : MonoBehaviour
{
    GameObject player;
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
        WalkingCode walk = player.GetComponent<WalkingCode>();
        trigger.Interact();
        walk.enabled = false;
    }
    public void YcaroInteract()
    {
        WalkingCode walk = player.GetComponent<WalkingCode>();
        trigger.Ycaro();
        walk.enabled = false;
    }
    public void CaracInteract()
    {
        WalkingCode walk = player.GetComponent<WalkingCode>();
        trigger.Carac();
        walk.enabled = false;
    }
    public void LukaInteract()
    {
        WalkingCode walk = player.GetComponent<WalkingCode>();
        trigger.Luka();
        walk.enabled = false;
    }
    public void PatricioInteract()
    {
        WalkingCode walk = player.GetComponent<WalkingCode>();
        trigger.Patricia();
        walk.enabled = false;
    }

}
