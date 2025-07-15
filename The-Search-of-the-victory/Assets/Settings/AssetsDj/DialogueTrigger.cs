using UnityEngine;

public class DialogueTrigger : MonoBehaviour

{
    [TextArea(2, 5)]
    public string[] lines;

    public void Interact()
    {
        PolicialTalk.Instance.StartDialogue(lines);
    }
}

