
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Save 
{
    public static string curSave = "";
       
    public static string path
    {
        get
        {
            return Application.persistentDataPath + "/save/";
        }
    }
    public static string quickpath
    {
        get
        {
            return Application.persistentDataPath + "/quicksave/";
        }
    }
    public static string[] ListSave
    {
        get
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            DirectoryInfo dir = new DirectoryInfo(path);
            DirectoryInfo[] Infos = dir.GetDirectories();

            string[] res = new string[Infos.Length];

            for(int i = 0; i <Infos.Length; i++)
            {
                res[i] = Infos[i].FullName.Remove(0, path.Length);
            }

            return res;
        }
    }
    public static int coutSave
    {
        get
        {
            return ListSave.Length;
        }
    } 
    public static void create()
    {
        create(System.DateTime.Now.ToString().Replace("/","-").Replace(":","-").Replace(" ","_"));
    } 
    public static void create(string name)
    {
        Directory.CreateDirectory(path+ name);
        curSave = name;
        SaveData();
    }

    public static void loadData()
    {
        team = LoadObj<TeamData>(path + curSave + "/team.json");
        inventory = LoadObj<InventoryData>(path + curSave + "/inventory.json");
        info = LoadObj<GameInfo>(path + curSave + "/info.json");

    }
    public static void SaveData()
    {
        if (!Directory.Exists(path + curSave))
        {
            Directory.CreateDirectory(path + curSave);
        }

        if (team == null) team = new TeamData();
        if (inventory == null) inventory = new InventoryData();

        SaveObj<TeamData>(path + curSave + "/team.json", team);
        SaveObj<InventoryData>(path + curSave + "/inventory.json", inventory);
        SaveObj<GameInfo>(path + curSave + "/info.json", info);
    }

    public static void quickloadData()
    {
        team = LoadObj<TeamData>(quickpath + "/team.json");
        inventory = LoadObj<InventoryData>(quickpath + "/inventory.json");
        info = LoadObj<GameInfo>(quickpath + "/info.json");
    }
    public static void quickSaveData()
    {
        if (!Directory.Exists(quickpath))
        {
            Directory.CreateDirectory(quickpath);
        }

        if (team == null) team = new TeamData();
        if (inventory == null) inventory = new InventoryData();
        
        SaveObj<TeamData>(quickpath + "/team.json", team);
        SaveObj<InventoryData>(quickpath + "/inventory.json", inventory);
        SaveObj<GameInfo>(quickpath + "/info.json", info);
    }

    static void SaveObj<T>(string filePath, T obj)
    {
        string dataAsJson = JsonUtility.ToJson(obj);

        if (!File.Exists(filePath))
            File.Create(filePath).Dispose();

        File.WriteAllText(filePath, dataAsJson);
        
    }
    static T LoadObj<T>(string filePath) where T : new()
    {

        if (File.Exists(filePath))
        {
            string dataAsJson = File.ReadAllText(filePath);
            return JsonUtility.FromJson<T>(dataAsJson);
        }
        else return new T();

    }

    public static void newData()
    {
        team = new TeamData();
        inventory = new InventoryData();
        info = new GameInfo();
    }

    // data
    
    public static GameInfo      info = null;

    public static TeamData      team = null;
    public static InventoryData inventory = null;

}
