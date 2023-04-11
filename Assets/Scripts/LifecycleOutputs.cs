using UnityEngine;

public class LifecycleOutputs : MonoBehaviour
{
    public int number;

    public int OnEnableCalls { get; private set; }

    void OnEnable()
    {
        OnEnableCalls++;

        var state = StateCache.GetState(gameObject.name);
        if (state != null)
        {
            number = state.number;
        }
    }

    void OnDestroy()
    {
        var state = new State { number = number };
        StateCache.StoreState(gameObject.name, state);
    }
}
