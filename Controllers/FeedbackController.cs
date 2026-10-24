using Feedback_Management.Models;
using Microsoft.AspNetCore.Mvc;

namespace Feedback_Management.Controllers
{
    public class FeedbackController : Controller
    {
        // In-memory storage for this demonstration. Data resets when the app restarts.
        private static readonly List<Feedback> FeedbackItems = new()
        {
            new Feedback
            {
                Id = 1,
                Name = "Rahul Sharma",
                Email = "rahul@example.com",
                Rating = 5,
                Comments = "Great platform and smooth navigation!"
            },
            new Feedback
            {
                Id = 2,
                Name = "Priya Patel",
                Email = "priya@example.com",
                Rating = 4,
                Comments = "Good UI layout, looking forward to updates."
            }
        };

        public IActionResult Index()
        {
            ViewBag.TotalFeedbacks = FeedbackItems.Count;
            ViewBag.AverageRating = FeedbackItems.Count == 0
                ? 0
                : FeedbackItems.Average(f => f.Rating).ToString("0.0");
            ViewBag.ResponseRate = FeedbackItems.Count == 0 ? "0%" : "100%";

            return View(FeedbackItems.OrderByDescending(f => f.Id).ToList());
        }

        [HttpGet]
        public IActionResult SubmitFeedback()
        {
            return View("FeedbackForm", new Feedback());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitFeedback(Feedback feedback)
        {
            if (!ModelState.IsValid)
            {
                return View("FeedbackForm", feedback);
            }

            feedback.Id = FeedbackItems.Count == 0 ? 1 : FeedbackItems.Max(f => f.Id) + 1;
            FeedbackItems.Add(feedback);

            TempData["SuccessMessage"] = "Your feedback was submitted successfully.";
            return RedirectToAction(nameof(Index));
        }
    }
}
