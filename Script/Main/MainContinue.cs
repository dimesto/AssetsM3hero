using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainContinue : MonoBehaviour
{
    
	public void OnClickUp()
    {
        Save.quickloadData();
        SceneManager.LoadScene("loading", LoadSceneMode.Single);

    }

}
