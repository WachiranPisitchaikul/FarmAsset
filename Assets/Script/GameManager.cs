using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject staffPrefab;
    public GameObject staffParent;
    // Start is called before the first frame update
    void Start()
    {
        Generatecandidate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Generatecandidate()
    {
        for(int i = 0; i <20;i++)
        {
            GameObject staffObj = Instantiate(staffPrefab, staffParent.transform);
            Staff s = staffObj.GetComponent<Staff>();

            s.InitCharID(i);
            s.ChangeCharSkin();
        }
    }
}
