using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [TextArea(2, 5)]
    public string[] Lines;
    public void Interact()
    {
      TextManager.Instance.StartDialogue(Lines);
    }
}

