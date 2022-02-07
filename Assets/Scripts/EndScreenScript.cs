using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreenScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // Update is called once per frame
    public void QuitToMenu()
    {
        SceneManager.LoadScene("Start");
    }
}
