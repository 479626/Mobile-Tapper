using UnityEngine;
using UnityEngine.UI;

public class TextManager : Counter
{
    [SerializeField] private Text counter;

    private void Start()
    {
        canClick = true;
    }

    private void Update()
    {
        UpdateCounter();
    }

    private void UpdateCounter()
    {
        counter.text = count.ToString();
    }
}
