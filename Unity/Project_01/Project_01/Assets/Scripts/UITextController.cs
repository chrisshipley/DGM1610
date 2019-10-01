using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class UITextController : MonoBehaviour
{
    private Text textLable;
    public UnityEvent startEvent;

    // Start is called before the first frame update
    void Start()
    {
        textLable = GetComponent<Text>();
        startEvent.Invoke();
    }

    // Update is called once per frame
    public void UpdateText(IntData data)
    {
        textLable.text = data.value.ToString();
    }
}
