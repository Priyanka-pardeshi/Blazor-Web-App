// See https://aka.ms/new-console-template for more information
using System.Collections;
using System;
using System.Drawing;
using System.IO;

Console.WriteLine("Hello, World!");

string userInput = Console.ReadLine(); // Read user input from console

 ImageToByteArrayFromFilePath(userInput);
byte[] ImageToByteArrayFromFilePath(string imagefilePath)
{
    byte[] imageArray = File.ReadAllBytes(imagefilePath);
    File.WriteAllBytes("C:\\Users\\priyanka.pardeshi\\Desktop\\generateimg.jpg", imageArray);
    return imageArray;
}