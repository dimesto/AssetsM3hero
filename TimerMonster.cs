using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerMonster : MonoBehaviour
{

    Timer time;
    public MonsterInfo info;

    // Use this for initialization
    void Start()
    {
        time = this.GetComponent<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (time.value <= 0)
        {
            persoDataReceiver[] persos = GameObject.FindObjectsOfType<persoDataReceiver>();
            int numperso = persos.Length;
            int selectPerso = Random.Range(0, numperso);

            persos[selectPerso].life -= info.curSkillDomage;
            

            slelectSkill();
        }
    }
    void slelectSkill()
    {
        int maxskills = info.skills.Count;

        info.curskills = Random.Range(0, maxskills);

        time.value = info.curSkillTime;
        time.timeStart = info.curSkillTime;
    }
}
