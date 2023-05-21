using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public int countdownTime;
    public Text countdownDisplay;

    private void Start(){
        StartCoroutine(CountdownToStart());

    }

    IEnumerator CountdownToStart()
    {
        while (countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;
        }
        countdownDisplay.text = "GAME OVER";

        yield return new WaitForSeconds(1f);

        countdownDisplay.gameObject.SetActive(false);

    }

}
