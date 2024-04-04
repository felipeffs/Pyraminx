using UnityEngine;
using UnityEngine.Events;

public class CollisionDetectionTrigger : MonoBehaviour
{
    public ColliderUnityEvent CallOnTriggerEnter;
    public ColliderUnityEvent CallOnTriggerExit;
    public GameObjectUnityEvent CallOnTriggerExitWithObject;
    public GameObjectUnityEvent CallOnTriggerEnterWithObject;

    public string LimitByTag = "";

    private void OnTriggerEnter(Collider other)
    {
        if (LimitByTag != "" && other.tag != LimitByTag) return;

        if (CallOnTriggerEnter != null)
            CallOnTriggerEnter.Invoke(other);
        if (CallOnTriggerEnterWithObject != null)
            CallOnTriggerEnterWithObject.Invoke(other.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        if (LimitByTag != "" && other.tag != LimitByTag) return;

        if (CallOnTriggerExit != null)
            CallOnTriggerExit.Invoke(other);
        if (CallOnTriggerExitWithObject != null)
            CallOnTriggerExitWithObject.Invoke(other.gameObject);
    }
}

[System.Serializable]
public class GameObjectUnityEvent : UnityEvent<GameObject> { }

[System.Serializable]
public class ColliderUnityEvent : UnityEvent<Collider> { }
