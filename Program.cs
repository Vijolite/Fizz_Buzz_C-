﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
namespace FizzBuzz
{
    class Program
    {
        static void Main (string[] args) {
            Console.WriteLine("Hello, World!");
            for (int i=1; i<=359; i++) {
                String output="";
                if (i%11==0) output+="Bong";
                else
                {
                if (i%3==0) output+="Fizz";
                if (i%5==0) output+="Buzz";
                if (i%7==0) output+="Bang";
                if (i%13==0) {
                    if (output.Length==0) output="Fezz";
                    else {
                        int b=output.IndexOf("B");
                        if (b==-1) output+="Fezz";
                        else {
                            //Console.WriteLine(output.Substring(0,b));
                            //Console.WriteLine(output.Substring(b,output.Length-b));
                            output=output.Substring(0,b)+"Fezz"+output.Substring(b,output.Length-b);
                            }
                        }
                    }
                }
                if (i%17==0 && output.Length>4) {
                    String newOutput="";
                    for (int j=0;j<output.Length;j+=4) {
                        String outputSub=output.Substring(j,4);
                        newOutput=outputSub+newOutput;
                    }
                    output=newOutput;
                }
                if (output=="") output=i.ToString();
                Console.WriteLine(i.ToString()+'-'+output);
            }
        }
    }
}