using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderListener : MonoBehaviour {

    public GameObject car;
    public Slider slider;
	public Text velocityText;
	float velocityValue;



    // Use this for initialization
    void Start () {
        slider = GetComponent<Slider>();


	}
	
	// Update is called once per frame
	void OnGUI ()
    {
        GUI.Label(new Rect(1, 1, 20, 20), "hi");
	
	}

    public void ChangeCarVelocity()
    {
		
        velocityValue = this.gameObject.GetComponent<Slider>().value;
		car.GetComponent<CarMovement>().ChangeCarVelocity(velocityValue);

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

	public void ChangeVelocityValue()
	{
		float value = velocityText.tag.Truncate (2);
		velocityText.text = "Car 1 Velocity: " + velocityValue.ToString ();
	}

	public static float Truncate(this float value, int digits)
	{
		double mult = Mathf.Pow (10.0, digits);
		double result = Mathf.Truncate (mult * value) / Mult;
		return (float) result;
	}
    
    
    

}
