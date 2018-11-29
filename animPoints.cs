using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class animPoints : MonoBehaviour {
    
    public GameObject go1;
    public StatType stat;
    public int val;

    // Use this for initialization
    void Start ()
    {

	}

    // Update is called once per frame
    void Update() {
        int persoNum = 0;
        int.TryParse(GameStat.curent.Replace("Fight.FocusMove.Perso", ""), out persoNum);

        //Debug.Log(persoNum);

        GaugeStatsWriter[] gauges = GameObject.FindObjectsOfType<GaugeStatsWriter>();
        for (int i = 0; i < gauges.Length; i++)
        {
            if (gauges[i].stat == stat)
                if (gauges[i].perso.IdPerso == persoNum)
                {
                    go1 = gauges[i].gameObject;
                }

        }

        if (go1)
        {
            Debug.DrawLine(go1.transform.position, transform.position, Color.red);
            transform.position += (go1.transform.position - transform.position).normalized * Time.deltaTime * 40.0f;

            //Debug.Log(Vector3.Distance(go1.transform.position, transform.position));

            if (Vector3.Distance(go1.transform.position, transform.position) <= 5.0f)
            {
                persoDataReceiver perso = go1.GetComponent<GaugeStatsWriter>().perso;

                if (stat == StatType.Strengt) perso.CurStrengt += val;
                if (stat == StatType.Stamina) perso.CurStamina += val;
                if (stat == StatType.Charisma) perso.CurCharisma += val;
                if (stat == StatType.Wisdom) perso.CurWisdom += val;
                if (stat == StatType.Mind) perso.CurMind += val;
                if (stat == StatType.Agility) perso.CurAgility += val;

                GameObject.Destroy(this.gameObject);
            }
        }
    }
}
