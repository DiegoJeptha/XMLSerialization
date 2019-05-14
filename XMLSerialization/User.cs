using System;
using XMLSerialization;

class User 
{ 
  [STAThread] 
  static void Main(string[] args) 
  { 
    if (args.Length != 2) 
    { 
      Console.WriteLine("Usage XMLSerialization  [r|s] filename"); 
      Console.WriteLine("r to read, s to save"); 
    } 
    else 
    { 
      string fileName = args[1]; 
      if (args[0] == "r") 
      { 
        System.Xml.Serialization.XmlSerializer  serializer = new  System.Xml.Serialization.XmlSerializer(typeof(Car)); 
 
        System.IO.FileStream stream = new System.IO.FileStream(fileName,System.IO.FileMode.Open); 
 
        Car obj = serializer.Deserialize(stream) as Car; 
 
        Console.WriteLine(obj); 
      } 
      else 
      { 
        Car obj = new Car(); 
        obj.yearOfMake = 2002; 
 
        System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Car)); 
 
        System.IO.FileStream stream = new System.IO.FileStream(fileName,System.IO.FileMode.Create); 
 
        serializer.Serialize(stream, obj); 
      } 
    } 
  } 
} 