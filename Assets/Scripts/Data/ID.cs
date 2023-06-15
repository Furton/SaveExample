using UnityEngine;

[CreateAssetMenu(fileName = "ID", menuName = "ScriptableObjects/ID", order = 2)]
public class ID : ScriptableObject
{
    [field: SerializeField] public string id { get; private set;}

    public ID()
    {
        id = "defaultID";
    }
}