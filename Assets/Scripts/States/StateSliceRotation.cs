using UnityEngine;

public class StateSliceRotation : StateBase
{
    private Sensor _selectedSensor;
    public override void Enter(StateRunner stateRunner)
    {
        _selectedSensor = stateRunner.selectedSensor;
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
            stateRunner.ChangeState(stateRunner.stateSliceSelectio);
        }
    }

    public override void Exit(StateRunner stateRunner)
    {
        _selectedSensor.RemoveParent();
    }
}
