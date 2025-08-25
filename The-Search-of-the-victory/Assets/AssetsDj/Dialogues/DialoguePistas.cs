using UnityEngine;

public class DialoguePistas : MonoBehaviour
{

    [TextArea(2, 5)]
    public string[] lines;
    [TextArea(2, 5)]
    public string[] lines2;
    [TextArea(2, 5)]
    public string[] lines3;
    int times;
    private bool hasInteracted = false;
   
    public void Interact()
    {
        if (hasInteracted) return;
        if (times > 0)
        {
            PolicialTalk.Instance.StartDialogue(lines);
            times++;
        }
        else if (times == 1)
        {
            PolicialTalk.Instance.StartDialogue(lines2);
            times++;
        }
        hasInteracted = true;
    }
    public void InteractWrong()
    {
        if (hasInteracted) return;
        PolicialTalk.Instance.StartDialogue(lines3);
        hasInteracted = true;
    }
}