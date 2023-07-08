using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerCanvas : MonoBehaviour
{
    //Ajuste Volumen
    public AudioSource audioSource;
    public Slider volumeSlider;
    public Slider sliderSet;
    //Panel
    public GameObject Panel;
    //Toggle
    public Toggle audioToggle;
  

    private void Start()
    {
        float sliderValue = sliderSet.value;
        volumeSlider.value = audioSource.volume;
        audioToggle.isOn = audioSource.enabled;
    }

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }

    public void Niveles(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }


    public void Quit()
    {
        Application.Quit();
    }

    public void ActivatePanel()
    {
        Panel.SetActive(true);
    }

    public void DeactivatePanel()
    {
        Panel.SetActive(false);
    }
    public void ToggleAudio(bool isOn)
    {
        // Activar o desactivar el AudioT según el estado del Toggle
        audioSource.enabled = isOn;
    }
}
