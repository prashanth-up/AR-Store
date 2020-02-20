using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{
    public void PremiumBut() {
         SceneManager.LoadScene("rolex");
    }
    public void SmartBut() {
        SceneManager.LoadScene("apple");
    }
    public void HomeButton() {
        SceneManager.LoadScene("watchStore");
    } 
    public void KidsBut() {
        SceneManager.LoadScene("");
    } 
    public void rolexOriginal() {
        SceneManager.LoadScene("rolex");
    } 
    public void rolexWhite() {
        SceneManager.LoadScene("rolexWhite");
    } 
    public void rolexBlack() {
        SceneManager.LoadScene("rolexBlack");
    } 
    public void watchStore() {
        SceneManager.LoadScene("watchStore");
    } 
    public void carGarage() {
        SceneManager.LoadScene("carGarage");
    } 
    public void PremiumCar() {
        SceneManager.LoadScene("audi");
    } 
    public void RaceCar() {
        SceneManager.LoadScene("bugatti");
    }
    public void Credit() {
        SceneManager.LoadScene("Credits");
    } 
    public void About() {
        SceneManager.LoadScene("About");
    }
    public void MainBut() {
        SceneManager.LoadScene("home");
    }
    public void archHome(){
        SceneManager.LoadScene("archHome");
    }
    public void building(){
        SceneManager.LoadScene("build01");
    }
    public void build01(){
        SceneManager.LoadScene("build01");
    }
    public void build01blue(){
        SceneManager.LoadScene("build01blue");
    }
    public void build01green(){
        SceneManager.LoadScene("build01green"); 
    }
    public void tajmahal(){
        SceneManager.LoadScene("tajMahal");
    }
    public void earth(){
        SceneManager.LoadScene("earth");
    }
    public void city(){
        SceneManager.LoadScene("cityPlan");
    }


}
