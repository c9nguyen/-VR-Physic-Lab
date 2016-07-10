using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CollisionListener : MonoBehaviour
{
    public CarMovement car1;
    public CarMovement car2;
    public bool flag= true;
    public Button button;

    // Use this for initialization
    void Start ()
    {
        flag = true;
        button = GetComponent<Button>();
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void CollisionType()
    {
        if (flag)
        {
			button.GetComponentInChildren<Text>().text = "Elastic";
            Debug.Log("oh");
            //button.GetComponent<GUIText>().text = "Elastic";
            car1.inelastic = false;
            car2.inelastic = false;
            flag = false;

        }

        else
        {
			button.GetComponentInChildren<Text>().text = "Inelastic";
            Debug.Log("hi");
           // button.GetComponent<GUIText>().text = "Inelastic";
            car1.inelastic = true;
            car2.inelastic = true;
            flag = true;
        }
    }
}
