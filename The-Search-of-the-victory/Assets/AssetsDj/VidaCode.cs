using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class VidaCode : MonoBehaviour
{
    DialoguePistas dialoguePistas;
    public string sceneName;
    public Slider slider;
    public float life = 3f;// float pois o jogador não se movimenta no eixo x 0.1 unidades no trecho de um frame
    public float lifeMax = 3f;
    UnityEvent Defeat;
    
    private void Start()
    {
        dialoguePistas = FindAnyObjectByType<DialoguePistas>();
    }
  
    void Update()
    {
        life = Mathf.Clamp(life, 0, lifeMax);// limita a vida para menos q 0 
        slider.value = life;
        slider.maxValue = lifeMax;
    }
    public void RightChoice()
    {
        dialoguePistas.Interact();
    }
    public void Loselife()
    {
        life--;    
        dialoguePistas.InteractWrong();             
        if (life == 0)
        {
            SceneManager.LoadScene(sceneName);     
        } 
    }
}
