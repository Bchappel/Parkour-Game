using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
//using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScene : MonoBehaviour
{
    private void Update()
    {
        //Cursor.lockState = CursorLockMode.None;
        //UnityEngine.Cursor.visible = true;
    }


    //public Vector3 teleportTo = Vector3.zero;
    private void OnTriggerEnter(Collider other)
    {
        //InterpolatedTransform movable = null;
        //if ((movable = other.GetComponent<InterpolatedTransform>()) == null) return;
        //if (movable as PlayerMovement)
        //    movable.ResetPositionTo(teleportTo);

        SceneManager.LoadScene(2);
        //Cursor.lockState = CursorLockMode.None;
        //UnityEngine.Cursor.visible = true;

    }

}
