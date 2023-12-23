using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimasyonKontrol : MonoBehaviour
{
    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();

    }
    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.R))
        {
            _animator.SetBool("isRunning", true);
            transform.Translate(new Vector3(0.9f, 0.12f, 2f) * Time.deltaTime);
        }
        else
            _animator.SetBool("isRunning", false);

        if (Input.GetKey(KeyCode.T))
        {
            _animator.SetBool("isSomersault", true);
            transform.Translate(new Vector3(0.9f, 0.12f, 3f) * Time.deltaTime);
        }
        else
            _animator.SetBool("isSomersault", false);
    }

}
