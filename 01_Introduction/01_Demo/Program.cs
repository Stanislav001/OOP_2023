﻿namespace _01_Demo;

public class Program
{
    public static void Main()
    {
        Group group = new Group("first group");

        group.AddStudent();
        group.AddStudent();

        group.GetInformation();
    }
}