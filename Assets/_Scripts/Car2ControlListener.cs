using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Car2ControlListener : MonoBehaviour
{

	public GameObject car;
	public Text myValueDisplayer;
	//    public Text velocityText;
	public static float velocityValue;
	public static float massValue;
	public static float positionValue;
	public Button decreaseButton;
	public Button increaseButton;
//	public Button decreaseButton;
//	public Button increaseMassButton;
//	public Button decreasePositionButton;
//	public Button increasePositionButton;



	// Use this for initialization
	void Start ()
	{
		
		//myValueDisplayer = GetComponent<Text>();
		Debug.Log (myValueDisplayer);
		velocityValue = 0;
		//		velocityText = this.gameObject.GetComponent<Text> ();
//		increaseButton.In


	}

	// Update is called once per frame
	void OnGUI ()
	{
		// GUI.Label(new Rect(1, 1, 20, 20), "hi");

	}

	public void IncreaseCarVelocity()
	{
		if (velocityValue > -2.0f)
		{
			car.GetComponent<CarMovement> ().ChangeCarVelocity (-0.1f);
			velocityValue -= 0.1f;
			velocityValue = (float)(Math.Round ((double)velocityValue, 2));
			myValueDisplayer.text = (-1 * velocityValue).ToString () + "\nm/s";

			//Debug.Log (velocityValue.ToString ());
			if (!decreaseButton.interactable) 
			{
				decreaseButton.interactable = true;
			}


		} 
		else 
		{
			increaseButton.interactable = false;
		}
	}

	public void DecreaseCarVelocity ()
	{
		if (velocityValue < 2.0f) 
		{
			car.GetComponent<CarMovement> ().ChangeCarVelocity (0.1f);
			velocityValue += 0.1f;
			velocityValue = (float)(Math.Round ((double)velocityValue, 2));
			myValueDisplayer.text = (-1 * velocityValue).ToString () + "\nm/s";

			if (!increaseButton.interactable) 
			{
				increaseButton.interactable = true;
			}
		}
		else 
		{
			decreaseButton.interactable = false;
		}
			
	}

	public void IncreaseCarMass()
	{
		if (velocityValue > -10.0f)
		{
			car.GetComponent<CarMovement> ().ChangeCarVelocity (-0.5f);
			massValue -= 0.5f;
			massValue = (float)(Math.Round ((double)massValue, 2));
			myValueDisplayer.text = (-1 * massValue).ToString () + "\nkg";

			//Debug.Log (velocityValue.ToString ());
			if (!decreaseButton.interactable) 
			{
				decreaseButton.interactable = true;
			}


		} 
		else 
		{
			increaseButton.interactable = false;
		}
	}

	public void DecreaseCarMass ()
	{
		if (velocityValue < 10.0f) 
		{
			car.GetComponent<CarMovement> ().ChangeCarVelocity (0.5f);
			massValue += 0.5f;
			massValue = (float)(Math.Round ((double)massValue, 2));
			myValueDisplayer.text = (-1 * massValue).ToString () + "\nkg";

			if (!increaseButton.interactable) 
			{
				increaseButton.interactable = true;
			}
		}
		else 
		{
			decreaseButton.interactable = false;
		}

	}

	public void IncreaseCarPosition()
	{
		if (velocityValue > -4.5f)
		{
			car.GetComponent<CarMovement> ().ChangeCarVelocity (-0.1f);
			positionValue -= 0.1f;
			positionValue = (float)(Math.Round ((double)positionValue, 2));
			myValueDisplayer.text = (-1 * positionValue).ToString () + "\nmeters";

			//Debug.Log (velocityValue.ToString ());
			if (!decreaseButton.interactable) 
			{
				decreaseButton.interactable = true;
			}


		} 
		else 
		{
			increaseButton.interactable = false;
		}
	}

	public void DecreaseCarPosition ()
	{
		if (velocityValue < 2.0f) 
		{
			car.GetComponent<CarMovement> ().ChangeCarVelocity (0.1f);
			positionValue += 0.1f;
			positionValue = (float)(Math.Round ((double)positionValue, 2));
			myValueDisplayer.text = (-1 * positionValue).ToString () + "\nmeters";

			if (!increaseButton.interactable) 
			{
				increaseButton.interactable = true;
			}
		}
		else 
		{
			decreaseButton.interactable = false;
		}

	}



//	private void Increase(float theUnit, float theAmount, class theClass)
//	{
//		theUnit += theAmount;
//
//	}

//	public void ChangeCarVelocity()
//	{
//		car.GetComponent<CarMovement> ().ChangeCarVelocity (velocityValue);
//
//		//		//Change car velocity text value
//		//		float value = Truncate(velocityValue, 2);
//		//		velocityText.text = "Car 1 Velocity: " + velocityValue.ToString ();
//	}

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
