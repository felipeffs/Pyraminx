using UnityEngine;

public class StateStageThree : StateBase
{
    private Sensor _selectedSensor;
    public override void Enter(StateRunner stateRunner)
    {
        _selectedSensor = stateRunner.SensorsParent.selectedSensor;
        _selectedSensor.SetParent();
    }

    public override void Run(StateRunner stateRunner)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _selectedSensor.RotateRight();
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            _selectedSensor.RotateLeft();
        }
        else if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Debug.Log("Retornou para o Estagio 2");
            stateRunner.ChangeState(stateRunner.stateStageTwo);
        }
    }

    public override void Exit(StateRunner stateRunner)
    {
        _selectedSensor.RemoveParent();
    }
}
