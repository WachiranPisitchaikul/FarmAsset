using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staff : MonoBehaviour
{
    private int _id;
    public int ID { get { return id; } set { id = value; } }

    private int charSkinId;
    public int CharSkinID { get { return charSkinId} set { charSkinId = value; } }
    public GameObject[] charSkin;

    public string staffName;
    public int dailyWage;


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
                charSkin
        }
    }
}
