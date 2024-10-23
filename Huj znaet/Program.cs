// See https://aka.ms/new-console-template for more information
using System;
using NAudio.Wave;
using(var audioFile = new AudioFileReader("ICOCTF.wav"))
using(var outputDevice = new WaveOutEvent())
{
    Console.WriteLine("ONE!");
    Console.WriteLine("WHAT COMES AFTER ONE?!");
    Console.WriteLine("TWO!");
    Console.WriteLine("WHAT COMES AFTER TWO ?!");
    Console.WriteLine("THREE!");
    Console.WriteLine("WHAT COMES THREE?!");
    Console.WriteLine("FOOOUUUURRR!!!!!");
     outputDevice.Init(audioFile);
    outputDevice.Play();
    while (outputDevice.PlaybackState == PlaybackState.Playing)
    {
        Thread.Sleep(1000);
    }
}
class Programm
{
public static void Main(){
   
}
}
