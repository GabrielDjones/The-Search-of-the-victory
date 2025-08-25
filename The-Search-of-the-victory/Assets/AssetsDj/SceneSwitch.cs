using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    [SerializeField] string scene;
   
    public void OnTriggerEnter2D(Collider2D other)
    {
        SceneSwitcher(scene);
    }
    public void SceneSwitcher(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
