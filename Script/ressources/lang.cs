using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "langue", menuName = "langue", order = 1)]
public class lang : ScriptableObject
{
    public string Lang;

    public lang parent;

    public List<langEntry> entrys = new List<langEntry>();


    public langEntry findText(string key)
    {
        langEntry res = null;
        foreach (langEntry entry in entrys)
        {
            if(entry.key == key)
            {
                res = entry;
            }
        }

        if (res == null)
            if(parent != null)
            res = parent.findText(key);

        return res;

    }

    public static lang findLang(string lang, string group)
    {
        //Debug.Log(lang + "." + group);
        return Resources.Load<lang>("Lang/"+lang + "." + group);
    }

}
[System.Serializable]
public class langEntry
{
    public string key;

    [TextArea]
    public string value;
}

