using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickSkill : MonoBehaviour
{
    SkillInfo info;
    void Start()
    {
        info = this.GetComponent<SkillInfo>();

    }
    public void OnClickUp()
    {
        GameStat.curent = GameStat.curent.Replace("Fight.skill", "Fight.selectTarget.skill" + info.idSkill);
        //Debug.Log(GameStat.curent);
    }

}
