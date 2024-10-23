// See https://aka.ms/new-console-template for more information
using System;
using NAudio.Wave;
using(var audioFile = new AudioFileReader("ICOCTF.wav"))
using(var outputDevice = new WaveOutEvent())
{



    outputDevice.Init(audioFile);
    outputDevice.Play();

    string[] num = {"ONE", "TWO", "THREE"};

    while (outputDevice.PlaybackState == PlaybackState.Playing)
    {
        foreach (string n in num)
        {
            Console.WriteLine($"{n}!");
            Thread.Sleep(1000);
            Console.WriteLine($"WHAT COMES AFTER {n}?!");
            Thread.Sleep(1000);
        }
        foreach (char i in "FOOOOOOUUURRR!!!")
        {
            Console.Write(i);
            Thread.Sleep(100);
        }
        Thread.Sleep(10000);
    }
}
class Programm
{
public static void Main(){
   
}
}
