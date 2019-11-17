using UnityEngine;

public static class DebugUtility
{
    public static void HandleErrorIfNullGetComponent<TO, TS>(Component component, Component source, GameObject onObject)
    {
#if UNITY_EDITOR
        if (component == null)
        {
            Debug.LogError("Error: Component of type " + typeof(TS) + " on GameObject " + source.gameObject.name + 
                " expected to find a component of type " + typeof(TO) + " on GameObject " + onObject.name + ", but none were found.");
        }
#endif
    }

    public static void HandleErrorIfNullFindObject<TO, TS>(UnityEngine.Object obj, Component source)
    {
#if UNITY_EDITOR
        if (obj == null)
        {
            Debug.LogError("Error: Component of type " + typeof(TS) + " on GameObject " + source.gameObject.name + 
                " expected to find an object of type " + typeof(TO) + " in the scene, but none were found.");
        }
#endif
    }
}
