using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsController : MonoBehaviour
{


    public void StartGame()
    {

        SceneManager.LoadScene(1);

    }

    public void Exit()
    {
        Debug.Log("Exit");
        
    }
}
