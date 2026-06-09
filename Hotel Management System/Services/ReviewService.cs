using Hotel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Services
{
   public class ReviewService
    {
        public static void AddReview(BookingModel booking, ReviewModel review)

        {
            booking.reviews.Add(review);

           
        }

        public static void DisplayReviewsForBooking(BookingModel reviews)
        {
            if(reviews == null)
            {
                Console.WriteLine("No reviews yet");
            }

            else
            {
                Console.WriteLine($"Reviews Rating and commit:{reviews.bookingId}");
            }
        }

    }
}
