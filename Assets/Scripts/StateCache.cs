using System;
using System.Collections.Generic;

public static class StateCache
{
    private static Dictionary<string, State> states =
        new Dictionary<string, State>(StringComparer.OrdinalIgnoreCase);

    public static void StoreState(string key, State state) => states[key] = state;

    public static State GetState(string key)
    {
        states.TryGetValue(key, out var state);

        return state;
    }
}
