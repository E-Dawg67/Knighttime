using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;
using System.Collections;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float x, y, prevUP;
    Vector3 move;
    private GameObject colided;
    public GameObject sword;
    private Rigidbody rb;
    private bool jump = true;
    public Animator swordAnimator;

    void Start()
    {
        Cursor.visible = false;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, Input.GetAxis("Mouse X") * 5f, 0);

        if (Keyboard.current.spaceKey.wasPressedThisFrame && jump)
        {
            rb.linearVelocity = new Vector3(this.gameObject.GetComponent<Rigidbody>().linearVelocity.x, 20f, this.gameObject.GetComponent<Rigidbody>().linearVelocity.z);
        }

        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(PerformSlash());
        }
    }

    private void FixedUpdate()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        move = transform.right * x + transform.forward * y;
        prevUP = rb.linearVelocity.y;
        rb.linearVelocity = move * 1000f * Time.fixedDeltaTime;
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, prevUP, rb.linearVelocity.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (colided == null)
        {
            jump = true;
            colided = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == colided)
        {
            jump = false;
            colided = null;
        }
    }

    private IEnumerator PerformSlash()
    {
        swordAnimator.SetBool("swing", true);
        sword.GetComponent<BoxCollider>().enabled = true;
        yield return new WaitForSeconds(0.75f);
        sword.GetComponent<BoxCollider>().enabled = false;
        swordAnimator.SetBool("swing", false);
    }
}