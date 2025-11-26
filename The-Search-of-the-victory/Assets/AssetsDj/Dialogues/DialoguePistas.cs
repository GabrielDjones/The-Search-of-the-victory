using UnityEngine;

public class DialoguePistas : MonoBehaviour
{

    [TextArea(2, 5)]
    public string[] linesAcerto;
    [TextArea(2, 5)]
    public string[] lines2Acerto;
    [TextArea(2, 5)]
    public string[] lines3Acerto;
    [TextArea(2, 5)]
    public string[] lines4Acerto;
    [TextArea(2, 5)]
    public string[] lines5Acerto;
    [TextArea(2, 5)]
    public string[] lines6Acerto;
    [TextArea(2, 5)]
    public string[] lines7Acerto;

    [TextArea(2, 5)]
    public string[] linesErro;
    [TextArea(2, 5)]
    public string[] lines2Erro;
    [TextArea(2, 5)]
    public string[] lines3Erro;
    [TextArea(2, 5)]
    public string[] lines5Erro;
    [TextArea(2, 5)]
    public string[] lines6Erro;
    [TextArea(2, 5)]
    public string[] lines7Erro;
    int times;

   

    public void Interact()
    {
       
        if (times == 0)
        {
            TextManager.Instance.StartDialogue(linesAcerto);
            times++;
        }
        else if (times == 1)
        {
            TextManager.Instance.StartDialogue(lines2Acerto);
            times++;
        }
        else if(times == 2)
        {
            TextManager.Instance.StartDialogue(lines3Acerto);
            times++;
        }
        else if ( times == 3)
        {
            TextManager.Instance.StartDialogue(lines4Acerto);
            times++;
        }
        else if (times == 4)
        {
            TextManager.Instance.StartDialogue(lines5Acerto);
            times++;
        }
        else if (times == 5)
        {
            TextManager.Instance.StartDialogue(lines6Acerto);
            times++;
        }
        else if (times == 6)
        {
            TextManager.Instance.StartDialogue(lines7Acerto);
        }


    }
    public void InteractWrong()
    {
        if (times == 0)
        {
            TextManager.Instance.StartDialogue(linesErro);
            times++;
        }
        else if (times == 1)
        {
            TextManager.Instance.StartDialogue(lines2Erro);
            times++;
        }
        else if (times == 2)
        {
            TextManager.Instance.StartDialogue(lines3Erro);
            times++;
        }
        else if (times == 4)
        {
            TextManager.Instance.StartDialogue(lines5Erro);
            times++;
        }
        else if (times == 5)
        {
            TextManager.Instance.StartDialogue(lines6Erro);
            times++;
        }
        else if (times == 6)
        {
            TextManager.Instance.StartDialogue(lines7Erro);
        }
    }
}