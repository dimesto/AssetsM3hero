using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainNewgame : MonoBehaviour
{

    public void OnClickUp()
    {
        Save.newData();
        SceneManager.LoadScene("loading", LoadSceneMode.Single);

    }
}
