using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class PolicialTalk : MonoBehaviour
{
    [SerializeField] TMP_Text convesar;
    [SerializeField] UnityEvent conversaEvent;
    bool primeiraVez;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void  OnTriggerEnter2D(Collider2D other)
    {
        conversaEvent.Invoke();
        if (primeiraVez == false)
        {
            convesar.text = "você não é policial, logo não irá entrar";
            primeiraVez = true;
        }
        else if (primeiraVez == true)
        {
            convesar.text = "cara nmrl ja falei q n tem cm bro, assim se vai entrar na chapa!";
        }
    }
}
