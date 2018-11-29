using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class persoDataReceiver : MonoBehaviour {

    public int IdPerso;

    string IdDataPerso
    {
        get
        {
            if (Save.team == null) Save.team = new TeamData();
            return Save.team.mates[IdPerso].perso;
        }
    }
    public string Name
    {
        get
        {
            return Perso.find(IdDataPerso).Name;
        }
    }
    public Job JobObj
    {
        get
        {
            return Perso.find(IdDataPerso).jobdata;
        }
    }
    public string Job
    {
        get
        {
            return JobObj.Name;
        }
    }
    public Sprite Face
    {
        get
        {
            return Perso.find(IdDataPerso).Face;
        }
    }
    public int Level
    {
        get
        {
            return Save.team.mates[IdPerso].level;
        }
    }
    public int xp
    {
        get
        {
            return Save.team.mates[IdPerso].XP;
        }
    }
    public int xpMax
    {
        get
        {
            return Level*Level*11;
        }
    }
    public int life
    {
        get
        {
            int baseLife = Save.team.mates[IdPerso].Life;
            if (baseLife == -1)
            {
                Save.team.mates[IdPerso].Life = lifeMax;
                return lifeMax;
            }

            return baseLife;
        }
        set
        {
            Save.team.mates[IdPerso].Life = value;
        }
    }
    public int lifeMax
    {
        get
        {
            return JobObj.LifeBase + JobObj.LifeEvole * Level;
        }
    }
    public int Strengt
    {
        get
        {
            return JobObj.StrengthBase + JobObj.StrengthEvole * Level;
        }
    }
    int curStrengt = -1;
    public int CurStrengt
    {
        get
        {
            if (curStrengt == -1) curStrengt = 0;
            return curStrengt;
        }
        set
        {
            if (value > Strengt)
                curStrengt = Strengt;
            else curStrengt = value;
        }
    }
    public int Stamina
    {
        get
        {
            return JobObj.StaminaBase + JobObj.StaminaEvole * Level;
        }
    }
    int curStamina = -1;
    public int CurStamina
    {
        get
        {
            if (curStamina == -1) curStamina = 0;
            return curStamina;
        }
        set
        {
            if (value > Stamina)
                curStamina = Stamina;
            else curStamina = value;
        }
    }
    public int Charisma
    {
        get
        {
            return JobObj.CharismaBase + JobObj.CharismaEvole * Level;
        }
    }
    int curCharisma = -1;
    public int CurCharisma
    {
        get
        {
            if (curCharisma == -1) curCharisma = 0;
            return curCharisma;
        }
        set
        {
            if (value > Charisma)
                CurCharisma = Charisma;
            else curCharisma = value;
        }
    }
    public int Wisdom
    {
        get
        {
            return JobObj.WisdomBase + JobObj.WisdomEvole * Level;
        }
    }
    int curWisdom = -1;
    public int CurWisdom
    {
        get
        {
            if (curWisdom == -1) curWisdom = 0;
            return curWisdom;
        }
        set
        {
            if (value > Wisdom)
                curWisdom = Wisdom;
            else curWisdom = value;
        }
    }
    public int Mind
    {
        get
        {
            return JobObj.MindBase + JobObj.MindEvole * Level;
        }
    }
    int curMind = -1;
    public int CurMind
    {
        get
        {
            if (curMind == -1) curMind = 0;
            return curMind;
        }
        set
        {
            if (value > Mind)
                curMind = Mind;
            else curMind = value;
        }
    }
    public int Agility
    {
        get
        {
            return JobObj.AgilityBase + JobObj.AgilityEvole * Level;
        }
    }
    int curAgility = -1;
    public int CurAgility
    {
        get
        {
            if (curAgility == -1) curAgility = 0;
            return curAgility;
        }
        set
        {
            if (value > Agility)
                curAgility = Agility;
            else curAgility = value;
        }
    }

    public int weapon
    {
        get
        {
            return -1;
        }
    }
    List<ItemStack> inventory = new List<ItemStack>();
    /*
    public void inventoryLoad()
    {

        PlayerPrefs.SetInt("persoinventory.count", 2);
        PlayerPrefs.SetString("persoinventory.id0", "basicAxe");
        PlayerPrefs.SetInt("persoinventory.qte0", 1);
        PlayerPrefs.SetString("persoinventory.id1", "smallPotion");
        PlayerPrefs.SetInt("persoinventory.qte1", 1);

        int persoInventoryCount = PlayerPrefs.GetInt("persoinventory.count", 0);

        inventory.Clear();

        for (int i = 0; i < persoInventoryCount; i++)
        {
            string itemId = PlayerPrefs.GetString("persoinventory.id" + i, "");
            int itemqte = PlayerPrefs.GetInt("persoinventory.qte" + i, 1);

            inventory.Add(new ItemStack(itemId, itemqte));
        }
    }
    public void inventorySave()
    {
        PlayerPrefs.SetInt("persoinventory.count", inventory.Count);

        for (int i = 0; i < inventory.Count; i++)
        {
            PlayerPrefs.SetString("persoinventory.id" + i, inventory[i].idItem);
            PlayerPrefs.SetInt("persoinventory.qte" + i, inventory[i].qte);
            
        }
    }*/
    public List<ItemStack> inventorySlot(int slot)
    {
        //inventoryLoad();

        List<ItemStack> res = new List<ItemStack>();

        if (Save.inventory == null) Save.inventory = new InventoryData();
        for (int i = 0; i < Save.inventory.stacks.Count; i++)
            {
                //string itemId = PlayerPrefs.GetString("persoinventory.id" + i, "");
                //int itemqte = PlayerPrefs.GetInt("persoinventory.qte" + i, 0);


                ItemStack stack = Save.inventory.stacks[i];

                System.Type type = stack.itemObj.GetType();
                if (type == typeof(ItemStuf))
                    if (((ItemStuf)stack.itemObj).slot == slot)
                    {
                        res.Add(stack);
                    }

            }
        return res;
    }
    public ItemStack PersoSlot(int slot)
    {
        
        string id = Save.team.mates[IdPerso].stuffSlots[slot];

        if (id != "")
        {
            ItemStack inventory = new ItemStack(id, 1);
            return inventory;
        }
        else
        {
            return null;
        }
    }
    public void PersoSetSlot(int slot , int invSlot)
    {
        string id = Save.team.mates[IdPerso].stuffSlots[slot];
        
        if (invSlot >= 0)
        {
            ItemStack stackInv = inventorySlot(slot)[invSlot];

            Save.team.mates[IdPerso].stuffSlots[slot] = stackInv.idItem;
            inventory.Remove(stackInv);
        }
        else if (invSlot == -2)
        {
            Save.team.mates[IdPerso].stuffSlots[slot] = "";
        }
        if (id != "")
        {
            ItemStack inventoryIn = new ItemStack(id, 1);
            inventory.Add(inventoryIn);
        }

    }

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
