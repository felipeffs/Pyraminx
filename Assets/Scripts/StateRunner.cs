using System;
using UnityEngine;

public class StateRunner : MonoBehaviour
{
    public TetraDetection SensorsParent;
    public Transform[] edges;

    public StateStageOne stateStageOne = new StateStageOne();
    public StateStageTwo stateStageTwo = new StateStageTwo();
    public StateStageThree StateStageThree = new StateStageThree();

    private StateBase _currentState;

    private void Awake()
    {
        _currentState = stateStageOne;
    }

    private void Update()
    {
        _currentState.Run(this);
    }

    public void ChangeState(StateBase nextState)
    {
        _currentState.Exit(this);
        _currentState = nextState;
        _currentState.Enter(this);
    }
}
