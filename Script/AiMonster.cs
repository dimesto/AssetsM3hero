using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class AiMonster : MonoBehaviour {

    public GameObject NormalTarget;

    public string fight;

    Rigidbody2D rigid;


	// Use this for initialization
	public void Start () {
        rigid = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        GameObject player = null;
        RaycastHit2D[] hit = Physics2D.CircleCastAll(transform.position, 360.0f, transform.up);
        if(hit.Length > 0)
        {
            for(int i = 0; i < hit.Length; i++)
            {
                Debug.DrawLine(transform.position, hit[i].collider.transform.position, Color.cyan);
                if(hit[i].collider.gameObject.tag == "Player" && Vector3.Distance(transform.position, hit[i].collider.transform.position) < 3.0f)
                {
                    player = hit[i].collider.gameObject;
                }
            }
        }

        if (NormalTarget != null && player == null)
        {
            Debug.DrawLine(transform.position, transform.position + (NormalTarget.transform.position - transform.position).normalized, Color.black);
            rigid.MovePosition(transform.position + (NormalTarget.transform.position - transform.position).normalized * Time.deltaTime);
        }
        else if (player != null)
        {
            Debug.DrawLine(transform.position, transform.position + (player.transform.position - transform.position).normalized, Color.black);
            rigid.MovePosition(transform.position + (player.transform.position - transform.position).normalized * Time.deltaTime);
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
			if(Save.info == null) Save.info = new GameInfo();
			
            Save.info.MapX = collision.gameObject.transform.position.x;
            Save.info.MapY = collision.gameObject.transform.position.y;
            Save.info.MapName = SceneManager.GetActiveScene().name;

            Fight.CurFight = Fight.find(fight);

            SceneManager.LoadScene("fighting");
        }
    }
}
