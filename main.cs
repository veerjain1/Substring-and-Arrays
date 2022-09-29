using System;

class Program {
  public static void Main (string[] args) {

    //Substring
    //nameOfString.Substring(startIndex, length)
    string aString = "My favorite class is Math";
    string bString;

    //use subString
    bString = aString.Substring(0,19);

    string[] stringArray = new string[25];

    for(int i=0; i<25; i++)
    {
      stringArray[i] = bString.Substring(i,1);
    }

    string[] newArray = new string[30]; 

    for(int j = 0; j<25; j++)
    {
      newArray[j] = stringArray[j];
    }
    newArray[28] = "!";
    newArray[22] = "V";
    newArray[26] = "E";       
    newArray[25] = "N";
    newArray[27] = "T";
    newArray[23] = "S";
    newArray[24] = ".";
for(int x = 0; x<30; x++)
    {
      Console.WriteLine(newArray[x]);
    }
    


    
  }
}