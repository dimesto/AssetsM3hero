using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetailSelect : MonoBehaviour {

    public int idDetail;

    public GameObject List;
    public GameObject detail;

	// Use this for initialization
	void Start () {
		
	}
    private void OnEnable()
    {
        idDetail = -1;
    }

    // Update is called once per frame
    void Update () {
		if(idDetail == -1)
        {
            List.SetActive(true);
            detail.SetActive(false);
        }
        else
        {
            List.SetActive(false);
            detail.SetActive(true);
            detail.GetComponent<persoDataReceiver>().IdPerso = idDetail;
        }
	}
}
