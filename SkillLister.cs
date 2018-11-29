using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillLister : MonoBehaviour
{

    public GameObject skillPrefab;
    public GameObject returnPrefab;


    private void OnEnable()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            GameObject.Destroy(transform.GetChild(i).gameObject);
        }

        int persoNum = 0;
        int.TryParse(GameStat.curent.Replace("Fight.skill.Perso", ""), out persoNum);

        persoDataReceiver[] persos = GameObject.FindObjectsOfType<persoDataReceiver>();
        for (int i = 0; i < persos.Length; i++)
        {
            if (persos[i].IdPerso == persoNum)
            {
                string jobstr = persos[i].Job;
                Job job = Job.find(jobstr);
                for (int j = 0; j < job.skills.Count; j++)
                {
                    Skill s = Skill.find(job.skills[j]);
                    if (s.CostStrenght <= persos[i].CurStrengt &&
                        s.CostStamina <= persos[i].CurStamina &&
                        s.CostCharisma <= persos[i].CurCharisma &&
                        s.CostWisdom <= persos[i].CurWisdom &&
                        s.CostMind <= persos[i].CurMind &&
                        s.CostAgility <= persos[i].CurAgility
                        )
                    {
                        GameObject go = GameObject.Instantiate(skillPrefab, transform);
                        go.GetComponent<SkillInfo>().idPerso = persoNum;
                        go.GetComponent<SkillInfo>().idSkill = j;
                    }
                }
            }
        }
        GameObject gort = GameObject.Instantiate(returnPrefab, transform);
    }

    void Update()
    {

    }
}
