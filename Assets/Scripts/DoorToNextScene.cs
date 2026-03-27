using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorToNextScene : MonoBehaviour
{
    public string SceneName;

    void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(SceneName);
    }
}
