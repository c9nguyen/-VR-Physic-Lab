using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResetButtonListener : MonoBehaviour
{

    public Button startButtton;
    public Button resetButton;
	public Button elasticInelasticButton;

    public CarMovement car1;
    public CarMovement car2;
    public SliderListener car1Slider;
    public SliderListener car2Slider;
    public SliderListener car1MassSlider;
    public SliderListener car2MassSlider;
    public SliderListener car1PositionSlider;
    public SliderListener car2PositionSlider;
    private Vector3 car1OriginalPosition;
    private Vector3 car2OriginalPosition;

    // Use this for initialization
    void Start ()
    {
        resetButton = GetComponent<Button>();

        resetButton.interactable = false;  
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void reset()
    {
        //       car1.xVelocity = 0;
        //       car2.xVelocity = 0;
        Rigidbody rb1 = car1.GetComponent<Rigidbody>();
        Rigidbody rb2 = car2.GetComponent<Rigidbody>();

        rb1.position = car1.xPosition;
        rb2.position = car2.xPosition;

        rb1.velocity = new Vector3(0, 0, 0);
        rb2.velocity = new Vector3(0, 0, 0);

        // Enables all sliders and the start button
        car1Slider.GetComponent<Slider>().interactable = true;
        car2Slider.GetComponent<Slider>().interactable = true;
        car1MassSlider.GetComponent<Slider>().interactable = true;
        car2MassSlider.GetComponent<Slider>().interactable = true;
        car1PositionSlider.GetComponent<Slider>().interactable = true;
        car2PositionSlider.GetComponent<Slider>().interactable = true;
        startButtton.interactable = true;
		elasticInelasticButton.interactable = true;

        // Disables the reset button
        resetButton.interactable = false;

    }
}
