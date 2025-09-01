using UnityEngine;

public class DialogueArma : MonoBehaviour
{
    [TextArea(2, 5)]
    public string[] armasLines;
    public string[] botasLines;

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

    }
}

