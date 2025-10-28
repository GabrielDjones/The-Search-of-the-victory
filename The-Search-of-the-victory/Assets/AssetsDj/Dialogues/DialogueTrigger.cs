using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [TextArea(2, 5)]
    public string[] Lines;
    [TextArea(2, 5)]
    public string[] Lines2;
 
    public void Interact()
    {
        TextManager.Instance.StartDialogue(Lines);
    }
    public void InteractHospital()
    {
        TextManager.Instance.StartDialogue(Lines2);
    }
}

