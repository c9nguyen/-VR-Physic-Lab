using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartButtonListener : MonoBehaviour {

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
        startButtton = GetComponent<Button>();

        //car1OriginalPosition = car1.transform.position;
        //car2OriginalPosition = car2.transform.position;

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void startMovement()
    {
        //car1OriginalPosition = car1.transform.position;
        //car2OriginalPosition = car2.transform.position;
        car1.xPosition = car1.transform.position;
        car2.xPosition = car2.transform.position;

        car1Slider.ChangeCarVelocity();
        car2Slider.ChangeCarVelocity();
        car1MassSlider.ChangeCarMass();
        car2MassSlider.ChangeCarMass();
        car1.addVelocity();
        car2.addVelocity();

        // Disables all sliders and the start button
        car1Slider.GetComponent<Slider>().interactable = false;
        car2Slider.GetComponent<Slider>().interactable = false;
        car1MassSlider.GetComponent<Slider>().interactable = false;
        car2MassSlider.GetComponent<Slider>().interactable = false;
        car1PositionSlider.GetComponent<Slider>().interactable = false;
        car2PositionSlider.GetComponent<Slider>().interactable = false;
        startButtton.interactable = false;
		elasticInelasticButton.interactable = false;

        //Enables the reset Button
        resetButton.interactable = true;


    }

    
}
