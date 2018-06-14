using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelChange : MonoBehaviour {

    public void StartGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);


    }
}
