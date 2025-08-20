using UnityEngine;

public class DialogueSecador : MonoBehaviour
{
    [TextArea(2, 5)]
    public string[] lines;

    private bool hasInteracted = false;

    public void Interact()
    {
        if (hasInteracted) return;

        hasInteracted = true;
        PolicialTalk.Instance.StartDialogue(lines);
        TextManager.Instance.StartDialogue(lines);
    }
}