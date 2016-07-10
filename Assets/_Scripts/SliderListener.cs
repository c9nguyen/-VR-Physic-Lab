using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class SliderListener : MonoBehaviour {

    public GameObject car;
    public Slider slider;
//    public Text velocityText;
	float velocityValue;



    // Use this for initialization
    void Start () {
        slider = GetComponent<Slider>();
//		velocityText = this.gameObject.GetComponent<Text> ();


	}
	
	// Update is called once per frame
	void OnGUI ()
    {
       // GUI.Label(new Rect(1, 1, 20, 20), "hi");
	
	}

    public void ChangeCarVelocity()
	{
		
		velocityValue = this.gameObject.GetComponent<Slider> ().value;
		car.GetComponent<CarMovement> ().ChangeCarVelocity (velocityValue);

//		//Change car velocity text value
//		float value = Truncate(velocityValue, 2);
//		velocityText.text = "Car 1 Velocity: " + velocityValue.ToString ();
	}

    public void ChangeCarMass()
    {
        float value = this.gameObject.GetComponent<Slider>().value;
        car.GetComponent<CarMovement>().ChangeCarMass(value);
    }

    public void ChangeCarPosition()
    {
        float value = this.gameObject.GetComponent<Slider>().value;
        car.GetComponent<CarMovement>().ChangeCarPosition(value);
    } 

//	public void ChangeVelocityValue()
//	{
//		float value = Truncate(velocityValue, 2);
//		//velocityText.text = "Car 1 Velocity: " + value.ToString ();
//	}

	public static float Truncate(float value, int digits)
	{
		double mult = Math.Pow (10.0, digits);
		double result = Math.Truncate (mult * value) / mult;
		return (float) result;
	}
    
    
    

}
