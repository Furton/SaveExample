using UnityEngine;
using UnityEngine.UI;

public class Example : MonoBehaviour
{
    [SerializeField] private Text myText;
    [SerializeField] private Data data;

    public void Load()
    {
        SaveManager.instance.Load(data);
        myText.text = "монет: " + data.coins;
    }

    public void Save()
    {
        SaveManager.instance.Save(data);
    }

    public void Reset()
    {
        SaveManager.instance.Reset(data);
        myText.text = "монет: " + data.coins;
    }

    public void AddCoins()
    {
        data.coins++;
        myText.text = "монет: " + data.coins;
    }
}
