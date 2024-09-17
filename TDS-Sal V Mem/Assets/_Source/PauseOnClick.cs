using UnityEngine;

public class StopTime : MonoBehaviour
{
    public void OnClicStop()
    {


        Time.timeScale = 0;
    }
    public void OnClicReturn()
    {
        Time.timeScale = 1;
    }


}