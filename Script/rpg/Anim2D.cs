using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Anim2D : MonoBehaviour {

    public List<Anim> animes = new List<Anim>();

    public float timeFrame = 0.1f;
    public float timeLeft = 0.0f;

    public int Frame = 0;
    public int curAnime = 0;

    SpriteRenderer render;

    // Use this for initialization
    void Start ()
    {
        render = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (curAnime != -1)
        {
            timeLeft += Time.deltaTime;

            if (timeLeft >= timeFrame)
            {
                timeLeft = 0;
                Frame++;

                if (Frame >= animes[curAnime].frames.Count)
                    Frame = 0;

                render.sprite = animes[curAnime].frames[Frame];
            }
        }
	}
}

[System.Serializable]
public class Anim
{
    public string name = "";
    public List<Sprite> frames = new List<Sprite>();

}