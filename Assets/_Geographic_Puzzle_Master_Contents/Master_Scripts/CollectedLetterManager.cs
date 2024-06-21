using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedLetterManager : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Push"))
        {
            // Letter A has been found
            print("Letter A discovered");
            Destroy(this.gameObject, 3);
        }
    }
}
