﻿using System.Reflection;
using UnityEngine;

public class StateRunner : MonoBehaviour
{
    public Transform SensorsParent;
    public Transform[] edges;

    public StateEdgeSelection stateStageEdgeSelection = new StateEdgeSelection();
    public StateSliceSelection stateSliceSelectio = new StateSliceSelection();
    public StateSliceRotation stateSliceRotation = new StateSliceRotation();

    [SerializeField] private Sensor[] _sensors = new Sensor[3];
    public Sensor selectedSensor;

    private StateBase _currentState;

    private void Awake()
    {
        _currentState = stateStageEdgeSelection;
        _currentState.Enter(this);
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

    public void SelectTop()
    {
        selectedSensor = _sensors[2];
    }

    public void SelectMiddle()
    {
        selectedSensor = _sensors[1];
    }

    public void SelectBase()
    {
        selectedSensor = _sensors[0];
    }

    public void ClearLog()
    {
        var assembly = Assembly.GetAssembly(typeof(UnityEditor.Editor));
        var type = assembly.GetType("UnityEditor.LogEntries");
        var method = type.GetMethod("Clear");
        method.Invoke(new object(), null);
    }
}
