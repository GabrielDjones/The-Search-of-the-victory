using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public Image personagem1;
    public Image personagem2;


    public List<Sprite> sprites = new List<Sprite> { }; 

    bool luka = true;
    bool carac = true;
    bool ycaro = true;
    bool patricia = true;
    public void Interact()
    {
        TextManager.Instance.StartDialogue(Lines);
        if(personagem1 != null && personagem2 != null)
        {
            personagem1.sprite = sprites[0];
            personagem2.sprite = sprites[1];
        }
    }
    public void Carac()
    {
        if (carac)
        {
            TextManager.Instance.StartDialogue(Lines2);
            carac = false;
            personagem2.sprite = sprites[2];
        }
    }
    public void Ycaro()
    {
        if (ycaro)
        {
            TextManager.Instance.StartDialogue(Lines3);
            ycaro = false;
            personagem2.sprite = sprites[3];
        }
    }
    public void Patricia()
    {
        if (patricia)
        {
            TextManager.Instance.StartDialogue(Lines4);
            patricia = false;
            personagem2.sprite = sprites[4];
        }
    }
    public void Luka()
    {
        if (luka)
        {
            TextManager.Instance.StartDialogue(Lines5);
            luka = false;
            personagem2.sprite = sprites[5];
        }
    }
    public void Think()
    {
        TextManager.Instance.StartDialogue(Lines6);
        personagem2.sprite = sprites[6];
    }
}
