using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPG2DMove : MonoBehaviour
{

    public float speed;

    Rigidbody2D rigid;
    Anim2D anim;

    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Anim2D>();

        if(Save.info != null)
        transform.position = new Vector3(Save.info.MapX, Save.info.MapY, 0);

        /*
        if (PlayerPrefs.HasKey("MapX") && PlayerPrefs.HasKey("MapY"))
        {
            GameObject.Find("Player").transform.position = new Vector3(PlayerPrefs.GetFloat("MapX"), PlayerPrefs.GetFloat("MapY"), 0);
            PlayerPrefs.DeleteKey("MapX");
            PlayerPrefs.DeleteKey("MapY");
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        rigid.MovePosition(transform.position + new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * Time.deltaTime * speed);

        if(Input.GetAxis("Vertical") < 0)
        {
            anim.curAnime = 0;
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            anim.curAnime = 1;
        }
        else if (Input.GetAxis("Vertical") > 0)
        {
            anim.curAnime = 2;
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            anim.curAnime = 3;
        }

    }
}
