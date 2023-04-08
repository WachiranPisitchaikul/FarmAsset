using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum FarmStage
{
    plowing,
    sowing,
    maintaining,
    harvesting
}
public class Farm : Structure
{

    

    public FarmStage stage = FarmStage.plowing;


    [SerializeField] private int maxStaffNum = 3;
    public int MaxStaffNum { get { return maxStaffNum; } set { maxStaffNum = value; } }

    public int dayRequired;
    public int dayPassed;
    public float produceTimer = 0f;
    private int secondsPerDay = 10;

    public int cultivateDuration;

    public float WorkTimer = 0f;
    private float WorkTimeWait = 1f;

    public GameObject FarmUI;

    [SerializeField] private List<Staff> workingStaff; 
    public List<Staff> WorkingStaff { get{ return workingStaff; } set { workingStaff = value; } }

    // Update is called once per frame
    void Update()
    {
        CheckPlowing();
        CheckSowing();
        CheckMaintaining();
        CheckHarvesting();
    }

    private void Working ()
    {
        hp += 3;
    }
    
    public void CheckTimeForWork()
    {
        WorkTimer += Time.deltaTime;

        if(WorkTimer>WorkTimeWait)
        {
            WorkTimer = 0;
            Working();
        }
    }

    private void CheckPlowing()
    {
        if((hp>=100)&&(stage==FarmStage.plowing))
        {
            
            stage = FarmStage.sowing;
            hp = 1;
        }
    }
    private void CheckSowing()
    {
        if ((hp >= 100) && (stage == FarmStage.sowing))
        {
            functional = true;
            stage = FarmStage.maintaining;
            hp = 1;
        }
    }

    private void CheckMaintaining()
    {
        if ((hp >= 100) && (stage == FarmStage.maintaining))
        {

            produceTimer += Time.deltaTime;
            dayPassed = Mathf.CeilToInt(produceTimer / secondsPerDay);

            if((functional ==true)&&(dayPassed>=dayRequired)  )
            {
                stage = FarmStage.harvesting;
                hp = 1;
                produceTimer = 0;
            }

        }
    }

    private void CheckHarvesting()
    {
        if((hp >=100)&&(stage== FarmStage.harvesting) )
        {

        }
    }

    private void HarvestResult()
    {
        switch(type)
        {
            case StructureType.wheat:
                GameManager.instance.wheat += 1000;
                break;

        }
    }
}
