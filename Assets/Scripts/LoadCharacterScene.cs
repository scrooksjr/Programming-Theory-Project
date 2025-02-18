using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{

    public void ChangeScene()
    {
        SceneManager.LoadScene(1); // Load index for character scene.
    }
}
