using UnityEngine;

public class DialogueArma : MonoBehaviour
{
    [TextArea(2, 5)]
    public string[] armasLines;
    [TextArea(2, 5)]
    public string[] botasLines;
    [TextArea(2, 5)]
    public string[] sangueLines;
    [TextArea(2, 5)]
    public string[] saidaLines;
    [TextArea(2, 5)]
    public string[] secadorLines;
    public void Interact(string objeto)
    {
        if (objeto == "arma")
        {
            PolicialTalk.Instance.StartDialogue(armasLines);
        }
        if (objeto == "botas")
        {
             PolicialTalk.Instance.StartDialogue(botasLines);
        }
        if(objeto == "secador")
        {
            PolicialTalk.Instance.StartDialogue(secadorLines);
        }
        if( objeto == "saida")
        {
            PolicialTalk.Instance.StartDialogue(saidaLines);
        }
        if(objeto == "sangue")
        {
            PolicialTalk.Instance.StartDialogue(sangueLines);
        }
    }
}

