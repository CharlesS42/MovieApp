using Microsoft.AspNetCore.Mvc;
using MovieReviewPlatform.Models;

namespace MovieReviewPlatform.Controllers
{
    public class MovieReviewController
    {

        public IActionResult GetReview()
        {
            return View(); //Return the view that will display the reviews.
        }

        public IActionResult AddReview(Movie movie)
        {
            //check if movie is valid, most likely to be done in the service rather than here.
            //Just thought to call the method made in the service here.
        }
        {

        }
    }
}
