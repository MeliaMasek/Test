using UnityEngine;

[CreateAssetMenu]

//All code is for testing purposes and is sourced from Anthony Romrell
public class FloatData : ScriptableObject
{
    public float value;

    public void UpdateValue(float num)

    {
        value += num;
    }
}