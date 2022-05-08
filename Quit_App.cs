using UnityEngine;

public class Quit_App : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Application succesfully quit");
    }
}
