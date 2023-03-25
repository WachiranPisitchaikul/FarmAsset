using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UnitState
{
    Idle,
    Walk
}

public class Staff : MonoBehaviour
{
    private int _id;
    public int ID { get { return _id; } set { _id = value; } }

    private int charSkinId;
    public int CharSkinID { get { return charSkinId; } set { charSkinId = value; } }
    public GameObject[] charSkin;

    public string staffName;
    public int dailyWage;

    [SerializeField] private UnitState state;
    public UnitState State { get; private set; }
    public void InitCharID(int id)
    {
        _id = id;
        charSkinId = Random.RandomRange(0, charSkin.Length - 1);
        staffName = "John";
        dailyWage = Random.RandomRange(80, 125);
    }

    public  void ChangeCharSkin()
    {
        for (int i = 0; i < charSkin.Length; i++ )
        {
            if (i == charSkinId)
            {
                charSkin[i].SetActive(true);
            }
            else
                charSkin[i].SetActive(false);
                
        }
    }
}
