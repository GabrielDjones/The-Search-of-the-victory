using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [TextArea(2, 5)]
    public string[] Lines;
    public string[] Lines2;
    int text;
    public void Interact()
    {
        if (text == 0) TextManager.Instance.StartDialogue(Lines); text++;
        if (text == 1) TextManager.Instance.StartDialogue(Lines2);text++;
    }
}

