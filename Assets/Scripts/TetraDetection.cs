using UnityEngine;

public class TetraDetection : MonoBehaviour
{
    [SerializeField] private Sensor[] _sensors = new Sensor[3];
    public Sensor selectedSensor;

    public void SelectTop()
    {
        //_sensors[2].SetParent();
        selectedSensor = _sensors[2];
    }

    public void SelectMiddle()
    {
        //_sensors[1].SetParent();
        selectedSensor = _sensors[1];
    }

    public void SelectBase()
    {
        //_sensors[2].SetParent();
        selectedSensor = _sensors[0];
    }
}
