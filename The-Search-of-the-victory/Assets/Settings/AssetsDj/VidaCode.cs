using UnityEngine;
using UnityEngine.UI;
public class VidaCode : MonoBehaviour
{
    public Slider slider;
    public float life = 3f;// float pois o jogador não se movimenta no eixo x 0.1 unidades no trecho de um frame
    public float lifeMax = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) //botao esquerdo 
                                         // down se refere a cada clique do mouse 
        {
            life += 1; //aumenta 5 pontos de vida
        }
        else if (Input.GetMouseButtonDown(1)) // botao direito 
        {
            lifeMax -= 1; //diminui dez pontos de vida 
        }
        life = Mathf.Clamp(life, 0, lifeMax);// limita a vida para menos q 0 
        slider.value = life;
        slider.maxValue = lifeMax;
    }
}
