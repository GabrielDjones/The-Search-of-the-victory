using UnityEngine;

public class DialogueTrigger2 : MonoBehaviour
{
    [TextArea(2, 5)]
    public string[] Lines;
    [TextArea(2, 5)]
    public string[] Lines2;
    [TextArea(2, 5)]
    public string[] Lines3;
    [TextArea(2, 5)]
    public string[] Lines4;
    [TextArea(2, 5)]
    public string[] Lines5;
    [TextArea(2, 5)]
    public string[] Lines6;

    bool luka = true;
    bool carac = true;
    bool ycaro = true;
    bool patricia = true;
    public void Interact()
    {
        TextManager.Instance.StartDialogue(Lines);
    }
    public void Carac()
    {
        if (carac)
        {
            TextManager.Instance.StartDialogue(Lines2);
            carac = false;
        }
    }
    public void Ycaro()
    {
        if (ycaro)
        {
            TextManager.Instance.StartDialogue(Lines3);
            ycaro = false;
        }
    }
    public void Patricia()
    {
        if (patricia)
        {
            TextManager.Instance.StartDialogue(Lines4);
            patricia = false;
        }
    }
    public void Luka()
    {
        if (luka)
        {
            TextManager.Instance.StartDialogue(Lines5);
            luka = false;
        }
    }
    public void Think()
    {
        TextManager.Instance.StartDialogue(Lines6);
    }
}
