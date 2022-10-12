using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public int count;
    public bool canClick;

    public void ResetCount()
    {
        count = 0;
    }

    public void AddToCount()
    {
        count++;
        StartCoroutine(Test());
    }

    public void RemoveFromCount()
    {
        if (count == 0) return;
        count--;
        StartCoroutine(Test());
    }

    private IEnumerator Test()
    {
        canClick = false;
        yield return new WaitForSeconds(0.5F);
        canClick = true;
        yield return null;
    }
}
