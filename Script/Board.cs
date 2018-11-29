using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        M3ObjectValue[] objs = GameObject.FindObjectsOfType<M3ObjectValue>();
        M3Point[] points = GameObject.FindObjectsOfType<M3Point>();
        animPoints[] statpoints = GameObject.FindObjectsOfType<animPoints>();

        int numMove = 0;
        for(int i = 0; i < objs.Length; i++)
        {
            if ((objs[i].value == -1) ||
                (objs[i].value >= 3))
            {
                numMove++;
            }
        }
        //Debug.Log("objs" + numMove);
        for(int i = 0; i < points.Length; i++)
        {
            if(points[i].Linked != null)
            if (Vector3.Distance(points[i].transform.position, points[i].Linked.transform.position) > 0.1f)
            {
                numMove++;
            }
        }
        //Debug.Log("points" + numMove);
                numMove+= statpoints.Length;
        //Debug.Log("statpoints" + numMove + " & " + GameStat.curent);



        if (numMove == 0 && GameStat.curent.Contains("Fight.FocusMove"))
        {
            int persoNum = 0;
            int.TryParse(GameStat.curent.Replace("Fight.FocusMove.Perso", ""), out persoNum);

            persoNum++;
            if (persoNum >= Save.team.mates.Count) persoNum = 0;

            GameStat.curent = "Fight.menu.Perso" + persoNum.ToString();
        }
    }
}
