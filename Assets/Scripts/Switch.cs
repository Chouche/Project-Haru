using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public static Switch instance;

    private Dictionary<string, int> values = new Dictionary<string, int>();

    public static void TurnOn(string name)
    {
        instance.values[name] = 1;
    }
    public static void TurnOff(string name)
    {
        instance.values[name] = 0;
    }
    public static bool IsOn(string name)
    {
        if (instance.values.ContainsKey(name) == false)
            return false;
        return instance.values[name] == 1;
    }

    void Awake()
    {
        instance = this;
    }
	void Start ()
    {
	}
}
