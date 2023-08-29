using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shpik : MonoBehaviour
{
    //Pjesa par

    // [SerializeField] nese o qasja private perdoret per me mujt me modifiku vleren.
    // public int a = 5;
    // public int b = 5;
    // string meshazi = "Gent Maloku";

    //Pjesa dyte

    // public bool para = true;
    // public bool dyta = true;

    //Pjesa trete

    // public int testNumber = 8;
    // public int minRage = 4;
    // public int maxRange = 16;

    // public Vector2Int range = new Vector2Int(4,16);

    //Pjesa katert

    [System.Serializable]
    public class Person{

        //Konstruktori
        public Person(string name, string surname, int age){
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public string name;
        public string surname;
        public int age;
        
        public void Introduce(){
            Debug.Log("Une jame " + name + " " + surname + " dhe i kam " + age + " vjet." );
        }
    }
    //Krijimi i Instancave
    // public Person personOne;
    // public int numberOne;


    void Start(){
        
        //Pjesa pare
        // int c = a + b;

        // Debug.Log("Hello Shpik");
        // Debug.Log(a + b);
        // Debug.Log(c);
        // Debug.Log(meshazi);

        //Pjesa dyte

        // if(c > 10){
        //     Debug.Log("Shuma e C eshte me e madhe se 10, shume eshte " + c);
        // }else{
        //     Debug.Log("Shuma nuk e ka kaluar numrin 10, shuma eshte "  + c);
        // }


        // if(para == true && dyta == true){
        //     Debug.Log("Te dyjat aktive");
        // }
        // if(para == true || dyta == true){
        //     Debug.Log("Vetem njera eshte aktive");
        // }

        // if(a == b){
        //     Debug.Log("A dhe B jane te barabarta");
        // }else{
        //     Debug.Log("Nuk jane");
        // }

        //Pjesa trete
        // int c = Shuma(a,b);
        
        // Debug.Log(c);

        // string meshazi = CombineString("Hello" , "world");
        // Debug.Log(meshazi);

        // ExampleMethod();
        // IsInsideRange(testNumber, minRage, maxRange);
        // IsInsideRange(testNumber, range.x, range.y);

        //Pjesa Katert

        // personOne.Introduce();
        // personOne.name = "Filan";
        // personOne.Introduce();

        // Person newPerson = personOne;
        // newPerson.name = "Filan";
        
        // Debug.Log(newPerson.name);
        // Debug.Log(personOne.name);

        // int newNumber = numberOne;
        // newNumber = 5;

        // Debug.Log(newNumber);
        // Debug.Log(numberOne);

        // newPerson.name = "filani";

        // Debug.Log(newPerson.name);
        // Debug.Log(personOne.name);

        Person newPerson = new Person("Genti", "Malokuu", 25);
        newPerson.Introduce();
        

    //Pjesa trete
    // int Shuma(int numri1, int numri2){

    //     return numri1 + numri2;
    // }

    // string CombineString(string  text1, string text2){
    //     return text1 + " " + text2; 
    // }

    // void ExampleMethod(){
    //     Debug.Log("This is Example Method");
    // }
    
    // bool IsInsideRange(int x, int minRage, int maxRange){
        
    //     if(x >= minRage && x <= maxRange){

    //         Debug.Log("The Number is inside the range");

    //         return true;
    //     }

    //      Debug.Log("The Number is outside the range");
    //     return false;
    // }


    }
    
   

}
