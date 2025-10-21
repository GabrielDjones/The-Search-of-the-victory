using UnityEngine;
using System.Collections;
using TMPro;

public class TextManager : MonoBehaviour
{
    public CafeteriaManager cafe;
    GameManager gameManager;

    public static TextManager Instance;

    public GameObject dialogueBox;
    public TextMeshProUGUI dialogueText;
    public float typingSpeed = 0.04f;

    private string[] lines;
    private int currentLine;
    public bool isTyping;

    private void Start()
    {

        if (gameManager == null)
            gameManager = FindAnyObjectByType(typeof(GameManager)) as GameManager;
    }

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);

        dialogueBox.SetActive(false);
    }

    void Update()
    {
        if (cafe != null) cafe.SkipText(isTyping);
        if (gameManager != null) gameManager.Typing(isTyping);

        if (dialogueBox.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            if (isTyping)
            {
                StopAllCoroutines();
                dialogueText.text = lines[currentLine];
                isTyping = false;
            }
            else
            {
                currentLine++;
                if (lines != null && currentLine < lines.Length)
                {
                    StartCoroutine(TypeLine(lines[currentLine]));
                }
                else
                {
                    dialogueBox.SetActive(false);
                }
            }
        }
    }

    public void StartDialogue(string[] dialogueLines)
    {
  
        if (dialogueLines == null || dialogueLines.Length == 0)
        {
            Debug.Log("StartDialogue foi chamado com um array vazio ou nulo!");
            return;
        }

        lines = dialogueLines;
        currentLine = 0;
        dialogueBox.SetActive(true);

       
        if (currentLine < lines.Length)
            StartCoroutine(TypeLine(lines[currentLine]));
        else
            Debug.Log("Nenhuma linha para exibir no diálogo!");
    }

    IEnumerator TypeLine(string line)
    {
        dialogueText.text = "";
        isTyping = true;

        foreach (char c in line)
        {
            dialogueText.text += c;
            yield return new WaitForSeconds(typingSpeed);
        }

        isTyping = false;
    }
}
