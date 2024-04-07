using UnityEngine;

public class StateEdgeSelection : StateBase
{
    bool _toChange = false;
    public override void Enter(StateRunner stateRunner)
    {
        _toChange = false;
    }

    public override void Run(StateRunner stateRunner)
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _toChange = true;
            stateRunner.SensorsParent.transform.SetPositionAndRotation(stateRunner.edges[0].position, stateRunner.edges[0].rotation);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _toChange = true;
            stateRunner.SensorsParent.transform.SetPositionAndRotation(stateRunner.edges[1].position, stateRunner.edges[1].rotation);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _toChange = true;
            stateRunner.SensorsParent.transform.SetPositionAndRotation(stateRunner.edges[2].position, stateRunner.edges[2].rotation);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            _toChange = true;
            stateRunner.SensorsParent.transform.SetPositionAndRotation(stateRunner.edges[3].position, stateRunner.edges[3].rotation);
        }

        if (_toChange)
            stateRunner.ChangeState(stateRunner.stateSliceSelectio);
    }

    public override void Exit(StateRunner stateRunner)
    {

    }
}
