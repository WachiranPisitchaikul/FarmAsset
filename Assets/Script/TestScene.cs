using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScene : MonoBehaviour
{
    public Staff _staff;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonIdle()
    {
        _staff.State = UnitState.Idle;
    }

    public void ButtonWalk()
    {
        _staff.State = UnitState.Walk;
    }

    public void Buttonharvest()
    {
        _staff.State = UnitState.Harvest;
    }
    public void ButtonSow()
    {
        _staff.State = UnitState.Sow;

    }
    public void ButtonPlow()
    {
        _staff.State = UnitState.Plow;
    }
    public void ButtonWater()
    {
        _staff.State = UnitState.Water;
    }
}
