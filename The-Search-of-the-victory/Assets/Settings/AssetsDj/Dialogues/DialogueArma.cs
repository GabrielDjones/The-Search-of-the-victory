using UnityEngine;

public class DialogueArma : MonoBehaviour
{
    [TextArea(2, 5)]
    public string[] lines;

    private bool hasInteracted = false;

    public void Interact()
    {
        if (hasInteracted) return;

        hasInteracted = true;
        PolicialTalk.Instance.StartDialogue(lines);


    }
}

