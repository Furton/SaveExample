using Common;
using UnityEngine;

public class SaveManager: Singleton<SaveManager>
{
    public string id;
    
    protected override void Awake()
    {
        base.Awake();
        ID idObject = Resources.Load<ID>("ID");
        if(!idObject)
        {
            idObject = ScriptableObject.CreateInstance<ID>();
        }
        id = idObject.id;
    }

    public void Load(Data data)
    {
        if(PlayerPrefs.HasKey(id))
        {
            JsonUtility.FromJsonOverwrite(PlayerPrefs.GetString(id), data);
        }
        else
        {
            SetDefaultValues(data);
        }
    }

    public void Save(Data data)
    {
        PlayerPrefs.SetString(id, JsonUtility.ToJson(data));
    }

    public void Reset(Data data)
    {
        PlayerPrefs.DeleteKey(id);
        SetDefaultValues(data);
    }


    void SetDefaultValues(Data data)
    {
        Data initDataObject = Resources.Load<Data>("InitData");
        if (!initDataObject)
        {
            initDataObject = ScriptableObject.CreateInstance<Data>();
        }
        string jsonStringTemp = JsonUtility.ToJson(initDataObject);
        JsonUtility.FromJsonOverwrite(jsonStringTemp, data);
    }

}
