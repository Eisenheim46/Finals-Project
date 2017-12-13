using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCursor : MonoBehaviour {

    public void Start()
    {

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }
}
