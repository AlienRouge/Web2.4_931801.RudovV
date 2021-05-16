using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class MockupController : Controller
    {
        private static readonly Random random = new Random();
        private static readonly QuizModel quiz = new QuizModel();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Quiz()
        {
            Generate();
            return View();
        }

        public IActionResult QuizResult()
        {
            ViewBag.ListResult = quiz.ListResult;
            ViewBag.RightAnswersCount = quiz.RightAnswersCount;
            ViewBag.AnswersCount = quiz.AnswersCount;

            return View();
        }

        public IActionResult Next(string value1, string value2, string answer, string operation)
        {
            ConvertAndCalculate(value1,value2,answer,operation);
            Generate();

            return View("Quiz");
        }

        public IActionResult Result(string value1, string value2, string answer, string operation)
        {
            ConvertAndCalculate(value1, value2, answer, operation);
            ViewBag.ListResult = quiz.ListResult;
            ViewBag.RightAnswersCount = quiz.RightAnswersCount;
            ViewBag.AnswersCount = quiz.AnswersCount;

            return View("QuizResult");
        }

        public void Generate()
        {
            ViewBag.num1 = random.Next(10);
            ViewBag.num2 = random.Next(10);
            ViewBag.operation = random.Next(2) == 1 ? "+" : "-";
        }

        public void ConvertAndCalculate(string num1, string num2, string answer, string operation)
        {
            int Num1 = Convert.ToInt32(num1);
            int Num2 = Convert.ToInt32(num2);
            int Answer = Convert.ToInt32(answer);

            quiz.ListResult.Add(Num1 + " " + operation + " " + Num2 + " = " + Answer);
            if ((operation == "+" && Num1 + Num2 == Answer) ||
                (operation == "-" && Num1 - Num2 == Answer))
                quiz.RightAnswersCount++;
            quiz.AnswersCount++;
        }
    }
}