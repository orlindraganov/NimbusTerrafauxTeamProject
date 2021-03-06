﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using DungeonsOfOOP.Structures;
using DungeonsOfOOP.Views;
using DungeonsOfOOP.Models;


namespace DungeonsOfOOP
{
    class MainGame
    {
        public static Renderer Renderer = new Renderer();

        static void Main(string[] args)
        {

            //var random = new Random();

            //while (true)
            //{
            //    var questionIndex = random.Next(Questionnaire.questions.Count - 1);
            //    if (Quiz.AskQuestion(questionIndex, Questionnaire.questions))
            //    {
            //        Console.WriteLine("True");
            //        Questionnaire.questions[questionIndex].ParentNode.RemoveChild(Questionnaire.questions[questionIndex]);
            //    }
            //    else
            //    {
            //        Console.WriteLine("False");
            //        Questionnaire.questions[questionIndex].ParentNode.RemoveChild(Questionnaire.questions[questionIndex]);
            //    }
            //}

            //Draw images
            Renderer.SetConsoleProperties();
            Renderer.SetPictureAtPosition("doncho", new Position(10, 40));
            Renderer.SetPictureAtPosition("cuki", new Position(150, 40));
            Renderer.SetPictureAtPosition("marto", new Position(10, 200));
            Renderer.SetPictureAtPosition("koceto", new Position(150, 200));

        }
    }
}
