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
            TextManager.Instance.StartDialogue(lines);
            times++;
        }
        else if (times == 1)
        {
            TextManager.Instance.StartDialogue(lines2);
            times++;
        }
        hasInteracted = true;
    }
    public void InteractWrong()
    {
        if (hasInteracted) return;
        TextManager.Instance.StartDialogue(lines3);
        hasInteracted = true;
    }
}