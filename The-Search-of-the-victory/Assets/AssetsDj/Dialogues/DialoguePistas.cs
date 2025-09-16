using UnityEngine;

public class DialoguePistas : MonoBehaviour
{

    [TextArea(2, 5)]
    public string[] linesAcerto;
    [TextArea(2, 5)]
    public string[] lines2Acerto;
    [TextArea(2, 5)]
    public string[] linesErro;
    [TextArea(2, 5)]
    public string[] lines2Erro;
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
        
    }
    public void InteractWrong()
    {
        if (times == 0)
        {
            TextManager.Instance.StartDialogue(linesErro);
            times++;
        }
        else if(times == 1)
        {
            TextManager.Instance.StartDialogue(lines2Erro);
        }
         
    }
}