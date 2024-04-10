using UnityEngine;

public class StateSliceSelection : StateBase
{
    public override void Enter(StateRunner stateRunner)
    {
        stateRunner.ClearLog();
        Debug.Log("Seleção da Fatia: 1 = TOPO, 2 = MEIO, 3 = BASE | Retornar: Backspace");
        stateRunner.selectedSensor = null;
    }

    public override void Run(StateRunner stateRunner)
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            stateRunner.SelectTop();
            stateRunner.ChangeState(stateRunner.stateSliceRotation);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            stateRunner.SelectMiddle();
            stateRunner.ChangeState(stateRunner.stateSliceRotation);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            stateRunner.SelectBase();
            stateRunner.ChangeState(stateRunner.stateSliceRotation);
        }

        else if (Input.GetKeyDown(KeyCode.Backspace))
        {
            stateRunner.ChangeState(stateRunner.stateStageEdgeSelection);
        }
    }

    public override void Exit(StateRunner stateRunner)
    {
    }
}
