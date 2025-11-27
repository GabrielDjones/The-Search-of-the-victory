using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CafeteriaManager : MonoBehaviour
{
    [SerializeField] TMP_Text CharName;
    DialogueTrigger dialogue;
   
    public Image personagem1;
    public Image personagem2;

    public Sprite maia;
    public Sprite maia2;
    public Sprite maia3;
    public Sprite maiatalk;
    public Sprite maiashy;
    public Sprite maiawworried;
    public Sprite maiaquiet;
    public Sprite maiaangry;

    public Sprite diego;
    public Sprite isaac;

    public Sprite maria;
    public Sprite mariatalk;
    public Sprite mariaralkshy;
    public Sprite mariaquiershy;

    public Sprite klaus;
    public Sprite klaus2;
    public Sprite klaus3;

  
    [SerializeField] Transform positionToTeleport;
    [SerializeField] Transform positionToTeleportCamera;

    [SerializeField] GameObject player;
    [SerializeField] GameObject Cam;

    [SerializeField] UnityEvent sceneSwitch;

    [SerializeField] string scene;

    bool clicking;
    public int clicks;
    bool ended = false;
    bool first = false;
    bool policial = false;

    void Start()
    {
        dialogue = FindAnyObjectByType(typeof(DialogueTrigger)) as DialogueTrigger;
        dialogue.Interact();
        CharName.text = "Maia";
        personagem1.sprite = maia;
        personagem2.sprite = isaac;
    }

    void Update()
    {
        WalkingCode walk = player.GetComponent<WalkingCode>();

        NameManager();

        if ( Input.GetKeyDown(KeyCode.E) && clicking == false && ended == false)
        {
            clicks++;
        }

        if (clicks == 14)
        {
            ended = true;
        }

        if (ended == true && first == false)
        { 
            player.SetActive(true);
            sceneSwitch.Invoke();
            clicks = 20;
            first = true;
            Debug.Log("hospital");
        }

        if (clicks == 32)
        {
            player.SetActive(true);
            player.transform.position = positionToTeleport.position;
            Cam.transform.position = positionToTeleportCamera.position; 
            ended = true;
            Debug.Log("polical");
            clicks = 40;
        }

        if (policial == true) 
        {
            walk.enabled = false;
            ended = false;
            Debug.Log("parou de andar");
        }

        if(clicks == 53)
        {
            SceneManager.LoadScene(scene);
        }
    }

   
    public void hospital()
    {
        ended = false;
    }

    public void Policia()
    {
        policial = true;
    }

    private void NameManager()
    {
        if (clicks == 2)
        {
            CharName.text = "maia";
            personagem1.sprite = maia3;
        }
        if (clicks == 3)
        {
            CharName.text = "Isaac";
            personagem1.sprite = maia2;
        }
        if (clicks == 5) 
        {
            CharName.text = "Maia";
            personagem1.sprite = maia;
        }
        if (clicks == 6)
        {
            CharName.text = "Maia";
            personagem1.sprite = maia3;
        }


        if (clicks == 7)
        {
            CharName.text = "Diego";
            personagem2.sprite = diego;
            personagem1.sprite = maia2;
        }

        if (clicks == 8)
        {
            CharName.text = "Isaac";
            personagem2.sprite = isaac;
        }

        if (clicks == 11)
        {
            CharName.text = "Diego";
            personagem2.sprite = diego;
        }

        if (clicks == 12)
        {
            CharName.text = "Isaac";
            personagem2.sprite = isaac;
        }

        if (clicks == 13)
        {
            CharName.text = "Maia";
            personagem1.sprite = maia;
        }
        //---------------------------------------//

        if(clicks == 20)
        {
            personagem2.sprite = maria;
            personagem1.sprite = maiatalk;
        }
        if (clicks == 21) 
        {
            CharName.text = "Maria da Penha";
            personagem2.sprite = mariatalk;
            personagem1.sprite = maiaquiet;
        }


        if (clicks == 22)
        {
            CharName.text = "Maia"; personagem1.sprite = maiashy; personagem2.sprite = maria;
        }

        if (clicks == 23)
        {
            CharName.text = "Maia"; personagem1.sprite = maiawworried; personagem2.sprite = maria;
        }

        if (clicks == 25)
        {
            CharName.text = "Maria da Penha"; personagem1.sprite = maiaquiet; personagem2.sprite = mariatalk;
        }

        if (clicks == 26)
        {
            CharName.text = "Maria da Penha"; personagem1.sprite = maiaquiet; personagem2.sprite = mariaralkshy;
        }

        if (clicks == 27)
        {
            CharName.text = "Maia"; personagem1.sprite = maiatalk; personagem2.sprite = mariaquiershy;
        }

        if (clicks == 28)
        {
            CharName.text = "Maria da Penha"; personagem1.sprite = maiaquiet; personagem2.sprite = mariatalk;
        }

        if (clicks == 29)
        {
            CharName.text = "Maia"; personagem1.sprite = maiawworried; personagem2.sprite = maria;
        }

        if (clicks == 30)
        {
            CharName.text = "Maria da Penha"; personagem1.sprite = maiaquiet; personagem2.sprite = mariatalk;
        }

        if (clicks == 31)
        {
            CharName.text = "Maia"; personagem1.sprite = maiatalk; personagem2.sprite = maria;
        }

        //-------------------------------------//
        if (clicks == 40)
        {
            personagem2.sprite = klaus;
        }
        if (clicks == 41)
        {
            CharName.text = "policial";
            personagem1.sprite = maiaquiet;
            personagem2.sprite = klaus2;
        }

        if (clicks == 42)
        {
            CharName.text = "Maia";
            personagem1.sprite = maiawworried;
            personagem2.sprite = klaus;
        }

        if (clicks == 44)
        {
            CharName.text = "Maia";
            personagem1.sprite = maiawworried;
            personagem2.sprite = klaus;
        }

        if (clicks == 45)
        {
            CharName.text = "Policial";
            personagem1.sprite = maiaquiet;
            personagem2.sprite = klaus3;
        }

        if (clicks == 46)
        {
            CharName.text = "Maia";
            personagem1.sprite = maiatalk;
            personagem2.sprite = klaus;
        }

        if (clicks == 47)
        {
            CharName.text = "Klaus";
            personagem1.sprite = maiaquiet;
            personagem2.sprite = klaus2;
        }

        if (clicks == 48)
        {
            CharName.text = "Maia";
            personagem1.sprite = maiatalk;
            personagem2.sprite = klaus;
        }

        if (clicks == 49)
        {
            CharName.text = "Maia";
            personagem1.sprite = maiaquiet;
            personagem2.sprite = klaus2;
        }

        if (clicks == 50)
        {
            CharName.text = "Klaus";
            personagem1.sprite = maiawworried;
            personagem2.sprite = klaus;
        }

        if (clicks == 51)
        {
            CharName.text = "Klaus";
            personagem1.sprite = maiatalk;
            personagem2.sprite = klaus;
        }

        if (clicks == 52)
        {
            CharName.text = "Klaus";
            personagem1.sprite = maiaquiet;
            personagem2.sprite = klaus3;
        }

    }
    public void SkipText(bool x)
    {
        clicking = x;
    }

}
