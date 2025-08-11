using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    [SerializeField] string scene;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        SceneSwitcher(scene);
    }
    public void SceneSwitcher(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
