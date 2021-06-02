using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void startButton()
    {
        SceneManager.LoadScene("Main");

    }


    public void optionsButton()
    {
       // SceneManager.LoadScene("Main");   *sahnenin ismini options sahnesi ile ayný yapak gerekiyor

    }


    public void creditsButton()
    {
        //   SceneManager.LoadScene("Main");    *sahnenin ismini credits sahnesi ile ayný yapmak gerekiyor

    }


}
