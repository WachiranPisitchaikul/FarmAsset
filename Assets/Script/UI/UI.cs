using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public static UI instance;
    public TMP_Text moneyText;
    public TMP_Text staffText;
    public TMP_Text wheatText;
    public TMP_Text melonText;
    public TMP_Text dateText;

    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateHeaderPanel()
    {
        moneyText.text = GameManager.instance.money.ToString();
        staffText.text = GameManager.instance.staff.ToString();
        wheatText.text = GameManager.instance.wheat.ToString();
        melonText.text = GameManager.instance.melon.ToString();
        dateText.text = GameManager.instance.date.ToString();
    }
}
