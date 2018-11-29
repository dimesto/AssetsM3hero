using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSelect : MonoBehaviour
{

    public GameObject goSelect;
    public MonsterInfo info;
    bool selected = false;

    public void OnOverEnter()
    {
        selected = true;
    }
    public void OnOverExit()
    {
        selected = false;
    }
    public void OnClickUp()
    {
        if (GameStat.curent.Contains("Fight.selectTarget"))
        {
            string str1 = GameStat.curent.Replace("Fight.selectTarget.skill", "");
            string strSkill = str1.Substring(0, str1.IndexOf(".Perso"));
            string strPerso = str1.Replace(strSkill + ".Perso", "");

            int skillNum = 0;
            int.TryParse(strSkill, out skillNum);
            int Personum = 0;
            int.TryParse(strPerso, out Personum);

            persoDataReceiver[] persos = GameObject.FindObjectsOfType<persoDataReceiver>();

            for (int i = 0; i < persos.Length; i++)
            {


                if (persos[i].IdPerso == Personum)
                {
                    Skill skill = Skill.find(persos[i].JobObj.skills[skillNum]);
                    info.Life -= skill.Domage;

                    persos[i].CurStrengt -= skill.CostStrenght;
                    persos[i].CurStamina -= skill.CostStamina;
                    persos[i].CurCharisma -= skill.CostCharisma;
                    persos[i].CurWisdom -= skill.CostWisdom;
                    persos[i].CurMind -= skill.CostMind;
                    persos[i].CurAgility -= skill.CostAgility;
                }
            }

            Personum++;
            if (Personum >= persos.Length) Personum = 0;

            GameStat.curent = "Fight.menu.Perso" + Personum;
            //Debug.Log(GameStat.curent);
            //info.idMonster
        }

    }

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (GameStat.curent.Contains("Fight.selectTarget"))
            goSelect.SetActive(selected);
        else
            goSelect.SetActive(false);
    }
}
