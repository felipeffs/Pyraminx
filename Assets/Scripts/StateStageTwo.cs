using UnityEngine;

public class StateStageTwo : StateBase
{
    public override void Enter(StateRunner stateRunner)
    {
        stateRunner.SensorsParent.selectedSensor = null;
    }

    public override void Run(StateRunner stateRunner)
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            stateRunner.SensorsParent.SelectTop();
            stateRunner.ChangeState(stateRunner.StateStageThree);
            Debug.Log("ESTAGIO 2: APERTOU 1");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            stateRunner.SensorsParent.SelectMiddle();
            stateRunner.ChangeState(stateRunner.StateStageThree);
            Debug.Log("ESTAGIO 2: APERTOU 2");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            stateRunner.SensorsParent.SelectBase();
            stateRunner.ChangeState(stateRunner.StateStageThree);
            Debug.Log("ESTAGIO 2: APERTOU 3");
        }

        else if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Debug.Log("Retornou para o Estagio 1");
            stateRunner.ChangeState(stateRunner.stateStageOne);
        }
    }

    public override void Exit(StateRunner stateRunner)
    {
    }
}
