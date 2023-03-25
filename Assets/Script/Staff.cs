using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum UnitState
{
    Idle,
    Walk,
    Harvest,
    Sow,
    Plow,
    Water
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
    //Animation
    [SerializeField] private UnitState _state;
    public UnitState State { get { return _state; } set { _state = value; }  }

    //Nav Staff
    [SerializeField] private NavMeshAgent navAgent;
    public NavMeshAgent NavAgent { get { return navAgent; } }

    void Awake()
    {
        navAgent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        CheckStop();
    }
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
    public void CheckStop()
    {
        float dist = Vector3.Distance(transform.position, navAgent.destination);
        if(dist<=3f)
        {
            _state = UnitState.Idle;
            navAgent.isStopped = true;
        }

    }

    public void SetToWalk(Vector3 dest)
    {
        // To state walk
        _state = UnitState.Walk;

        //Acutlly move
        navAgent.SetDestination(dest);
        navAgent.isStopped = false;

    }
}
