using UnityEngine;

public class DialogueSecador : MonoBehaviour
{
   
    [TextArea(2, 5)]
    public string[] lines;

    private bool hasInteracted = false;
    private void Start()
    {
     
    }
    public void Interact()
    {
        if (hasInteracted) return;

        hasInteracted = true;
        
        TextManager.Instance.StartDialogue(lines);
      
        PolicialTalk.Instance.StartDialogue(lines);
    }
}