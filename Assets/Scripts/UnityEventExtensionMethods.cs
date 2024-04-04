using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class UnityEventExtensionMethods
{
    private static void SafeInvoke<T>(this UnityEvent<T> unityEvent, T parameter)
    {
        if (unityEvent != null)
            unityEvent.Invoke(parameter);
    }

    private static void SafeInvoke(this ColliderUnityEvent unityEvent, Collider parameter)
    {
        if (unityEvent != null)
            unityEvent.Invoke(parameter);
    }

    private static void SafeInvoke(this GameObjectUnityEvent unityEvent, GameObject parameter)
    {
        if (unityEvent != null)
            unityEvent.Invoke(parameter);
    }

    private static void SafeInvoke(this UnityEvent unityEvent)
    {
        if (unityEvent != null)
            unityEvent.Invoke();
    }
}
