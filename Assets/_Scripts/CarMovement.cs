using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CarMovement : MonoBehaviour {

    public float xVelocity;

    public float yVelocity;

    public Text reportText;

    public Vector3 xPosition;

    public bool inelastic = true;

    private Rigidbody rb;
    private bool changed = false;
    private float oldVelocity;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    //Update is called once per frame

    void FixedUpdate()
    {
        //       rb.velocity = new Vector3(velocity, rb.velocity.y, rb.velocity.z);
        //   Debug.Log(rb.mass);
        //  Debug.Log(rb.velocity);
        reportText.text = "Velocity: " + xVelocity;
    }

    void OnCollisionEnter(Collision other)
    {
        //   Debug.Log(other.gameObject.tag);

        if (inelastic)
        {
            rb.AddForce(0, 0, xVelocity, ForceMode.VelocityChange);
        }
        else
        {
            if (other.gameObject.tag == "Object")
            {
                oldVelocity = xVelocity;

                float mass1 = rb.mass;

                float otherMass = other.gameObject.GetComponent<Rigidbody>().mass;
                float otherVelocity;

                if (other.gameObject.GetComponent<CarMovement>().changed)
                {
                    otherVelocity = other.gameObject.GetComponent<CarMovement>().oldVelocity;
                    //Debug.Log("Mass1:" + mass1);
                    //Debug.Log("Mass2:" + otherMass);
                    //Debug.Log("Velocity:" + xVelocity);
                    //Debug.Log("Velocity2:" + otherVelocity);
                }
                else
                {
                    otherVelocity = other.gameObject.GetComponent<CarMovement>().xVelocity;
                    //Debug.Log("Mass1:" + mass1);
                    //Debug.Log("Mass2:" + otherMass);
                    //Debug.Log("Velocity:" + xVelocity);
                    //Debug.Log("Velocity2:" + otherVelocity);
                }

                xVelocity = ((mass1 - otherMass) * xVelocity + 2 * otherMass * otherVelocity) / (mass1 + otherMass);
                //Debug.Log("VelocityF:" + xVelocity);
                addVelocity();
                changed = true;
            }

        }
    }

    void OnCollisionExit(Collision other)
    {
        changed = false;
    }

    public void ChangeCarVelocity(float newValue)
    {
        xVelocity = newValue;
     
    }

    public void ChangeCarMass(float newValue)
    {
        rb.mass = newValue;
        //Debug.Log("Mass:" + rb.mass);
    }

    public void ChangeCarPosition(float newValue)
    {
        rb.MovePosition(new Vector3(0, 0, newValue));
    }

    public void addVelocity()
    {
         rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, xVelocity);
  
    }

    //// Alex Smells. 
    //public void calculateVelocity(Rigidbody rb1, Rigidbody rb2)
    //{

    //    xVelocity = ((rb1.mass - rb2.mass) * rb1.velocity.x + 2 * rb2.mass * rb1.velocity.x) / (rb1.mass + rb2.mass);
    //    // rb1.velocity = new Vector3(((rb1.mass - rb2.mass) * rb1.velocity.x + 2 * rb2.mass * rb1.velocity.x) / (rb1.mass + rb2.mass), 0, 0);
    //    // rb2.velocity = new Vector3((2 * rb1.mass * rb1.velocity.x - (rb1.mass - rb2.mass) * rb2.velocity.x / (rb1.mass + rb2.mass)), 0, 0);

    //}
}
