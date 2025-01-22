using UnityEngine;

public class OptionParent : MonoBehaviour
{


    protected void PlaySelectedSound()
    {
        AudioManager.instance.Play("Confirm");
    }
}
