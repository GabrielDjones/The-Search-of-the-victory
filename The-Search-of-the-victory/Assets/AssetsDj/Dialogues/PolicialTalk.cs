using TMPro;
using UnityEngine;
using System.Collections;

public class PolicialTalk : MonoBehaviour
{
    GameManager gameManager;

    public static PolicialTalk Instance;

    public GameObject dialogueBox;
    public GameObject dialogueBox2;
    public TextMeshProUGUI dialogueText;
    public TextMeshProUGUI dialogueText2;
    public float typingSpeed = 0.04f;

    private string[] lines;
    private int currentLine;
    public bool isTyping;
    private void Start()
    {
        gameManager = FindAnyObjectByType(typeof(GameManager)) as GameManager;
    }
    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);

        dialogueBox.SetActive(false);
        dialogueBox2.SetActive(false);
    }

    void Update()
    {
        gameManager.Typing(isTyping);
        if (dialogueBox.activeSelf && dialogueBox2 && Input.GetKeyDown(KeyCode.E))
        {
           
            if (isTyping)
            {
                StopAllCoroutines();
                dialogueText.text = lines[currentLine];
                dialogueText2.text = lines[currentLine];
                isTyping = false;
            }
            else
            {
                currentLine++;
                if (currentLine < lines.Length)
                {
                    StartCoroutine(TypeLine(lines[currentLine]));
                }
                else
                {
                    dialogueBox.SetActive(false);
                    dialogueBox2.SetActive(false);
                }
            }
        }
       
    }

    public void StartDialogue(string[] dialogueLines)
    {
        lines = dialogueLines;
        currentLine = 0;
        dialogueBox.SetActive(true);
        dialogueBox2.SetActive(true);
        StartCoroutine(TypeLine(lines[currentLine]));
    }

    IEnumerator TypeLine(string line)
    {
        dialogueText.text = "";
        dialogueText2.text = "";
        isTyping = true;

        foreach (char c in line)
        {
            dialogueText.text += c;
            dialogueText2.text += c;
            yield return new WaitForSeconds(typingSpeed);
        }

        isTyping = false;
    }
}