using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{

    
    public void ChangeScene() => SceneManager.LoadScene(Random.Range(2, 5));

    public void ChangegeScreen(int numberScenes) => SceneManager.LoadScene(numberScenes);

    public void Exit() => Application.Quit();
}
