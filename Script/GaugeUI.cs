using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class GaugeUI : MonoBehaviour {

    [Range(0.0f, 1.0f)]
    public float value = 0.0f;
    public int padding;

    RectTransform container;
    RectTransform tranfo;

	// Use this for initialization
	void Start () {

        tranfo = GetComponent<RectTransform>();
        container = transform.parent.GetComponent<RectTransform>();

    }
	
	// Update is called once per frame
	void Update () {
        
        float contWidthX = container.sizeDelta.x;

        tranfo.anchorMin = new Vector2(0, 0);
        tranfo.anchorMax = new Vector2(1, 1);
        tranfo.pivot = new Vector2(0.5f, 0.5f);

        tranfo.offsetMin = new Vector2(padding, padding);
        tranfo.offsetMax = new Vector2(-(padding + ((contWidthX-2*padding) * (1.0f-value))), -padding);

	}
}
